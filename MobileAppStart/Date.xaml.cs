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
    public partial class Date : ContentPage
    {
        bool a = false;
        TimePicker t;
        Label lbl;
        DatePicker date;
        Button btn;
        public Date()
        {
            lbl = new Label { Text = "Choose a date" };
            date = new DatePicker
            {
                Format = "D",
                MinimumDate = DateTime.Now.AddDays(-7),
                MaximumDate = DateTime.Now.AddDays(7),
            };
            date.DateSelected += Date_DateSelected;
            t = new TimePicker()
            {
                Time = new TimeSpan(DateTime.Now.Hour, DateTime.Now.Minute, 0),
                
            };

            t.PropertyChanged += T_PropertyChanged;
            btn = new Button()
            {
                Text = "Set Timer, kinda"
            };
            AbsoluteLayout abs = new AbsoluteLayout 
            {
                Children = {lbl, btn, date, t},
            };
            btn.Clicked += Btn_Clicked;
            AbsoluteLayout.SetLayoutBounds(lbl, new Rectangle(0.1, 0.2, 300, 20));
            AbsoluteLayout.SetLayoutFlags(lbl, AbsoluteLayoutFlags.PositionProportional);
            AbsoluteLayout.SetLayoutBounds(btn, new Rectangle(0.1, 0.3, 300, 20));
            AbsoluteLayout.SetLayoutFlags(btn, AbsoluteLayoutFlags.PositionProportional);
            AbsoluteLayout.SetLayoutBounds(date, new Rectangle(0.1, 0.4, 300, 50));
            AbsoluteLayout.SetLayoutFlags(date, AbsoluteLayoutFlags.PositionProportional);
            AbsoluteLayout.SetLayoutBounds(t, new Rectangle(0.1, 0.6, 300, 50));
            AbsoluteLayout.SetLayoutFlags(t, AbsoluteLayoutFlags.PositionProportional);
            Content = abs;
        }

        private void Btn_Clicked(object sender, EventArgs e)
        {
            currentTime1(t.Time.ToString());
        }

        private void T_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            lbl.Text = "Time choosen: " + t.Time;
        }
        private async void currentTime1(string ti)
        {
            while (true)
            {
                if (ti == DateTime.Now.ToString("T"))
                {
                    lbl.BackgroundColor = Color.Red;
                    break;
                }
                Console.WriteLine("Working");
                await Task.Delay(1000);
            }
        }
        private void Date_DateSelected(object sender, DateChangedEventArgs e)
        {
            lbl.Text = "Date choosen: " + e.NewDate.ToString("G"); 
        }
    }
}