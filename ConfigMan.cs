using System;
using System.Configuration;

namespace pl.polidea.lab.Web_Page_Screensaver
{
    internal class ConfigMan
    {
        private string ConfigURL { get; } = ConfigurationManager.AppSettings["URL"];
        private string SlideDelayMS { get; set; } = ConfigurationManager.AppSettings["SlideAdanceDelayMS"];

        private string browserurl;
        internal string BrowserURL
        {
            get { return browserurl; }
            set { browserurl = String.Format( ConfigURL, SlideDelayMS ); }
        }

        internal int StartAtScreenNum { get; } = Convert.ToInt32(ConfigurationManager.AppSettings["effectiveScreenNum"]);

    }
}
