using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Goroskop
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Start : ContentPage
    {
        public List<Button> buttons { get; set; }
        List<ContentPage> pages { get; set; }
        Picker pk;
        DatePicker dp;
        Image imgs;
        List<string> files;
        public Start()
        {
            StackLayout st = new StackLayout();
            buttons = new List<Button>();
            pages = new List<ContentPage>();
            files = new List<string> { "cat.jpg", "cat2.jpg", "cat3.jpg" };
            List<string> dirs = new List<string> { "Poke", "Premier", "Safari" };
            Random rnd = new Random();
            /*for (int i = 0; i < files.Count; i++)
            {
                Button b = new Button
                {
                    Text = dirs[i],
                    TabIndex = i
                };
                buttons.Add(b);
                st.Children.Add(b);
                b.Clicked += B_Clicked;

                Alamleht p = new Alamleht(dirs[i], files[i]);
                pages.Add(p);
            }*/
            dp = new DatePicker
            {
                Format = "D",
                MinimumDate = DateTime.Now.AddDays(-7),
                MaximumDate = DateTime.Now.AddDays(7),
            };
            dp.DateSelected += Dp_DateSelected;

            pk = new Picker
            {
                ItemsSource = dirs,
                Title = "Tee valik",
                TitleColor = Color.YellowGreen
            };
            pk.SelectedIndexChanged += Pk_SelectedIndexChanged;
            imgs = new Image
            {
                Source = files[0]
            };
            st.Children.Add(imgs);
            SwipeGestureRecognizer swipe = new SwipeGestureRecognizer
            {
                Direction = SwipeDirection.Left
            };
            swipe.Swiped += Swipe_Swiped;
            imgs.GestureRecognizers.Add(swipe);
            st.Children.Add(pk);
            Content = st;
        }
        private void Dp_DateSelected(object sender, DateChangedEventArgs e)
        {
            lbl.Text = "Kuupäev: " + e.NewDate.ToString("d");
        }

        int i = 0;
        private void Swipe_Swiped(object sender, SwipedEventArgs e)
        {
            if (i < files.Count - 1)
            {
                i++;
            }
            else if (i == files.Count - 1)
            {
                i = 0;
            }
            imgs.Source = files[i];

        }

        private async void Pk_SelectedIndexChanged(object sender, EventArgs e)
        {
            await Navigation.PushAsync(pages[pk.SelectedIndex]);
        }

        private async void B_Clicked(object sender, EventArgs e)
        {
            Button b = sender as Button;
            await Navigation.PushAsync(pages[b.TabIndex]);
        }
    }
}