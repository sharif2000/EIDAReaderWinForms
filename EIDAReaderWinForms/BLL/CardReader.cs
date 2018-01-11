using EmiratesId.AE;
using EmiratesId.AE.PublicData;
using EmiratesId.AE.ReadersMgt;

namespace EIDAReaderWinForms.BLL
{
    public class CardReader
    {
        ReaderManagement readerMgr;
        PCSCReader selectedReader;
        bool IsConnected;
        bool isUAE;
        CardInfo cardInfo;
        int cardVersion;
        PublicDataFacade publicDataFacade;
        CardHolderPublicDataEx result;

        public CardHolderPublicDataEx ReadCard()
        {
            readerMgr = new ReaderManagement();
            readerMgr.EstablishContext();
            readerMgr.DiscoverReaders();
            selectedReader = readerMgr.Readers[0];

            //if (readerMgr.Readers.Length>0)
            //{
            //    selectedReader = readerMgr.Readers[0];
            //}
            //else
            //{
            //    throw new System.Exception("خطأ : لا يوجد جهاز قارئ للبطاقة");
            //}

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
            result = publicDataFacade.ReadPublicDataEx(true, true, true, true, false, true, true, true);

            readerMgr.CloseContext();
            return result;
        }
    }
}