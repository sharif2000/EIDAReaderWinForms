using EmiratesId.AE;
using EmiratesId.AE.Exceptions;
using EmiratesId.AE.ReadersMgt;
using System.Windows.Forms;

namespace HelloEIDA
{
    public partial class Form1 : Form
    {
        #region Global Objects

        private ReaderManagement readerMgr;
        private PCSCReader selectedReader;
        private bool IsConnected;
        private bool isUAE;

        #endregion Global Objects

        private void Form1_Load(object sender, System.EventArgs e)
        {
            try
            {
                readerMgr = new ReaderManagement();
                readerMgr.EstablishContext();

                selectedReader = selectReader();
                IsConnected = selectedReader.IsConnected();
                isUAE = ATRSetting.Is_UAE_Card(selectedReader.ATR);

                /* Step 6 : In order to use EIDA "secure messaging" in "local mode", the function
                "IDCardWrapper.LoadConfiguration" shall be called to load the "secure messaging modules configurations"
                from the sm.cfg file "C:\Program Files\EIDA Toolkit\Libs\sm.cfg" 
                Sample configuration of is described in appendix A. */
                IDCardWrapper.LoadConfiguration();




                readerMgr.CloseContext();
            }
            catch (MiddlewareException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        #region Helper (BlackBoxed) functions

        private PCSCReader selectReader()
        {
            readerMgr.DiscoverReaders();
            PCSCReader[] readers = readerMgr.Readers;
            return readers[0];
        }

        #endregion Helper (BlackBoxed) functions

        #region Constructor

        public Form1()
        {
            InitializeComponent();
        }

        #endregion Constructor
    }
}