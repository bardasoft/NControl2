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
                TextTest = "Login",
                RadiusTest = 100.0f,
                GradientStyle = "radial-gradient(circle at center center, rgb(143, 39, 176) 0%, rgb(143, 39, 176) 11%,rgb(128, 38, 169) 11%, rgb(128, 38, 169) 13%,rgb(113, 38, 163) 13%, rgb(113, 38, 163) 17%,rgb(98, 37, 156) 17%, rgb(98, 37, 156) 28%,rgb(83, 37, 150) 28%, rgb(83, 37, 150) 40%,rgb(68, 36, 143) 40%, rgb(68, 36, 143) 72%,rgb(53, 36, 137) 72%, rgb(53, 36, 137) 81%,rgb(38, 35, 130) 81%, rgb(38, 35, 130) 100%)",
                Command = new Command(() =>
                {
                    DisplayAlert("Test", "Testing command", "Ok");
                })
            };
        }
    }
}
