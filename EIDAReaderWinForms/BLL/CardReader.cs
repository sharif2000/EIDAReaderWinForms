using EmiratesId.AE;
using EmiratesId.AE.PublicData;
using EmiratesId.AE.ReadersMgt;
using EmiratesId.AE.Utils;
using System;
using System.Drawing;

namespace EIDAReaderWinForms.BLL
{
    public static class CardReader
    {
        public static CardHolderPublicDataEx Read_V2_Card()
        {
            #region Steps 1-5

            ReaderManagement readerMgr = new ReaderManagement();
            readerMgr.EstablishContext();

            readerMgr.DiscoverReaders();
            PCSCReader[] readers = readerMgr.Readers;
            PCSCReader selectedReader = readers[0];
            bool IsConnected = selectedReader.IsConnected();
            bool isUAE = ATRSetting.Is_UAE_Card(selectedReader.ATR);

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

            PublicDataFacade publicDataFacade = selectedReader.GetPublicDataFacade();
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

            CardHolderPublicDataEx result = publicDataFacade.ReadPublicDataEx(true, true, true, true, false, true, true, true);

            #endregion Step 9

            readerMgr.CloseContext();

            return result;
        }
    }
}