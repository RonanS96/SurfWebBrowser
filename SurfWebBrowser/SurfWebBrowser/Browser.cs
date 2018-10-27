using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SurfWebBrowser
{
    public partial class Browser : Form
    {
        public Browser()
        {
            InitializeComponent();
        }

        private void HomeButton_Click(object sender, EventArgs e)
        {
            webBrowser1.GoHome();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            if (webBrowser1.CanGoBack)
            {
                webBrowser1.GoBack();
            }
        }

        private void ForwardButton_Click(object sender, EventArgs e)
        {
            if (webBrowser1.CanGoForward)
            {
                webBrowser1.GoForward();
            }
        }

        private void RefreshButton_Click(object sender, EventArgs e)
        {
            webBrowser1.Refresh();
        }

        private void StopButton_Click(object sender, EventArgs e)
        {
            webBrowser1.Stop();
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            string webPage = textBox1.Text.Trim();
            webBrowser1.Navigate(webPage);
        }
    }
}
