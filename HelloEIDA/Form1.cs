using EmiratesId.AE.Exceptions;
using EmiratesId.AE.ReadersMgt;
using System.Windows.Forms;

namespace HelloEIDA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, System.EventArgs e)
        {
            try
            {
                ReaderManagement readerMgr = new ReaderManagement();
                readerMgr.EstablishContext();
                // ... do some ID Card operations ...
                readerMgr.CloseContext();
            }
            catch (MiddlewareException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}