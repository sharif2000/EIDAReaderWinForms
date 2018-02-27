using System.Collections.Specialized;
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

        public static NameValueCollection RequestTypes
        {
            get
            {
                return ConfigurationManager.GetSection("RequestTypes/appSettings") as NameValueCollection;
            }
        }

        public static string UserName
        {
            get
            {
                return ConfigurationManager.AppSettings["UserName"];
            }
        }

        public static string Password
        {
            get
            {
                return ConfigurationManager.AppSettings["Password"];
            }
        }

        public static string NewHajjRequestForm
        {
            get
            {
                return ConfigurationManager.AppSettings["NewHajjRequestForm"];
            }
        }

        public static string NewAidRequestForm
        {
            get
            {
                return ConfigurationManager.AppSettings["NewAidRequestForm"];
            }
        }

        public static string CheckIfUserExisting
        {
            get
            {
                return ConfigurationManager.AppSettings["CheckIfUserExisting"];
            }
        }
    }
}