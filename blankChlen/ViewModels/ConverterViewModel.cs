using blankChlen.Views;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace blankChlen.ViewModels
{
    public class ConverterViewModel : BaseViewModel
    {
        public Command LoginCommand { get; }

        public ConverterViewModel()
        {
            LoginCommand = new Command(OnLoginClicked);
        }

        private async void OnLoginClicked(object obj)
        {
            // Prefixing with `//` switches to a different navigation stack instead of pushing to the active one
            await Shell.Current.GoToAsync($"//{nameof(MainPage)}");
        }
    }
}
