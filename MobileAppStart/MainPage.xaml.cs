﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MobileAppStart
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            //InitializeComponent();
            StackLayout st = new StackLayout();
            Button b = new Button() 
            {
                Text = "Open",
                BackgroundColor = Color.SandyBrown
            };
            Button timer_b = new Button()
            {
                Text = "Time",
                BackgroundColor = Color.SandyBrown
            };
            timer_b.Clicked += timer_b_Clicked;
            Button box_b = new Button()
            {
                Text = "Clicker",
                BackgroundColor = Color.SandyBrown
            };
            box_b.Clicked += box_b_Clicked;
            Button box_date = new Button()
            {
                Text = "Date/Time",
                BackgroundColor = Color.SandyBrown
            };
            box_date.Clicked += box_date_Clicked;
            Button box_ss = new Button()
            {
                Text = "Stepper/slider",
                BackgroundColor = Color.SandyBrown
            };
            box_ss.Clicked += box_ss_Clicked;
            Button framebtn = new Button()
            {
                Text = "Frame",
                BackgroundColor = Color.SandyBrown
            };
            framebtn.Clicked += framebtn_Clicked;
            Button imgbtn = new Button()
            {
                Text = "Image",
                BackgroundColor = Color.SandyBrown
            };
            imgbtn.Clicked += imgbtn_Clicked;
            Button trafficbtn = new Button()
            {
                Text = "Traffic",
                BackgroundColor = Color.SandyBrown
            };
            trafficbtn.Clicked += trafficbtn_Clicked;
            //st = {b,timer}
            st.Children.Add(b);
            st.Children.Add(timer_b);
            st.Children.Add(box_b);
            st.Children.Add(box_date);
            st.Children.Add(box_ss);
            st.Children.Add(framebtn);
            st.Children.Add(imgbtn);
            st.Children.Add(trafficbtn);
            st.BackgroundColor = Color.Cornsilk;
            Content = st;
            b.Clicked += B_Clicked;
        }
        private async void trafficbtn_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Traffic_light());
        }
        private async void imgbtn_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Image_page());
        }

        private async void framebtn_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new FramePage());
        } 
        private async void box_ss_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new SliderPage());
        }

        private async void box_date_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Date());
        }

        private async void box_b_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Box_View_Page());
        }

        private async void timer_b_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Timer());
        }

        private async void B_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Entry_Page());
        }
    }
}
