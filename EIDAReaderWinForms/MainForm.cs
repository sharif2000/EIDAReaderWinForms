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
                    txtIDNumber.Text = Utils.ByteArrayToUTF8String(publicDataEx.IdNumber);
                    picPhotography.Image = (Image)new ImageConverter().ConvertFrom(publicDataEx.Photography);
                    txtNationalityAr.Text = Utils.ByteArrayToUTF8String(publicDataEx.ArabicNationality);
                    txtIssueDate.Text = Utils.ByteArrayToStringDate(publicDataEx.IssueDate);
                    txtExpiryDate.Text = Utils.ByteArrayToStringDate(publicDataEx.ExpiryDate);
                    txtDateOfBirth.Text= Utils.ByteArrayToStringDate(publicDataEx.DateOfBirth);
                    if (Utils.ByteArrayToUTF8String(publicDataEx.Sex).ToLower()=="m")
                    {
                        txtSex.Text = "ذكر";
                    }
                    else
                    {
                        txtSex.Text = "انثى";
                    }
                    
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