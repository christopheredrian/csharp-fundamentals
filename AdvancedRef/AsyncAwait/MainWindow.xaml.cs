using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace AsyncAwait
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private async void Button_Click(object sender, RoutedEventArgs e)
        {
            Console.WriteLine("Downloading");
            var urlFromInside = await DownloadHtmlAsync("https://www.wikipedia.org");
            InfoLabel.Content = $"Downloaded from {urlFromInside}";

        }

        public async Task<string> DownloadHtmlAsync(string url)
        {
            await Task.Delay(3000);
            var webClient = new WebClient();
            var html = await webClient.DownloadStringTaskAsync(url);

            using (var streamWriter = new StreamWriter(@"c:\temp\result.html"))
            {
                await streamWriter.WriteAsync(html);
            }

            InfoLabel.Content = "Downloaded...";
            return url;
        }
        public void DownloadHtml(string url) 
        {
            Thread.Sleep(3000);
            var webClient = new WebClient();
            var html = webClient.DownloadString(url);

            using (var streamWriter = new StreamWriter(@"c:\temp\result.html"))
            {
                streamWriter.Write(html);
            }

        }
    }
}
