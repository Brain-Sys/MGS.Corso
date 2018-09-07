using System;
using System.ComponentModel;
using System.Threading.Tasks;

namespace MGS.Corso.ViewModels
{
    // Gestisce il form di login
    public class StartViewModel : ViewModelBase
    {
        private string _username;
        public string Username
        {
            get { return _username; }
            set { _username = value;
                this.Notify("Username");
            }
        }

        private string _password;
        public string Password
        {
            get { return _password; }
            set { _password = value;
                this.Notify("Password");
            }
        }

        private bool _isBusy;
        public bool IsBusy
        {
            get { return _isBusy; }
            set { _isBusy = value;
                this.Notify(nameof(IsBusy));
            }
        }

        public bool? Remember { get; set; }

        public StartViewModel()
        {
            this.Username = "emmegisoft";
            this.Password = "igor";
            this.Remember = true;
        }

        public async void CheckCredentials()
        {
            this.IsBusy = true;

            await Task.Delay(5000);

            this.IsBusy = false;
        }
    }
}