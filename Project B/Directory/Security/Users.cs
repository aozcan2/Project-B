using System;
using System.ComponentModel;

namespace Project_B
{
    internal class User : INotifyPropertyChanged
    {
        private string username;
        private string password;
        private string logintime;

        public string UserName
        {
            get { return this.username; }
            set
            {
                if (this.username != value)
                {
                    this.username = value;
                    this.NotifyPropertyChanged("UserName");
                }
            }

        }

        public string Password
        {
            get { return this.password; }
            set
            {
                if (this.password != value)
                {
                    this.password = value;
                    this.NotifyPropertyChanged("Password");
                }
            }

        }

        public string LoginTime
        {
            get { return this.logintime; }
            set
            {
                if (this.logintime != value)
                {
                    this.logintime = value;
                    this.NotifyPropertyChanged("LoginTime");
                }
            }

        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void NotifyPropertyChanged(string v)
        {
            if (this.PropertyChanged != null) {
                this.PropertyChanged(this, new PropertyChangedEventArgs(v));
            }
        }
    }
}