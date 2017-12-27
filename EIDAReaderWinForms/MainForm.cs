using EmiratesId.AE;
using EmiratesId.AE.Exceptions;
using EmiratesId.AE.PublicData;
using EmiratesId.AE.ReadersMgt;
using EmiratesId.AE.Utils;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace EIDAReaderWinForms
{
    public partial class MainForm : Form
    {
        #region Global Objects

        private ReaderManagement readerMgr;
        private PCSCReader selectedReader;
        private bool IsConnected;
        private bool isUAE;
        private PublicDataFacade publicDataFacade;

        #endregion Global Objects

        private void Form1_Load(object sender, System.EventArgs e)
        {
            try
            {
                #region Steps 1-5

                readerMgr = new ReaderManagement();
                readerMgr.EstablishContext();

                selectedReader = selectReader();
                IsConnected = selectedReader.IsConnected();
                isUAE = ATRSetting.Is_UAE_Card(selectedReader.ATR);

                #endregion Steps 1-5

                #region Step 6

                /* Step 6 : In order to use EIDA "secure messaging" in "local mode", the function
                        "IDCardWrapper.LoadConfiguration" shall be called to load the "secure messaging modules configurations"
                        from the sm.cfg file "C:\Program Files\EIDA Toolkit\Libs\sm.cfg"
                        Sample configuration of is described in appendix A. */
                IDCardWrapper.LoadConfiguration();

                #endregion Step 6

                #region Step 7

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

                #endregion Step 7

                #region Step 8

                /* Step 8 : Reading the "Card Holder Public Data", using the "CardHolderPublicData" Class */

                publicDataFacade = selectedReader.GetPublicDataFacade();
                CardHolderPublicData publicData = publicDataFacade.ReadPublicData(true, true, true, true, false);
                byte[] fullNameBin = publicData.FullName;
                String fullName = Utils.ByteArrayToUTF8String(fullNameBin);
                byte[] sexBin = publicData.Sex;
                String sex = Utils.ByteArrayToUTF8String(sexBin);
                byte[] issueDateBin = publicData.IssueDate;
                String issueDate = Utils.ByteArrayToStringDate(issueDateBin);
                byte[] photography = publicData.Photography;
                Image PersonalPhoto = (Image)new ImageConverter().ConvertFrom(photography);
                // use publicData.getX as needed
                //…

                #endregion Step 8

                #region Step 9

                /* Step 9 : Reading the "Card Holder Public Data" is extended to support reading additional public data fields
                        added in V2 cards such as address, passport information, Company name, Qualification, Field of Study, etc...  */

                CardHolderPublicDataEx publicDataEx = publicDataFacade.ReadPublicDataEx(true, true, true, true, false, true, true, true);
                byte[] fullNameBinEx = publicDataEx.FullName;
                String fullNameEx = Utils.ByteArrayToUTF8String(fullNameBin);
                byte[] sexBinEx = publicDataEx.Sex;
                String sexEx = Utils.ByteArrayToUTF8String(sexBin);
                byte[] issueDateBinEx = publicDataEx.IssueDate;
                String issueDateEx = Utils.ByteArrayToStringDate(issueDateBin);
                byte[] photographyEx = publicDataEx.Photography;
                byte[] FieldofStudyEnglishBin = publicDataEx.FieldofStudyEnglish;
                String FieldofStudyEnglish = Utils.ByteArrayToUTF8String(FieldofStudyEnglishBin);
                byte[] FieldofStudyArabicBin = publicDataEx.FieldofStudyArabic;
                String FieldofStudyArabic = Utils.ByteArrayToUTF8String(FieldofStudyArabicBin);

                #endregion Step 9

                #region Step 10 "Family Book Data" (Skipped because it needs a special config in sm.cfg)

                /* Step 10 : Reading the "Family Book Data" */

                //FamilyBookDataFacade familyBookDataFacade = selectedReader.GetFamilyBookDataFacade();
                //FamilyBookData familyBookData = familyBookDataFacade.ReadFamilyBookData(false);
                //byte[] firstNameBinChild1 = familyBookData.Child1.FirstNameArabic;
                //String firstNameChild1 = Utils.ByteArrayToUTF8String(firstNameBinChild1);

                #endregion Step 10 "Family Book Data" (Skipped because it needs a special config in sm.cfg)

                #region Step 11 "Verifying Card Genuine in local mode" (Skipped because it needs a special config in sm.cfg)

                /* Step 11 : Verifying Card Genuine in local mode
                In order to invoke isCardGenuine() function in the local mode, the sm.cfg configuration file
                must be configured as specified in Appendix A, according to the availability of
                secure messaging modules (HSM, SAM or multiple SAM, or Software SAM). */

                bool isGenuine = publicDataFacade.IsCardGenuine();

                #endregion Step 11 "Verifying Card Genuine in local mode" (Skipped because it needs a special config in sm.cfg)

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

        public MainForm()
        {
            InitializeComponent();
        }

        #endregion Constructor
    }
}