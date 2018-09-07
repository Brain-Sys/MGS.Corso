using System;
using System.Collections.Generic;
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
using System.Windows.Shapes;

namespace MGS.Corso.WindowsApp
{
    /// <summary>
    /// Interaction logic for LoginWindow.xaml
    /// </summary>
    public partial class LoginWindow : Window
    {
        public LoginWindow()
        {
            InitializeComponent();
            this.WindowStartupLocation = WindowStartupLocation.CenterScreen;
            int id = Thread.CurrentThread.ManagedThreadId;
        }

        private async void btnDemoTask_Click(object sender, RoutedEventArgs e)
        {
            //WebClient client = new WebClient();
            //client.DownloadStringCompleted += Client_DownloadStringCompleted;
            //client.DownloadStringAsync(new Uri("http://www.google.com"));

            var start = DateTime.Now.Minute;

            await Task.Run(() =>
            {
                while (DateTime.Now.Minute == start)
                {
                    System.Diagnostics.Debug.WriteLine(DateTime.Now.Ticks);
                }
            });

            //Task t = new Task(() => {
            //    while (DateTime.Now.Minute == start)
            //    {
            //        System.Diagnostics.Debug.WriteLine(DateTime.Now.Ticks);
            //    }
            //});

            // Alla fine...
            MessageBox.Show("Ho Finito!!!");
        }
    }
}
