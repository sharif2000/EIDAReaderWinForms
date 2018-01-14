using EmiratesId.AE.PublicData;
using EmiratesId.AE.Utils;
using Microsoft.SharePoint.Client;
using System;
using System.Configuration;
using System.Drawing;
using System.Windows.Forms;

namespace EIDAReaderWinForms
{
    public partial class MainForm : System.Windows.Forms.Form
    {
        public string SP_URL;
        public string ListName;
        public string DispForm;
        public CardHolderPublicDataEx publicDataEx;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            SP_URL = ConfigurationManager.AppSettings["SP_URL"];
            ListName = ConfigurationManager.AppSettings["ListName"];
            DispForm = ConfigurationManager.AppSettings["DispForm"];
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

                txtStatus.Text = "تم قراءة بيانات البطاقة بنجاح";
                txtStatus.BackColor = Color.LightGreen;
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
            // Starting with ClientContext, the constructor requires a URL to the server running SharePoint.
            ClientContext context = new ClientContext(SP_URL);

            // Assume that the web has a list named "Announcements".
            List TestForClientsList = context.Web.Lists.GetByTitle(ListName);

            // We are just creating a regular list item, so we don't need to
            // set any properties. If we wanted to create a new folder, for
            // example, we would have to set properties such as
            // UnderlyingObjectType to FileSystemObjectType.Folder.

            ListItemCreationInformation itemCreateInfo = new ListItemCreationInformation();
            ListItem newItem = TestForClientsList.AddItem(itemCreateInfo);
            newItem["ArabicFullName"] = txtArabicFullName.Text;
            newItem.Update();
            context.Load(newItem);//Load the new item
            context.ExecuteQuery();

            txtStatus.Text = DispForm + newItem.Id.ToString();
        }

        private void txtStatus_LinkClicked(object sender, LinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(e.LinkText);
        }
    }
}