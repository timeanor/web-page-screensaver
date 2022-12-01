using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.Win32;
using System.Diagnostics;
using HtmlAgilityPack;
using System.Text.RegularExpressions;

namespace pl.polidea.lab.Web_Page_Screensaver
{
    public partial class ScreensaverForm : Form
    {
        private DateTime StartTime;
        private Timer timer;
        private int currentSiteIndex = -1;
        private GlobalUserEventHandler userEventHandler;
        private bool shuffleOrder;
        private List<string> urls;

        private PreferencesManager prefsManager = new PreferencesManager();

        private int screenNum;
        private int complete;

        private bool startup_Complete = false;
        private bool max_slideCount_found = false;        
        private bool end_slide_Navigated = false;
        private int max_slide_count = 0;
       
        private string firstURI ;
        private string endURI = null;
        

        [ThreadStatic]
        private static Random random;

        public ScreensaverForm(int? screenNumber = null)
        {
            userEventHandler = new GlobalUserEventHandler();
            userEventHandler.Event += new GlobalUserEventHandler.UserEvent(HandleUserActivity);

            if (screenNumber == null) screenNum = prefsManager.EffectiveScreensList.FindIndex(s => s.IsPrimary);
            else screenNum = (int)screenNumber;

            InitializeComponent();

            Cursor.Hide();
        }

        public List<string> Urls
        {
            get
            {
                if (urls == null)
                {
                    urls = prefsManager.GetUrlsByScreen(screenNum);
                }

                return urls;
            }
        }

        private void ScreensaverForm_Load(object sender, EventArgs e)
        {
            if (Urls.Any())
            {
                if (Urls.Count > 1)
                {
                    // Shuffle the URLs if necessary
                    shuffleOrder = prefsManager.GetRandomizeFlagByScreen(screenNum);
                    if (shuffleOrder)
                    {
                        random = new Random();

                        int n = urls.Count;
                        while (n > 1)
                        {
                            n--;
                            int k = random.Next(n + 1);
                            var value = urls[k];
                            urls[k] = urls[n];
                            urls[n] = value;
                        }
                    }

                    // Set up timer to rotate to the next URL
                    timer = new Timer();
                    timer.Interval = prefsManager.GetRotationIntervalByScreen(screenNum) * 1000;
                    timer.Tick += (s, ee) => RotateSite();
                    timer.Start();
                }

                // Display the first site in the list
                RotateSite();

                StartTime = DateTime.Now;
            }
            else
            {
                webBrowser.Visible = false;
            }
        }

        private void BrowseTo(string url)
        {
            // Disable the user event handler while navigating
            Application.RemoveMessageFilter(userEventHandler);

            if (string.IsNullOrWhiteSpace(url))
            {
                webBrowser.Visible = false;
            }
            else
            {
                webBrowser.Visible = true;
                try
                {
                    max_slideCount_found = false;
                    Debug.WriteLine($"Navigating: {url}");
                    webBrowser.Navigate(url);
                    firstURI = url;
                }
                catch
                {
                    // This can happen if IE pops up a window that isn't closed before the next call to Navigate()
                }
            }
            Application.AddMessageFilter(userEventHandler);
        }

        private void RotateSite()
        {
            currentSiteIndex++;

            if (currentSiteIndex >= Urls.Count)
            {
                currentSiteIndex = 0;
            }

            var url = Urls[currentSiteIndex];

            BrowseTo(url);
        }

        private void HandleUserActivity()
        {
            if (StartTime.AddSeconds(1) > DateTime.Now) return;

            if (prefsManager.CloseOnActivity)
            {
                Close();
            }
            else
            {
                closeButton.Visible = true;
                Cursor.Show();
            }
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void leftArrow_Click(object sender, EventArgs e)
        {
            webBrowser.Focus();
            SendKeys.Send("{LEFT}");
        }

        private void rightArrow_Click(object sender, EventArgs e)
        {
            webBrowser.Focus();
            SendKeys.Send("{RIGHT}");
        }

        private void button_minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }   


        /// <summary>
        ///   
        ///   handler method is used to find total slide count, which we can't scrape until the DOM has fully rendered the page
        ///   the handler is disabled on first invoke while the browser it told to go to the end url. 
        ///   end url is saved to variable and the method is enabled again before re-navigating the browser to the end page
        ///   
        /// This is all so that on start, this screensaver app can have the slideshow start on a random slide, rather than at the beginning each time
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void webBrowser_DocumentCompleted(object sender, EventArgs e)
        {
            var justLoaded = this.webBrowser.Url.ToString();
            this.label1.Text = justLoaded;
            Console.WriteLine($"URI Completed: {justLoaded}");

            if (!end_slide_Navigated)
            {

                slideShow_NavigateEnd();         

                System.Threading.Thread.Sleep(5000);

                endURI = this.webBrowser.Url.ToString();       
                
                end_slide_Navigated = true;

            } else if (max_slide_count == 0)
            {

                max_slide_count = resolve_SlideNumber(this.webBrowser.Document.Body.OuterHtml);              
               
                BrowseTo(firstURI);

            } else if (!startup_Complete)
            {
                navigate_to_RandomSlide();
                this.webBrowser.DocumentCompleted -= webBrowser_DocumentCompleted;  // we dont need this to run until restart
                startup_Complete = true;
            }
        }

        private void slideShow_NavigateEnd()
        {
            this.webBrowser.Focus();
            SendKeys.Send("{END}");
        }

        private int resolve_SlideNumber (string OuterHTML)
        {
            var pattern = @"aria-posinset=.([\d]+).";

            RegexOptions options = RegexOptions.Multiline;

            var matches = Regex.Matches(OuterHTML, pattern, options);

            return int.Parse(matches[0].Groups[1].Value);
        }

        private void navigate_to_RandomSlide()
        {

            var rnd = new Random();

            navigate_to_SlideNumber( rnd.Next(1, max_slide_count) );

        }

        private void navigate_to_SlideNumber(int slideNumber)
        {
            slideNumber = Math.Min(slideNumber, max_slide_count);
            var sendkeys = slideNumber.ToString() + "{ENTER}";
            webBrowser.Focus();
            SendKeys.Send(sendkeys);
        }
    }

    public class GlobalUserEventHandler : IMessageFilter
    {
        public delegate void UserEvent();

        private const int WM_MOUSEMOVE = 0x0200;
        private const int WM_MBUTTONDBLCLK = 0x209;
        private const int WM_KEYDOWN = 0x100;
        private const int WM_KEYUP = 0x101;

        // screensavers and especially multi-window apps can get spurrious WM_MOUSEMOVE events
        // that don't actually involve any movement (cursor chnages and some mouse driver software
        // can generate them, for example) - so we record the actual mouse position and compare against it for actual movement.
        private Point? lastMousePos;

        public event UserEvent Event;

        public bool PreFilterMessage(ref Message m)
        {
            if ((m.Msg == WM_MOUSEMOVE) && (this.lastMousePos == null))
            {
                this.lastMousePos = Cursor.Position;
            }

            if (((m.Msg == WM_MOUSEMOVE) && (Cursor.Position != this.lastMousePos))
                || (m.Msg > WM_MOUSEMOVE && m.Msg <= WM_MBUTTONDBLCLK) || m.Msg == WM_KEYDOWN || m.Msg == WM_KEYUP)
            {

                if (Event != null)
                {
                    Event();
                }
            }
            // Always allow message to continue to the next filter control
            return false;
        }
    }
}