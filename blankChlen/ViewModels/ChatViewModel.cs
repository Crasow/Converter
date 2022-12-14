using System;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace blankChlen.ViewModels
{
    public class ChatViewModel : BaseViewModel
    {
        public ChatViewModel()
        {
            Title = "Chat";
            OpenWebCommand = new Command(async () => await Browser.OpenAsync("https://aka.ms/xamarin-quickstart"));
        }

        public ICommand OpenWebCommand { get; }
    }
}