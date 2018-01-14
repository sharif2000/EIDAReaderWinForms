using EmiratesId.AE;
using EmiratesId.AE.PublicData;
using EmiratesId.AE.ReadersMgt;

namespace EIDAReaderWinForms.BLL
{
    public class CardReader
    {
        private ReaderManagement readerMgr;
        private PCSCReader selectedReader;
        private bool IsConnected;
        private bool isUAE;
        private CardInfo cardInfo;
        private int cardVersion;
        private PublicDataFacade publicDataFacade;
        private CardHolderPublicDataEx result;

        public CardHolderPublicDataEx ReadCard()
        {
            readerMgr = new ReaderManagement();
            readerMgr.EstablishContext();
            readerMgr.DiscoverReaders();
            selectedReader = readerMgr.Readers[0];
            IsConnected = selectedReader.IsConnected();
            isUAE = ATRSetting.Is_UAE_Card(selectedReader.ATR);
            publicDataFacade = selectedReader.GetPublicDataFacade();

            // Step 6 : In order to use EIDA "secure messaging" in "local mode", the function
            // "IDCardWrapper.LoadConfiguration" shall be called to load the "secure messaging modules configurations"
            // from the sm.cfg file "C:\Program Files\EIDA Toolkit\Libs\sm.cfg"
            // Sample configuration of is described in appendix A.
            IDCardWrapper.LoadConfiguration();

            /* Step 7 : Once PCSCReader object is acquired in a CONNECTED state and with right type,
                    application can extract the EIDA ID Card related information such as Card Serial Number, and Chip Serial Number.
                    The retrieved information will be in binary format. By using the format conversion functions of the Toolkit,
                    Developers can convert data from binary format to string representation. Refer to Utils class for a sample conversion implementation. */

            cardInfo = selectedReader.GetCardInfo();
            cardVersion = cardInfo.GetCardVersion();

            if (cardVersion < 2)
            {
                throw new System.Exception("خطأ : البطاقة المستخدمة ذات إصدار قديم وغير صالحة للقراءة. برجاء تحديث البطاقة");
            }

            result = publicDataFacade.ReadPublicDataEx(true, true, true, true, false, true, false, true);

            readerMgr.CloseContext();
            return result;
        }
    }
}