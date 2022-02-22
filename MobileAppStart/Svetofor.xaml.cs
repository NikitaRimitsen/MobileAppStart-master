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
    public partial class Svetofor : ContentPage
    {
        BoxView re;
        BoxView yello;
        BoxView gree;
        Button vkl;
        Button vekl;
        Label redpunane;
        Label yellokollane;
        Label greeroheline;
        int nazata = 0;
        public Svetofor()
        {

            re = new BoxView
            {

                CornerRadius = 100,
                WidthRequest = 200,
                HeightRequest = 150,
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.CenterAndExpand,
                BackgroundColor = Color.Gray,
            };

            yello = new BoxView
            {

                CornerRadius = 100,
                WidthRequest = 200,
                HeightRequest = 150,
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.CenterAndExpand,
                BackgroundColor = Color.Gray,
                

            };
            gree = new BoxView
            {

                CornerRadius = 100,
                WidthRequest = 200,
                HeightRequest = 150,
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.CenterAndExpand,
                BackgroundColor = Color.Gray,
            };
            vkl = new Button
            {
                Text = "Sisse",
                BackgroundColor = Color.Green,
                TextColor = Color.Black
            };
            vkl.Clicked += Vkl_Clicked;
            vekl = new Button
            {
                Text = "Välja",
                HorizontalOptions = LayoutOptions.End,
                BackgroundColor = Color.Red,
                TextColor = Color.Black
            };
            vekl.Clicked += Vekl_Clicked;

            redpunane = new Label()
            {
                Text = "Punane",
                TextColor = Color.Black,
                HorizontalOptions = LayoutOptions.Center
            };

            yellokollane = new Label()
            {
                Text = "Kollane",
                TextColor = Color.Black,
                HorizontalOptions = LayoutOptions.Center
            };

            greeroheline = new Label()
            {
                Text = "Roheline",
                TextColor = Color.Black,
                HorizontalOptions = LayoutOptions.Center
            };
            StackLayout texti = new StackLayout
            {
                Children = { re, redpunane, yello, yellokollane, gree, greeroheline }
            };

            FlexLayout knopki = new FlexLayout
            {
                Children = { vkl, vekl },
                JustifyContent = FlexJustify.SpaceEvenly
            };
            StackLayout st = new StackLayout
            {
                Children = { texti, knopki }
            };

            //------------Кликать на box---------------
            TapGestureRecognizer tap = new TapGestureRecognizer();
            tap.Tapped += Tap_Tapped;
            re.GestureRecognizers.Add(tap);
            yello.GestureRecognizers.Add(tap);
            gree.GestureRecognizers.Add(tap);
            //---------------------------

            Content = st;
            st.BackgroundColor = Color.PeachPuff;

        }

        private async void Vekl_Clicked(object sender, EventArgs e)
        {

            nazata = 1;

                re.BackgroundColor = Color.Gray;
                re.Opacity = 1;
                yello.BackgroundColor = Color.Gray;
                yello.Opacity = 1;
                gree.BackgroundColor = Color.Gray;
                gree.Opacity = 1;


        }

        private async void Vkl_Clicked(object sender, EventArgs e)
        {
            nazata = 0;
            if (nazata == 1)
            {

            }
            else
            {
                while (nazata != 1)
                {
                    if (nazata == 0)
                    {
                        re.BackgroundColor = Color.Red;
                        re.Opacity = 1;
                        yello.BackgroundColor = Color.Yellow;
                        yello.Opacity = .2;
                        gree.BackgroundColor = Color.Green;
                        gree.Opacity = .2;
                        await Task.Delay(3000);
                    }
                    if (nazata == 0)
                    {
                        re.BackgroundColor = Color.Red;
                        re.Opacity = .2;
                        yello.BackgroundColor = Color.Yellow;
                        yello.Opacity = 1;
                        gree.BackgroundColor = Color.Green;
                        gree.Opacity = .2;
                        await Task.Delay(1000);
                    }
                    if (nazata == 0)
                    {
                        re.BackgroundColor = Color.Red;
                        re.Opacity = .2;
                        yello.BackgroundColor = Color.Yellow;
                        yello.Opacity = .2;
                        gree.BackgroundColor = Color.Green;
                        gree.Opacity = 1;
                        await Task.Delay(3000);
                    }
                    if (nazata == 0)
                    {
                        re.BackgroundColor = Color.Red;
                        re.Opacity = .2;
                        yello.BackgroundColor = Color.Yellow;
                        yello.Opacity = 1;
                        gree.BackgroundColor = Color.Green;
                        gree.Opacity = .2;
                        await Task.Delay(1000);
                    }
                }


            }

        }
        int i = 0;
        private void Tap_Tapped(object sender, EventArgs e)
        {
            if (i == 0)
            {
                redpunane.Text = "Stop";
                yellokollane.Text = "Ootama";
                greeroheline.Text = "Minna";
                i++;
            }
            else if (i == 1)
            {
                redpunane.Text = "Punane";
                yellokollane.Text = "Kollane";
                greeroheline.Text = "Roheline";
                i = 0;
            }
        }
    }
}