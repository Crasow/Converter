using blankChlen.ViewModels;
using System;
using System.Collections.Generic;
using Xamarin.Forms;
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


        string topPickerValue;
        string botPickerValue;
        string isFocused;

        private double Get_User_Num(string userNumStr)
        {
            double result;
            try
            {
                result = Convert.ToDouble(userNumStr);
            }
            catch { result = -1; }

            return result;
        }


        private void TopEditor_TextChanged(object sender, TextChangedEventArgs e)
        {
            TopPickerFunc();
        }

        private void BotEditor_TextChanged(object sender, TextChangedEventArgs e)
        {
            BotPickerFunc();
        }

        private void TopPicker_SelectedIndexChanged(object sender, EventArgs e)
        {
            topPickerValue = TopPicker.Items[TopPicker.SelectedIndex];
            TopPickerFunc();
        }

        private void BotPicker_SelectedIndexChanged(object sender, EventArgs e)
        {
            botPickerValue = BotPicker.Items[BotPicker.SelectedIndex];
            BotPickerFunc();
        }

        private void TopEditor_Focused(object sender, FocusEventArgs e)
        {
            isFocused = "top";
        }

        private void BotEditor_Focused(object sender, FocusEventArgs e)
        {
            isFocused = "bot";
        }

        

        private void AddConverter_Clicked(object sender, EventArgs e)
        {
            List<string> units = new List<string>()
        { "Метры", "Километры", "Ярды", "Килоярды", "Футы" };

            StackLayout NewConvertor = new StackLayout();

            StackLayout TopPart = new StackLayout
            {
                Orientation = StackOrientation.Horizontal
            };


 
            Xamarin.Forms.Picker TopPicker = new Xamarin.Forms.Picker
            {
                Title = "Выбери величину",
                FontSize = 20,
            };

            foreach (string unit in units)
            { TopPicker.Items.Add(unit); }

            Editor TopEditor = new Editor()
            {
                AutoSize = EditorAutoSizeOption.TextChanges,
                Keyboard = Keyboard.Numeric,
                Placeholder = "Тык",
            };


            TopPart.Children.Add(TopPicker);
            TopPart.Children.Add(TopEditor);


            StackLayout BotPart = new StackLayout
            {
                Orientation = StackOrientation.Horizontal
            };

            Xamarin.Forms.Picker BotPicker = new Xamarin.Forms.Picker
            {
                Title = "Выбери величину",
                FontSize = 20,
            };

            foreach (string unit in units)
            { BotPicker.Items.Add(unit); }

            Editor BotEditor = new Editor()
            {
                AutoSize = EditorAutoSizeOption.TextChanges,
                Keyboard = Keyboard.Numeric,
                Placeholder = "Тык",
            };


            BotPart.Children.Add(BotPicker);
            BotPart.Children.Add(BotEditor);

            NewConvertor.Children.Add(TopPart);
            NewConvertor.Children.Add(BotPart);

            MainLayout.Children.Add(NewConvertor);

            TopPicker.SelectedIndexChanged += TopPicker_SelectedIndexChanged;
            TopEditor.TextChanged += TopEditor_TextChanged;
            TopEditor.Focused += TopEditor_Focused;

            BotPicker.SelectedIndexChanged += BotPicker_SelectedIndexChanged;
            BotEditor.TextChanged += BotEditor_TextChanged;
            BotEditor.Focused += BotEditor_Focused;
            

        }


        private void TopPickerFunc()
        {
            double userNum = Get_User_Num(TopEditor.Text);
            if (userNum == -1)
            {
                BotEditor.Text = "";
            }
            else if (isFocused == "top")
            {
                switch (topPickerValue)
                {
                    case "Метры":
                        switch (botPickerValue)
                        {
                            case "Метры":
                                BotEditor.Text = userNum.ToString();
                                break;
                            case "Ярды":
                                BotEditor.Text = (userNum * 1.0936132983377).ToString();
                                break;
                            case "Километры":
                                BotEditor.Text = (userNum / 1000).ToString();
                                break;
                            case "Килоярды":
                                BotEditor.Text = (userNum / 1000 * 1.0936132983377).ToString();
                                break;
                            case "Футы":
                                BotEditor.Text = (userNum * 3.2808398950131).ToString();
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
                                BotEditor.Text = (userNum * 1.0936132983377 / 1000).ToString();
                                break;
                            case "Километры":
                                BotEditor.Text = (userNum).ToString();
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
                                BotEditor.Text = (userNum * 0.9144).ToString();
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
        }



        private void BotPickerFunc()
        {
            double userNum = Get_User_Num(BotEditor.Text);
            if (userNum == -1)
            {
                TopEditor.Text = "";
            }
            else if (isFocused == "bot")
            {
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
                                TopEditor.Text = (userNum * 0.9144).ToString();
                                break;
                            case "Ярды":
                                TopEditor.Text = (userNum).ToString();
                                break;
                            case "Километры":
                                TopEditor.Text = (userNum * 0.9144 / 1000).ToString();
                                break;
                            case "Килоярды":
                                TopEditor.Text = (userNum / 1000).ToString();
                                break;
                            case "Футы":
                                TopEditor.Text = (userNum * 3).ToString();
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
        }


    }
}