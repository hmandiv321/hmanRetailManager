using Caliburn.Micro;
using System;

namespace HRMDesktopUI.ViewModels
{
    public class LoginViewModel :   Screen
    {
        private string _UserName;
        private string _Password;

        public string UserName
        {
            get { return _UserName; }
            set 
            { 
                _UserName = value;
                NotifyOfPropertyChange(() => UserName);
                NotifyOfPropertyChange(() => CanLogIn);
            }
        }

        public string Password
        {
            get { return _Password; }
            set 
            {
                _Password = value;
                NotifyOfPropertyChange(() => Password);
                NotifyOfPropertyChange(() => CanLogIn);
            }
        }

        public bool CanLogIn
        {
            get
            {
                bool output = false;

                if (UserName?.Length > 0 && Password?.Length > 0)
                {
                    output = true;
                }
                return output;
            }
        }

        public void LogIn()
        {
            Console.WriteLine(UserName, Password);   
        }
        
    }
}
