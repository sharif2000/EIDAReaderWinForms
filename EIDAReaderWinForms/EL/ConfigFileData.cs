using System.Configuration;

namespace EIDAReaderWinForms.EL
{
    public static class ConfigFileData
    {
        public static string SP_URL
        {
            get
            {
                return ConfigurationManager.AppSettings["SP_URL"];
            }
        }

        public static string ListName
        {
            get
            {
                return ConfigurationManager.AppSettings["ListName"];
            }
        }

        public static string ImageLibraryName
        {
            get
            {
                return ConfigurationManager.AppSettings["ImageLibraryName"];
            }
        }

        public static string DispForm
        {
            get
            {
                return ConfigurationManager.AppSettings["DispForm"];
            }
        }
    }
}