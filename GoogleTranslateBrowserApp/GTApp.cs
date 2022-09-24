using System;
using CefSharp.WinForms;

namespace GoogleTranslateBrowserApp
{
    public partial class GTApp : Form
    {
        public GTApp()
        {
            InitializeComponent();
        }

        ChromiumWebBrowser browser = new ChromiumWebBrowser();

        private void GTApp_Load(object sender, EventArgs e)
        {
            MessageBox.Show("This is not an offical Google App, it was coded so that users will stop getting malware and are able to use a clean free version.", "User Warning");
            browser.Load("https://translate.google.co.uk/");
            browser.Dock = DockStyle.Fill;
            webPanel.Controls.Add(browser);
            webPanel.Dock = DockStyle.Fill;
        }

        private void reloadButton_Click(object sender, EventArgs e)
        {
            browser.Load("https://translate.google.co.uk/");
        }

        private void webPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}