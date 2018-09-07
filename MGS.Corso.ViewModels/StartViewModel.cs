using System;
using System.ComponentModel;
using System.Threading;
using System.Threading.Tasks;

namespace MGS.Corso.ViewModels
{
    // Gestisce il form di login
    public class StartViewModel : ViewModelBase
    {
        Timer timer;

        private string _username;
        public string Username
        {
            get { return _username; }
            set
            {
                _username = value;
                this.Notify("Username");
            }
        }

        private string _password;
        public string Password
        {
            get { return _password; }
            set
            {
                _password = value;
                this.Notify("Password");
            }
        }

        private DateTime _timestamp;
        public DateTime Timestamp
        {
            get { return _timestamp; }
            set { _timestamp = value;
                this.Notify(nameof(Timestamp));
            }
        }

        private int _counter;
        public int Counter
        {
            get { return _counter; }
            set { _counter = value;
                this.Notify(nameof(Counter));
                this.Notify(nameof(IsCritical));
            }
        }

        public bool IsCritical
        {
            get
            {
                return this.Counter > 500;
            }
        }

        public int LoginFailedCount { get; set; }

        public bool? Remember { get; set; }

        public StartViewModel()
        {
            this.Timestamp = DateTime.Now;
            this.Username = "emmegisoft";
            this.Password = "igor";
            this.Remember = true;

            timer = new Timer(updateTimestamp, null, 0, 2);
        }

        private void updateTimestamp(object obj)
        {
            this.Timestamp = DateTime.Now;

            if (Counter == 1000) Counter = 0;

            this.Counter++;
        }

        public void CheckCredentials()
        {
            this.IsBusy = true;

            if (this.Username != "emmegisoft" && this.Password != "carpi")
            {
                // Login fallito
                this.Message = "Login fallito!";
                this.LoginFailedCount++;
            }
            else
            {
                // OK
                this.Message = "Login riuscito!";
            }

            this.IsBusy = false;
        }
    }
}