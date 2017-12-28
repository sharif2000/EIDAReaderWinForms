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
                CardHolderPublicDataEx publicDataEx = new BLL.CardReader().Read_V2_Card();
                txtArabicFullName.Text = Utils.ByteArrayToUTF8String(publicDataEx.ArabicFullName);
                txtFullName.Text = Utils.ByteArrayToUTF8String(publicDataEx.FullName);
                byte[] issueDateBinEx = publicDataEx.IssueDate;
                String issueDateEx = Utils.ByteArrayToStringDate(issueDateBinEx);
                byte[] photographyEx = publicDataEx.Photography;
                Image PersonalPhoto = (Image)new ImageConverter().ConvertFrom(photographyEx);

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