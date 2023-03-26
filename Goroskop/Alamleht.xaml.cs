using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Goroskop
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Alamleht : ContentPage
    {
        Label lbl, lbl2;
        Image img;
        Switch sw;
        Button btn;
        string infoUri;
        public Alamleht(string title, string file, string description, string info)
        {
            lbl = new Label
            {
                Text = title,
                FontAttributes = FontAttributes.Bold,
                FontSize = Device.GetNamedSize(NamedSize.Title, typeof(Label)),
                TextColor = Color.YellowGreen,
                HorizontalOptions = LayoutOptions.Center
            };
            infoUri = info;
            lbl2 = new Label
            {
                Text = description,
                FontSize = Device.GetNamedSize(NamedSize.Title, typeof(Label)),
                HorizontalOptions = LayoutOptions.Center
            };
            img = new Image { Source = file };
            btn = new Button
            {
                Text = "Больше информации"
            };
            btn.Clicked += Btn_Clicked;
            Content = new StackLayout
            {
                Children = { lbl, lbl2, img, btn }
            };
        }

        private async void Btn_Clicked(object sender, EventArgs e)
        {
            await Browser.OpenAsync(infoUri);
        }
    }
}