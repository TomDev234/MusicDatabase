using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Web.WebView2.Core;
using Microsoft.Web.WebView2.WinForms;


namespace MusicDatabase
{
    internal class VideoPlayer
    {
        public WebView2 webView;
        public string videoURL;
        private async Task initialized()
        {
           await webView.EnsureCoreWebView2Async(null);
        }
        public async void InitiateBrowser()
        {
            await initialized();
            webView.CoreWebView2.Navigate(videoURL);
        }
    }
}
