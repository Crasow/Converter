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
        static public string focusedPageName;
        public MainTabbedPage()
        {
            InitializeComponent();
        }



        private void AddButton_Clicked(object sender, EventArgs e)
        {

        }


    }
}