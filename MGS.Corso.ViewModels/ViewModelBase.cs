using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace MGS.Corso.ViewModels
{
    public class ViewModelBase : INotifyPropertyChanged
    {
        private bool _isBusy;
        public bool IsBusy
        {
            get { return _isBusy; }
            set
            {
                _isBusy = value;
                this.Notify(nameof(IsBusy));
            }
        }

        private string message;
        public string Message
        {
            get { return message; }
            set { message = value;
                this.Notify(nameof(Message));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void Notify(string propName)
        {
            if (this.PropertyChanged != null)
            {
                this.PropertyChanged(this, new PropertyChangedEventArgs(propName));
            }
        }
    }
}