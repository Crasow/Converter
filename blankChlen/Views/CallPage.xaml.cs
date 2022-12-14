using blankChlen.Models;
using blankChlen.ViewModels;
using blankChlen.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace blankChlen.Views
{
    public partial class CallPage : ContentPage
    {
        CallViewModel _viewModel;

        public CallPage()
        {
            InitializeComponent();

            BindingContext = _viewModel = new CallViewModel();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            _viewModel.OnAppearing();
        }
    }
}