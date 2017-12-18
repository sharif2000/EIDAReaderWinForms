using EmiratesId.AE;
using EmiratesId.AE.Exceptions;
using EmiratesId.AE.ReadersMgt;
using EmiratesId.AE.Utils;
using System;
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

                /* Step 7 : Once PCSCReader object is acquired in a CONNECTED state and with right type,
                application can extract the EIDA ID Card related information such as Card Serial Number, and Chip Serial Number.
                The retrieved information will be in binary format. By using the format conversion functions of the Toolkit, 
                Developers can convert data from binary format to string representation. Refer to Utils class for a sample conversion implementation. */

                CardInfo cardInfo = selectedReader.GetCardInfo();
                byte[] csn = cardInfo.GetCardSerialNumber();
                byte[] chipSN = cardInfo.GetChipSerialNumber();
                byte[] cplc0101 = cardInfo.GetCPLC0101();
                byte[] cplc9f7f = cardInfo.GetCPLC9F7F();
                byte[] isn = cardInfo.GetIssuerSerialNumber();
                byte[] irn = cardInfo.GetIssuerReferenceNumber();
                byte[] mocSN = cardInfo.GetMOCSerialNumber();
                byte[] mocAppState = cardInfo.GetMOCAppletState();
                byte[] mocAlgVer = cardInfo.GetMOCAlgorithmVersion();
                byte[] maxFailed = cardInfo.GetMaxFailedMatch();
                int cardVersion = cardInfo.GetCardVersion();
                String csnHex = Utils.ByteArrayToHex(csn);
                


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