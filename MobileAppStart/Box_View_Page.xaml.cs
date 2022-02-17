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
    public partial class Box_View_Page : ContentPage
    {

        BoxView box;
        Label lb;
        public Box_View_Page()
        {
            int r = 0, g = 0, b = 0;
            box = new BoxView
            {

                Color=Color.FromRgb(r,g,b),
                CornerRadius=200,
                WidthRequest=300, HeightRequest=300,
                HorizontalOptions =LayoutOptions.Center,
                VerticalOptions=LayoutOptions.CenterAndExpand
            };

            lb = new Label
            {
                Text = "0",
                TextColor = Color.Black,
                HorizontalOptions=LayoutOptions.Center,
                VerticalOptions=LayoutOptions.Center,
                FontSize = 20
            };

            TapGestureRecognizer tap = new TapGestureRecognizer();
            tap.Tapped += Tap_Tapped;
            box.GestureRecognizers.Add(tap);
            StackLayout st = new StackLayout { Children = { box, lb } };
            Content = st;
            st.BackgroundColor = Color.PeachPuff;
        }

        Random rnd;
        private void Tap_Tapped(object sender, EventArgs e)
        {
            rnd = new Random();
            box.Color = Color.FromRgb(rnd.Next(0, 255), rnd.Next(0, 255), rnd.Next(0, 255));

        }
    }
}