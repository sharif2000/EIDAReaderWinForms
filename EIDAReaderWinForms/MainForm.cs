using EmiratesId.AE.Exceptions;
using EmiratesId.AE.PublicData;
using EmiratesId.AE.Utils;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace EIDAReaderWinForms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnReadCard_Click(object sender, EventArgs e)
        {
            try
            {
                CardHolderPublicData publicData = new BLL.CardReader().ReadCard();
                CardHolderPublicDataEx publicDataEx;

                if (publicData.GetType() == typeof(CardHolderPublicDataEx))
                {
                    publicDataEx = (CardHolderPublicDataEx)publicData;

                    txtArabicFullName.Text = Utils.ByteArrayToUTF8String(publicDataEx.ArabicFullName);
                    txtFullName.Text = Utils.ByteArrayToUTF8String(publicDataEx.FullName);
                    txtMotherFullNameArabic.Text= Utils.ByteArrayToUTF8String(publicDataEx.MotherFullNameArabic);


                    txtIDNumber.Text = Utils.ByteArrayToUTF8String(publicDataEx.IdNumber);
                    picPhotography.Image = (Image)new ImageConverter().ConvertFrom(publicDataEx.Photography);
                    txtNationalityAr.Text = Utils.ByteArrayToUTF8String(publicDataEx.ArabicNationality);
                    txtIssueDate.Text = Utils.ByteArrayToStringDate(publicDataEx.IssueDate);
                    txtExpiryDate.Text = Utils.ByteArrayToStringDate(publicDataEx.ExpiryDate);
                    txtDateOfBirth.Text = Utils.ByteArrayToStringDate(publicDataEx.DateOfBirth);
                    txtSex.Text = PublicDataUtils.GetSex(Utils.ByteArrayToUTF8String(publicDataEx.Sex));
                    txtMaritalStatus.Text = PublicDataUtils.GetMaritalStatus(Utils.ByteArrayToHex(publicDataEx.MaritalStatus, ""));
                    txtQualificationLevelDescriptionArabic.Text = Utils.ByteArrayToUTF8String(publicDataEx.QualificationLevelDescriptionArabic);
                    txtDegreeDescriptionArabic.Text = Utils.ByteArrayToUTF8String(publicDataEx.DegreeDescriptionArabic);

                    txtMobilePhoneNumber.Text = Utils.ByteArrayToUTF8String(publicDataEx.HomeAddress.MobilePhoneNumber);
                    txtResidentPhoneNumber.Text = Utils.ByteArrayToUTF8String(publicDataEx.HomeAddress.ResidentPhoneNumber);

                    txtPOBox.Text = Utils.ByteArrayToUTF8String(publicDataEx.HomeAddress.POBox);

                    txtEmail.Text = Utils.ByteArrayToUTF8String(publicDataEx.HomeAddress.Email);

                    txtLandPhoneNo.Text = Utils.ByteArrayToUTF8String(publicDataEx.WorkAddress.LandPhoneNo);

                }

                txtStatus.Text = "تم قراءة بيانات البطاقة بنجاح";
                txtStatus.BackColor = Color.LightGreen;
            }
            catch (MiddlewareException ex)
            {
                txtStatus.Text = ex.Message;
                txtStatus.BackColor = Color.LightCoral;
            }
        }
    }
}