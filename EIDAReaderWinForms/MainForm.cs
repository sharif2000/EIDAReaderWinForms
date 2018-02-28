using EIDAReaderWinForms.EL;
using EmiratesId.AE.PublicData;
using EmiratesId.AE.Utils;
using Microsoft.SharePoint.Client;
using System;
using System.Drawing;
using System.Globalization;
using System.Net;
using System.Net.NetworkInformation;
using System.Windows.Forms;

namespace EIDAReaderWinForms
{
    public partial class MainForm : System.Windows.Forms.Form
    {
        #region Global

        public CardHolderPublicDataEx publicDataEx;
        bool IsUserExisting = false;
        string ExistingUserID;

        #endregion Global

        #region Constructor

        public MainForm()
        {
            InitializeComponent();
        }

        #endregion Constructor

        private void MainForm_Load(object sender, EventArgs e)
        {
            foreach (string key in ConfigFileData.RequestTypes)
            {
                ComboboxItem item = new ComboboxItem();
                item.Text = key;
                item.Value = ConfigFileData.RequestTypes[key];
                cboRequestTypes.Items.Add(item);
            }
            cboRequestTypes.SelectedIndex = 0;
        }

        private void btnReadCard_Click(object sender, EventArgs e)
        {
            try
            {
                publicDataEx = new BLL.CardReader().ReadCard();

                txtArabicFullName.Text = PublicDataUtils.RemoveCommas(Utils.ByteArrayToUTF8String(publicDataEx.ArabicFullName));
                txtFullName.Text = PublicDataUtils.RemoveCommas(Utils.ByteArrayToUTF8String(publicDataEx.FullName));
                txtMotherFullNameArabic.Text = Utils.ByteArrayToUTF8String(publicDataEx.MotherFullNameArabic);
                txtIDNumber.Text = Utils.ByteArrayToUTF8String(publicDataEx.IdNumber);
                picPhotography.Image = (Image)new ImageConverter().ConvertFrom(publicDataEx.Photography);
                txtNationalityAr.Text = Utils.ByteArrayToUTF8String(publicDataEx.ArabicNationality);
                txtIssueDate.Text = Utils.ByteArrayToStringDate(publicDataEx.IssueDate);
                txtExpiryDate.Text = Utils.ByteArrayToStringDate(publicDataEx.ExpiryDate);
                txtDateOfBirth.Text = Utils.ByteArrayToStringDate(publicDataEx.DateOfBirth);

                txtPlaceOfBirthArabic.Text = Utils.ByteArrayToUTF8String(publicDataEx.PlaceOfBirthArabic);
                txtSex.Text = PublicDataUtils.GetSex(Utils.ByteArrayToUTF8String(publicDataEx.Sex));
                txtMaritalStatus.Text = PublicDataUtils.GetMaritalStatus(Utils.ByteArrayToHex(publicDataEx.MaritalStatus, ""));
                txtQualificationLevelDescriptionArabic.Text = Utils.ByteArrayToUTF8String(publicDataEx.QualificationLevelDescriptionArabic);

                txtDegreeDescriptionArabic.Text = Utils.ByteArrayToUTF8String(publicDataEx.DegreeDescriptionArabic);
                txtMobilePhoneNumber.Text = Utils.ByteArrayToUTF8String(publicDataEx.HomeAddress.MobilePhoneNumber);
                txtResidentPhoneNumber.Text = Utils.ByteArrayToUTF8String(publicDataEx.HomeAddress.ResidentPhoneNumber);
                txtPOBox.Text = Utils.ByteArrayToUTF8String(publicDataEx.HomeAddress.POBox);
                txtEmail.Text = Utils.ByteArrayToUTF8String(publicDataEx.HomeAddress.Email);
                txtLandPhoneNo.Text = Utils.ByteArrayToUTF8String(publicDataEx.WorkAddress.LandPhoneNo);

                txtPassportNumber.Text = Utils.ByteArrayToUTF8String(publicDataEx.PassportNumber);
                txtPassportIssueDate.Text = Utils.ByteArrayToStringDate(publicDataEx.PassportIssueDate);
                txtPassportExpiryDate.Text = Utils.ByteArrayToStringDate(publicDataEx.PassportExpiryDate);
                txtPassportCountryDescriptionArabic.Text = Utils.ByteArrayToUTF8String(publicDataEx.PassportCountryDescriptionArabic);
                txtOccupation.Text = PublicDataUtils.GetOccupation(Utils.ByteArrayToHex(publicDataEx.Occupation));
                txtCompanyNameArabic.Text = Utils.ByteArrayToUTF8String(publicDataEx.WorkAddress.CompanyNameArabic);
                txtEmirateDescriptionArabic.Text = Utils.ByteArrayToUTF8String(publicDataEx.HomeAddress.EmirateDescriptionArabic);
                txtCityDescriptionArabic.Text = Utils.ByteArrayToUTF8String(publicDataEx.HomeAddress.CityDescriptionArabic);
                txtResidencyType.Text = PublicDataUtils.GetResidencyType(Utils.ByteArrayToHex(publicDataEx.ResidencyType, ""));
                txtResidencyNumber.Text = Utils.ByteArrayToUTF8String(publicDataEx.ResidencyNumber);
                txtResidencyExpiryDate.Text = Utils.ByteArrayToStringDate(publicDataEx.ResidencyExpiryDate);

                #region Checking If User Existing

                ClientContext context = new ClientContext(ConfigFileData.SP_URL);

                List TestForClientsList = context.Web.Lists.GetByTitle(ConfigFileData.ListName);

                bool CheckIfUserExisting = get_CheckIfUserExisting_value();

                if (CheckIfUserExisting)
                {
                    CamlQuery camlQuery = new CamlQuery();
                    camlQuery.ViewXml =
                       @"<View>
                                <Query>
                                   <Where><Eq><FieldRef Name='IDNumber' /><Value Type='Text'>" + txtIDNumber.Text + @"</Value></Eq></Where>
                                </Query>
                                 <ViewFields><FieldRef Name='ID' /></ViewFields>
                          </View>";

                    ListItemCollection listItems = TestForClientsList.GetItems(camlQuery);
                    context.Load(listItems);
                    context.Credentials = new NetworkCredential(ConfigFileData.UserName, ConfigFileData.Password);
                    context.ExecuteQuery();

                    if (listItems.Count > 0)
                    {
                        IsUserExisting = true;
                        ExistingUserID = listItems[0]["ID"].ToString();
                        string PreviousRequestsLink = ConfigFileData.PreviousRequestsLink + ExistingUserID;
                        txtStatus.Text = "البطاقة مسجلة مسبقا. اضغط الرابط التالى لعرض الطلبات السابقة " + "\n" + PreviousRequestsLink;
                        txtStatus.BackColor = Color.SkyBlue;
                        return;
                    }
                }

                #endregion Checking If User Existing

                txtStatus.BackColor = Color.LightGreen;
                txtStatus.Text = "تم قراءة بيانات البطاقة بنجاح";
            }
            catch (Exception ex)
            {
                txtStatus.BackColor = Color.LightCoral;

                switch (ex.Message)
                {
                    case "NO PCSC Readers":
                        txtStatus.Text = "خطأ : لا يوجد جهاز قارئ للبطاقة";
                        break;

                    case "E_SELECT_CM_APPLICATION":
                        txtStatus.Text = "خطأ : لا توجد بطاقة هوية بداخل القارئ";
                        break;

                    default:
                        txtStatus.Text = ex.Message;
                        break;
                }
            }
        }

        private void btnSaveToSP_Click(object sender, EventArgs e)
        {
            try
            {
                if (IsUserExisting)
                {
                    OpenSelectedRequestLink_InBrowser(ExistingUserID);
                    return;
                }

                ClientContext context = new ClientContext(ConfigFileData.SP_URL);

                List ImageLibrary = context.Web.Lists.GetByTitle(ConfigFileData.ImageLibraryName);
                List TestForClientsList = context.Web.Lists.GetByTitle(ConfigFileData.ListName);

                var fileCreationInformation = new FileCreationInformation();
                fileCreationInformation.Content = publicDataEx.Photography;
                fileCreationInformation.Url = txtIDNumber.Text + ".jpg";
                fileCreationInformation.Overwrite = true;
                File uploadedImage = ImageLibrary.RootFolder.Files.Add(fileCreationInformation);
                context.Load(uploadedImage);

                //===============================================================================

                ListItemCreationInformation itemCreateInfo = new ListItemCreationInformation();
                ListItem newItem = TestForClientsList.AddItem(itemCreateInfo);
                newItem["ArabicFullName"] = txtArabicFullName.Text;
                newItem["FullName"] = txtFullName.Text;
                newItem["MotherFullNameArabic"] = txtMotherFullNameArabic.Text;
                newItem["IDNumber"] = txtIDNumber.Text;

                newItem["Photography"] = ConfigFileData.SP_URL + "/" + ConfigFileData.ImageLibraryName + "/" + uploadedImage.Name;

                newItem["NationalityAr"] = txtNationalityAr.Text;

                if (!String.IsNullOrEmpty(txtIssueDate.Text))
                    newItem["IssueDate"] = DateTime.Parse(txtIssueDate.Text, new CultureInfo("en-GB"));

                if (!String.IsNullOrEmpty(txtExpiryDate.Text))
                    newItem["ExpiryDate"] = DateTime.Parse(txtExpiryDate.Text, new CultureInfo("en-GB"));

                if (!String.IsNullOrEmpty(txtDateOfBirth.Text))
                    newItem["DateOfBirth"] = DateTime.Parse(txtDateOfBirth.Text, new CultureInfo("en-GB"));

                newItem["PlaceOfBirthArabic"] = txtPlaceOfBirthArabic.Text;
                newItem["Sex"] = txtSex.Text;
                newItem["MaritalStatus"] = txtMaritalStatus.Text;
                newItem["QualifLvlDescArabic"] = txtQualificationLevelDescriptionArabic.Text;

                newItem["DegreeDescriptionArabic"] = txtDegreeDescriptionArabic.Text;
                newItem["MobilePhoneNumber"] = txtMobilePhoneNumber.Text;
                newItem["ResidentPhoneNumber"] = txtResidentPhoneNumber.Text;
                newItem["POBox"] = txtPOBox.Text;
                newItem["Email"] = txtEmail.Text;
                newItem["LandPhoneNo"] = txtLandPhoneNo.Text;

                newItem["PassportNumber"] = txtPassportNumber.Text;

                if (!String.IsNullOrEmpty(txtPassportIssueDate.Text))
                    newItem["PassportIssueDate"] = DateTime.Parse(txtPassportIssueDate.Text, new CultureInfo("en-GB"));

                if (!String.IsNullOrEmpty(txtPassportExpiryDate.Text))
                    newItem["PassportExpiryDate"] = DateTime.Parse(txtPassportExpiryDate.Text, new CultureInfo("en-GB"));

                newItem["PassportCountryDescriptionArabic"] = txtPassportCountryDescriptionArabic.Text;
                newItem["Occupation"] = txtOccupation.Text;
                newItem["CompanyNameArabic"] = txtCompanyNameArabic.Text;
                newItem["EmirateDescriptionArabic"] = txtEmirateDescriptionArabic.Text;
                newItem["CityDescriptionArabic"] = txtCityDescriptionArabic.Text;
                newItem["ResidencyType"] = txtResidencyType.Text;
                newItem["ResidencyNumber"] = txtResidencyNumber.Text;

                if (!String.IsNullOrEmpty(txtResidencyExpiryDate.Text))
                    newItem["ResidencyExpiryDate"] = DateTime.Parse(txtResidencyExpiryDate.Text, new CultureInfo("en-GB"));

                newItem.Update();
                context.Load(newItem);//Load the new item
                context.Credentials = new NetworkCredential(ConfigFileData.UserName, ConfigFileData.Password);
                context.ExecuteQuery();

                if (newItem.Id > 0)
                {
                    txtStatus.BackColor = Color.LightGreen;
                    string newItemLink = ConfigFileData.DispForm + newItem.Id.ToString();
                    string newItemSuccessMessage = "تم إنشاء سجل جديد بنجاح. اضغط الرابط التالى للمعاينة : ";
                    txtStatus.Text = newItemSuccessMessage + "\n" + newItemLink;

                    OpenSelectedRequestLink_InBrowser(newItem.Id.ToString());
                }
                else
                {
                    txtStatus.BackColor = Color.LightCoral;
                    txtStatus.Text = "خطأ : حدث خطأ اثناء محاولة إضافة سجل جديد. ";
                }
            }
            catch (NetworkInformationException)
            {
                txtStatus.BackColor = Color.LightCoral;
                txtStatus.Text = "خطأ : تعذر الإتصال بقاعدة البيانات. برجاء التأكد من حالة شبكة الإتصال";
            }
            catch (WebException)
            {
                txtStatus.BackColor = Color.LightCoral;
                txtStatus.Text = "خطأ : تعذر الإتصال بقاعدة البيانات. برجاء التأكد من حالة شبكة الإتصال";
            }
            catch (Exception ex)
            {
                txtStatus.BackColor = Color.LightCoral;
                txtStatus.Text = ex.Message;
            }
        }

        private bool get_CheckIfUserExisting_value()
        {
            if (ConfigFileData.CheckIfUserExisting.ToLower() == "false")
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void OpenSelectedRequestLink_InBrowser(string newItemID)
        {
            ComboboxItem cboItem = (ComboboxItem)cboRequestTypes.SelectedItem;

            if (cboItem.Value.ToString() == "1")
            {
                System.Diagnostics.Process.Start(ConfigFileData.NewAidRequestForm + "?cid=" + newItemID);
            }
            else if (cboItem.Value.ToString() == "2")
            {
                System.Diagnostics.Process.Start(ConfigFileData.NewHajjRequestForm + "?cid=" + newItemID);
            }
        }

        private void txtStatus_LinkClicked(object sender, LinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(e.LinkText);
        }
    }
}