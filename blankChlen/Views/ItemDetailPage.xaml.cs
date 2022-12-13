using blankChlen.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace blankChlen.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}