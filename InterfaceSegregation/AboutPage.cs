using System.IO;

namespace InterfaceSegregation
{
    public class AboutPage
    {
        private readonly IConfigurationSettings _configurationSettings;

        public AboutPage(IConfigurationSettings configurationSettings)
        {
            _configurationSettings = configurationSettings;
        }

        public AboutPage() : this(ConfigurationSettings.Settings)
        { }

        public void Render(TextWriter writer)
        {
            writer.Write("{0} By {1}",
                _configurationSettings.ApplicationName,
                _configurationSettings.AuthorName);
        }
    }
}