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
    public partial class SliderPage : ContentPage
    {
        Label lbl;
        Button btn;
        Stepper sp;
        Slider sl;
        public SliderPage()
        {
            lbl = new Label();
            sl = new Slider()
            {
                Minimum = 0,
                Maximum = 100,
                Value = 30,
                MinimumTrackColor = Color.Blue,
                MaximumTrackColor = Color.Violet,
                
            };
            sl.ValueChanged += Sl_ValueChanged;
            sp = new Stepper()
            {
                Minimum = 0,
                Maximum = 5,
                Value = 3,
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.EndAndExpand
            };
            sp.ValueChanged += Sp_ValueChanged;

            StackLayout st = new StackLayout()
            {
                Children = { lbl, sl, sp }
            };
            Content = st;
        }

        private void Sp_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            lbl.Text = String.Format("Chosen: {0:F1}", e.NewValue);
            lbl.FontSize = e.NewValue * 10;
        }

        private void Sl_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            lbl.Text = String.Format("Chosen: {0:F1}", e.NewValue);
            lbl.Rotation = e.NewValue;
        }
    }
}