﻿using EIDAReaderWinForms.EL;
using EmiratesId.AE.PublicData;
using EmiratesId.AE.Utils;
using Microsoft.SharePoint.Client;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace EIDAReaderWinForms
{
    public partial class MainForm : System.Windows.Forms.Form
    {
        CardHolderPublicDataEx publicDataEx;

        public MainForm()
        {
            InitializeComponent();
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
            try
            {
                // Starting with ClientContext, the constructor requires a URL to the server running SharePoint.
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

                newItem["Photography"] = ConfigFileData.SP_URL + "/" + "TestForClientsImages" + "/" + uploadedImage.Name;

                newItem["NationalityAr"] = txtNationalityAr.Text;

                if (!String.IsNullOrEmpty(txtIssueDate.Text))
                    newItem["IssueDate"] = DateTime.Parse(txtIssueDate.Text);

                if (!String.IsNullOrEmpty(txtExpiryDate.Text))
                    newItem["ExpiryDate"] = DateTime.Parse(txtExpiryDate.Text);

                if (!String.IsNullOrEmpty(txtDateOfBirth.Text))
                    newItem["DateOfBirth"] = DateTime.Parse(txtDateOfBirth.Text);

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
                    newItem["PassportIssueDate"] = DateTime.Parse(txtPassportIssueDate.Text);

                if (!String.IsNullOrEmpty(txtPassportExpiryDate.Text))
                    newItem["PassportExpiryDate"] = DateTime.Parse(txtPassportExpiryDate.Text);

                newItem["PassportCountryDescriptionArabic"] = txtPassportCountryDescriptionArabic.Text;
                newItem["Occupation"] = txtOccupation.Text;
                newItem["CompanyNameArabic"] = txtCompanyNameArabic.Text;
                newItem["EmirateDescriptionArabic"] = txtEmirateDescriptionArabic.Text;
                newItem["CityDescriptionArabic"] = txtCityDescriptionArabic.Text;
                newItem["ResidencyType"] = txtResidencyType.Text;
                newItem["ResidencyNumber"] = txtResidencyNumber.Text;

                if (!String.IsNullOrEmpty(txtResidencyExpiryDate.Text))
                    newItem["ResidencyExpiryDate"] = DateTime.Parse(txtResidencyExpiryDate.Text);

                newItem.Update();
                context.Load(newItem);//Load the new item
                context.ExecuteQuery();

                txtStatus.Text = ConfigFileData.DispForm + newItem.Id.ToString();
            }
            catch (Exception ex)
            {
                txtStatus.BackColor = Color.LightCoral;
                txtStatus.Text = ex.Message;
            }
        }

        private void txtStatus_LinkClicked(object sender, LinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(e.LinkText);
        }
    }
}