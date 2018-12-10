using System;
using System.Collections.Generic;
using System.Text;
using Prism.Navigation;

namespace OAuth2.ViewModels
{
    public class LoginViewModel : ViewModelBase
    {
        public LoginViewModel(INavigationService navigationService) : base(navigationService)
        {
            Title = "LoginPage";
        }
    }
}
