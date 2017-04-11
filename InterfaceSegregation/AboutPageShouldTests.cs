﻿using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace InterfaceSegregation
{
    [TestClass]
    public class AboutPageShouldTests
    {
        [TestMethod]
        public void DisplayApplicationName()
        {
            var aboutPage = new AboutPage(); // -- hard to TEST!  Need app.config set up just so.
            var textWriter = new StringWriter();
            aboutPage.Render(textWriter);

            var output = textWriter.ToString();

            Assert.AreEqual("Interface Segregation By Steve Smith", output);
        }
    }
}
