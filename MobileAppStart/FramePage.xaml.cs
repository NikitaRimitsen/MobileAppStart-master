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
    public partial class FramePage : ContentPage
    {
        Frame fr;
        Label lbl;
        Grid gr = new Grid
        {
            RowDefinitions =
                    {
                        new RowDefinition{Height = new GridLength(2, GridUnitType.Star) },
                        new RowDefinition{Height = new GridLength(1, GridUnitType.Star) },
                        new RowDefinition{Height = new GridLength(1, GridUnitType.Star) },

                    },
            ColumnDefinitions =
                    {
                        new ColumnDefinition{Width = new GridLength(1,GridUnitType.Star) },
                        new ColumnDefinition{Width = new GridLength(3,GridUnitType.Star) },
                    },
        };
        public FramePage()
        {
            lbl = new Label
            {
                Text = "Frame shape",
                FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)),
                HorizontalTextAlignment = TextAlignment.Center
            };
            fr = new Frame
            {
                Content = gr,
                BorderColor = Color.Ivory,
                CornerRadius = 40,
                VerticalOptions = LayoutOptions.FillAndExpand
                
            };
            fr.Focus();
            gr.Children.Add(new BoxView { Color = Color.Blue }, 0, 0);
            gr.Children.Add(new BoxView { Color = Color.Yellow }, 1, 0);
            gr.Children.Add(new BoxView { Color = Color.Green }, 0, 1);
            gr.Children.Add(new BoxView { Color = Color.Beige }, 1, 1);
            gr.Children.Add(new BoxView { Color = Color.Violet }, 0, 2);
            gr.Children.Add(new BoxView { Color = Color.Red }, 1, 2); 
            StackLayout st = new StackLayout { Children = { lbl, fr } };
            Content = st;
        }
    }
}