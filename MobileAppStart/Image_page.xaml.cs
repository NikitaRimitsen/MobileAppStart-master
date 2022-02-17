using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MobileAppStart
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Image_page : ContentPage
    {
        Image img;
        public Image_page()
        {
            img = new Image { Source = "images.jpg" };
            Switch ns = new Switch 
            {
                IsToggled = true,
                VerticalOptions = LayoutOptions.EndAndExpand,
                HorizontalOptions = LayoutOptions.Center
            };
            ns.Toggled += Ns_Toggled;
            StackLayout st = new StackLayout
            {
                Children = { img, ns },
            };
            Content = st;
            
        }

        private void Ns_Toggled(object sender, ToggledEventArgs e)
        {
            img.IsVisible = !(img.IsVisible); //e.value works, ns.IsToggled
        }
    }
}