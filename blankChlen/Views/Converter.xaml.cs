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
            //picker.Items.Add("Ярд");
            //picker.Items.Add("КилоЯрд");
            //picker.Items.Add("Футы");
            //picker.Items.Add("М");
            //picker.Items.Add("Км");


            //this.Content = new StackLayout { Children = { header, picker } };
        }

        string topPickerValue;
        string botPickerValue;

        private double Get_User_Num(string userNumStr)
        {
            double result;
            try
            {
                result = Convert.ToDouble(userNumStr);
            }
            catch { result = 0; }

            return result;
        }

        private void TopEditor_TextChanged(object sender, TextChangedEventArgs e)
        {
            double userNum = Get_User_Num(TopEditor.Text);
            BotEditor.Text = "";
            switch (topPickerValue)
            {
                case "Метры":
                    switch (botPickerValue)
                    {
                        case "Метры":
                            BotEditor.Placeholder = userNum.ToString();
                            break;
                        case "Ярды":
                            BotEditor.Placeholder = (userNum* 1.0936132983377).ToString();
                            break;
                        case "Километры":
                            BotEditor.Placeholder = (userNum / 1000).ToString();
                            break;
                        case "Килоярды":
                            BotEditor.Placeholder = (userNum / 1000 * 1.0936132983377).ToString();
                            break;
                        case "Футы":
                            BotEditor.Placeholder = (userNum * 3.2808398950131).ToString();
                            break;
                    }
                    break;
                case "Километры":
                    switch (botPickerValue)
                    {
                        case "Метры":
                            BotEditor.Text = (userNum * 1000).ToString();
                            break;
                        case "Ярды":
                            BotEditor.Text = (userNum * 1.0936132983377 / 1000 ).ToString();
                            break;
                        case "Километры":
                            BotEditor.Text = (userNum ).ToString();
                            break;
                        case "Килоярды":
                            BotEditor.Text = (userNum * 1.0936132983377).ToString();
                            break;
                        case "Футы":
                            BotEditor.Text = (userNum * 3.2808398950131 * 1000).ToString();
                            break;
                    }
                    break;
                case "Ярды":
                    switch (botPickerValue)
                    {
                        case "Метры":
                            BotEditor.Text = (userNum* 0.9144).ToString();
                            break;
                        case "Ярды":
                            BotEditor.Text = (userNum).ToString();
                            break;
                        case "Километры":
                            BotEditor.Text = (userNum * 0.9144 / 1000).ToString();
                            break;
                        case "Килоярды":
                            BotEditor.Text = (userNum / 1000).ToString();
                            break;
                        case "Футы":
                            BotEditor.Text = (userNum * 3).ToString();
                            break;
                    }
                    break;
                case "Килоярды":
                    switch (botPickerValue)
                    {
                        case "Метры":
                            BotEditor.Text = (userNum * 0.9144 * 1000).ToString();
                            break;
                        case "Ярды":
                            BotEditor.Text = (userNum * 1000).ToString();
                            break;
                        case "Километры":
                            BotEditor.Text = (userNum * 0.9144).ToString();
                            break;
                        case "Килоярды":
                            BotEditor.Text = (userNum).ToString();
                            break;
                        case "Футы":
                            BotEditor.Text = (userNum * 3000).ToString();
                            break;
                    }
                    break;
                case "Футы":
                    switch (botPickerValue)
                    {
                        case "Метры":
                            BotEditor.Text = (userNum * 0.3048).ToString();
                            break;
                        case "Ярды":
                            BotEditor.Text = (userNum * 0.33333333333333).ToString();
                            break;
                        case "Километры":
                            BotEditor.Text = (userNum * 0.3048 / 1000).ToString();
                            break;
                        case "Килоярды":
                            BotEditor.Text = (userNum * 0.33333333333333 / 1000).ToString();
                            break;
                        case "Футы":
                            BotEditor.Text = (userNum).ToString();
                            break;
                    }
                    break;

            }
        }

        private void BotEditor_TextChanged(object sender, TextChangedEventArgs e)
        {
            double userNum = Get_User_Num(BotEditor.Text);
            TopEditor.Text = "";
            switch (botPickerValue)
            {
                case "Метры":
                    switch (topPickerValue)
                    {
                        case "Метры":
                            TopEditor.Text = userNum.ToString();
                            break;
                        case "Ярды":
                            TopEditor.Text = (userNum * 1.0936132983377).ToString();
                            break;
                        case "Километры":
                            TopEditor.Text = (userNum / 1000).ToString();
                            break;
                        case "Килоярды":
                            TopEditor.Text = (userNum / 1000 * 1.0936132983377).ToString();
                            break;
                        case "Футы":
                            TopEditor.Text = (userNum * 3.2808398950131).ToString();
                            break;
                    }
                    break;
                case "Километры":
                    switch (topPickerValue)
                    {
                        case "Метры":
                            TopEditor.Text = (userNum * 1000).ToString();
                            break;
                        case "Ярды":
                            TopEditor.Text = (userNum * 1.0936132983377 / 1000).ToString();
                            break;
                        case "Километры":
                            TopEditor.Text = (userNum).ToString();
                            break;
                        case "Килоярды":
                            TopEditor.Text = (userNum * 1.0936132983377).ToString();
                            break;
                        case "Футы":
                            TopEditor.Text = (userNum * 3.2808398950131 * 1000).ToString();
                            break;
                    }
                    break;
                case "Ярды":
                    switch (topPickerValue)
                    {
                        case "Метры":
                            TopEditor.Placeholder = (userNum * 0.9144).ToString();
                            break;
                        case "Ярды":
                            TopEditor.Placeholder = (userNum).ToString();
                            break;
                        case "Километры":
                            TopEditor.Placeholder = (userNum * 0.9144 / 1000).ToString();
                            break;
                        case "Килоярды":
                            TopEditor.Placeholder = (userNum / 1000).ToString();
                            break;
                        case "Футы":
                            TopEditor.Placeholder = (userNum * 3).ToString();
                            break;
                    }
                    break;
                case "Килоярды":
                    switch (topPickerValue)
                    {
                        case "Метры":
                            TopEditor.Text = (userNum * 0.9144 * 1000).ToString();
                            break;
                        case "Ярды":
                            TopEditor.Text = (userNum * 1000).ToString();
                            break;
                        case "Километры":
                            TopEditor.Text = (userNum * 0.9144).ToString();
                            break;
                        case "Килоярды":
                            TopEditor.Text = (userNum).ToString();
                            break;
                        case "Футы":
                            TopEditor.Text = (userNum * 3000).ToString();
                            break;
                    }
                    break;
                case "Футы":
                    switch (topPickerValue)
                    {
                        case "Метры":
                            TopEditor.Text = (userNum * 0.3048).ToString();
                            break;
                        case "Ярды":
                            TopEditor.Text = (userNum * 0.33333333333333).ToString();
                            break;
                        case "Километры":
                            TopEditor.Text = (userNum * 0.3048 / 1000).ToString();
                            break;
                        case "Килоярды":
                            TopEditor.Text = (userNum * 0.33333333333333 / 1000).ToString();
                            break;
                        case "Футы":
                            TopEditor.Text = (userNum).ToString();
                            break;
                    }
                    break;

            }
        }

        private void TopPicker_SelectedIndexChanged(object sender, EventArgs e)
        {
            TopDebug.Text = "Вы выбрали: " + TopPicker.Items[TopPicker.SelectedIndex];
            topPickerValue = TopPicker.Items[TopPicker.SelectedIndex];

        }

        private void BotPicker_SelectedIndexChanged(object sender, EventArgs e)
        {
            BotDebug.Text = "Вы выбрали: " + BotPicker.Items[BotPicker.SelectedIndex];
            botPickerValue = BotPicker.Items[BotPicker.SelectedIndex];
            }
        }
}