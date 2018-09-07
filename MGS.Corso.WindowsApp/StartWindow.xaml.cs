using MGS.Corso.ViewModels;
using System;
using System.Threading;
using System.Windows;

namespace MGS.Corso.WindowsApp
{
    public partial class StartWindow : Window
    {
        public StartWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var vm = this.Resources["viewmodel"] as StartViewModel;
            vm.CheckCredentials();
        }
    }
}