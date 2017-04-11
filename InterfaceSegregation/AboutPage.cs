using System.IO;

namespace InterfaceSegregation
{
    public class AboutPage
    {
        public void Render(TextWriter writer)
        {
            var settings = ConfigurationSettings.Settings;
            writer.Write("{0} By {1}", settings.ApplicationName, settings.AuthorName);
        }
    }
}