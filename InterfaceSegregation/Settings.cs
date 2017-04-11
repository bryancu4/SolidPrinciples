using System;

namespace InterfaceSegregation
{
    public class Settings : IApplicationIdentitySettings
    {
        public string ApplicationName
        {
            get { return "TEST APP NAME"; }
        }

        public string AuthorName
        {
            get { return "TEST AUTHOR NAME"; }
        }
    }
}