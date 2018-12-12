using Prism.Navigation;
using System.Windows.Input;
using Xamarin.Forms;
using OAuth2.Services;

namespace OAuth2.ViewModels
{
    public class RegisterViewModel :ViewModelBase
    {
        ApiServices _apiServices = new ApiServices();

        public RegisterViewModel(INavigationService navigationService) : base(navigationService)
        {
            Title = "Registrar";
        }

        public string Email { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }

        public string Message { get; set; }

        public ICommand RegisterCommand
        {
            get
            {
                return new Command(async () =>
                {
                    var isSuccess = await _apiServices.RegisterAsync(
                        Email, Password, ConfirmPassword);
                    if (isSuccess)
                        Message = "Registrado com Sucesso";
                    else
                        Message = "Tente mais tarde";


                });
            }
        }
    }
}
