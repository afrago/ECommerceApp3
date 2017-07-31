using ECommerceApp3.Services;
using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ECommerceApp3.ViewModels
{
    public class LoginViewModel
    {
        #region Attributes
        private NavigationService navigationService;
        private DialogService dialogService;
        #endregion
        #region Properties
        public string User { get; set; }
        public string Password { get; set; }
        public Boolean IsRemembered { get; set; }
        #endregion

        #region Constructor
        public LoginViewModel()
        {
            navigationService = new NavigationService();
            dialogService = new DialogService();
            IsRemembered  = true;
        }

        #endregion
        #region Commands
        public ICommand LoginCommand { get { return new RelayCommand(Login); } }

        private async void Login()
        {
            if (string.IsNullOrEmpty(User))
            {
                await dialogService.ShowMessage("Error","Debes ingresr un usuario");
                return;
            }
            if (string.IsNullOrEmpty(Password ))
            {
                await dialogService.ShowMessage("Error", "Debes ingresr una contraseña");
                return;
            }


            navigationService.SetMainPage();
        }

        #endregion


    }
}
