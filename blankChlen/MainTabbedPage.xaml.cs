using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace blankChlen
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainTabbedPage : TabbedPage
    {
        public MainTabbedPage()
        {
            InitializeComponent();

        }

        private void ChatPage_Focused(object sender, FocusEventArgs e)
        {
            
        }

        private void CallPage_Focused(object sender, FocusEventArgs e)
        {
            this.Title = "Звонки";

        }

        private void CallPage_Focused_1(object sender, FocusEventArgs e)
        {
            this.Title = "Карта";

        }

        private void ConverterPage_Focused(object sender, FocusEventArgs e)
        {
            Tabber.Title = "Конвертер";
        }
    }
}