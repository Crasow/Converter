using blankChlen.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration.iOSSpecific;
using Xamarin.Forms.Xaml;

namespace blankChlen.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ConverterPage : ContentPage
    {
        public ConverterPage()
        {
            InitializeComponent();
            this.BindingContext = new ConverterViewModel();
        }

        Label header;
        //Xamarin.Forms.Picker picker;

        public void Main()
        {
            header = new Label
            {
                Text = "Выберите язык",
                FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label))
            };

            //Xamarin.Forms.Picker picker = new Xamarin.Forms.Picker
            picker.Items.Add("Ярд");
            picker.Items.Add("КилоЯрд");
            picker.Items.Add("Футы");
            picker.Items.Add("М");
            picker.Items.Add("Км");


            //this.Content = new StackLayout { Children = { header, picker } };
        }

        private void Picker_SelectedIndexChanged(object sender, EventArgs e)
        {
            Debug.Text = "Вы выбрали: " + picker.Items[picker.SelectedIndex];
        }
    }
}