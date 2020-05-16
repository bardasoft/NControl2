using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace GradientButtonDemo
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            BindingContext = new
            {
                GradientStyle = "linear-gradient(37deg, rgb(32, 218, 233),rgb(40, 21, 236))",
                Command = new Command(() =>
                {
                    DisplayAlert("Test", "Testing command", "Ok");
                })
            };
        }
    }
}
