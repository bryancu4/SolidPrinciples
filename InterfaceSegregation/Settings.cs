using System;

namespace InterfaceSegregation
{
    public class Settings : IConfigurationSettings
    {
        public string ApplicationName
        {
            get { return "TEST APP NAME"; }
        }

        public string AuthorName
        {
            get { return "TEST AUTHOR NAME"; }
        }

        #region Not Implemented
        public int CacheDuration
        {
            get { throw new NotImplementedException(); }
        }

        public string DatabaseServerName
        {
            get { throw new NotImplementedException(); }
        }

        public string DatabaseName
        {
            get { throw new NotImplementedException(); }
        }

        public string DatabaseUserName
        {
            get { throw new NotImplementedException(); }
        }

        public string DatabasePassword
        {
            get { throw new NotImplementedException(); }
        }

        public string WebServiceBaseUri
        {
            get { throw new NotImplementedException(); }
        }

        #endregion
    }
}