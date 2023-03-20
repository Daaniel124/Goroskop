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
    public partial class Alamleht : ContentPage
    {
        Label lbl;
        Image img;
        Switch sw;
        public Alamleht(string title, string file)
        {
            lbl = new Label
            {
                Text = title,
                FontAttributes = FontAttributes.Bold,
                FontSize = Device.GetNamedSize(NamedSize.Title, typeof(Label)),
                TextColor = Color.YellowGreen,
                HorizontalOptions = LayoutOptions.Center
            };
            sw = new Switch
            {
                HorizontalOptions = LayoutOptions.Center,
                IsToggled = true,
            };
            sw.Toggled += Sw_Toggled;
            img = new Image { Source = file };
            Content = new StackLayout
            {
                Children = { lbl, sw, img }
            };
        }

        private void Sw_Toggled(object sender, ToggledEventArgs e)
        {
            if (e.Value == true)
            {
                img.IsVisible = true;
            }
            else
            {
                img.IsVisible = false;
            }
        }
    }
}