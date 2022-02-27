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
    public partial class Blank_ttt : ContentPage
    {

        Frame pole;
        Label lbl;
        Grid kvadrat;
        Button newgame, vebor;

        public Blank_ttt()
        {

            newgame = new Button
            {
                Text = "Uus mäng",
                BackgroundColor = Color.SandyBrown,
                TextColor = Color.Black
            };

            vebor = new Button
            {
                Text = "Kes on esimene?",
                HorizontalOptions = LayoutOptions.End,
                BackgroundColor = Color.SandyBrown,
                TextColor = Color.Black
            };

            kvadrat = new Grid
            {
                RowDefinitions =
                {
                    new RowDefinition { Height = new GridLength(1, GridUnitType.Star) },
                    new RowDefinition { Height = new GridLength(1, GridUnitType.Star) },
                    new RowDefinition { Height = new GridLength(1, GridUnitType.Star) },
                },
                ColumnDefinitions =
                {
                    new ColumnDefinition{Width=new GridLength(1,GridUnitType.Star)},
                    new ColumnDefinition{Width=new GridLength(1,GridUnitType.Star)},
                    new ColumnDefinition{Width=new GridLength(1,GridUnitType.Star)}
                },
            };
            //1 - строчка
            kvadrat.Children.Add(new Image { Source = "krest.png" }, 0, 0);//(0-x,0-y)
            kvadrat.Children.Add(new Image { Source = "nolik.png" }, 1, 0);
            kvadrat.Children.Add(new Image { Source = "krest.png" }, 2, 0);
            //2 - строчка
            kvadrat.Children.Add(new BoxView { Color = Color.Red }, 0, 1);
            kvadrat.Children.Add(new BoxView { Color = Color.YellowGreen }, 1, 1);
            kvadrat.Children.Add(new BoxView { Color = Color.Orange }, 2, 1);
            //3 - строчка
            kvadrat.Children.Add(new BoxView { Color = Color.Purple }, 0, 2);
            kvadrat.Children.Add(new BoxView { Color = Color.Pink }, 1, 2);
            kvadrat.Children.Add(new BoxView { Color = Color.White }, 2, 2);

            TapGestureRecognizer tap = new TapGestureRecognizer();
            tap.Tapped += Tap_Tapped;
            kvadrat.GestureRecognizers.Add(tap);



            pole = new Frame
            {
                Content = kvadrat,
                BorderColor = Color.Black,
                BackgroundColor =  Color.White,
                VerticalOptions = LayoutOptions.FillAndExpand
            };



            FlexLayout knopka = new FlexLayout
            {
                Children = { newgame, vebor },
                JustifyContent = FlexJustify.SpaceEvenly
            };

            StackLayout st = new StackLayout
            {
                Children = {pole, knopka}
            };
            Content = st;
            st.BackgroundColor = Color.PeachPuff;
        }

        private void Tap_Tapped(object sender, EventArgs e)
        {
            var grid_click = (Grid)sender;
            kvadrat.Children.Add(new Image { Source = "nolik.png" },0,2);
        }
    }
}