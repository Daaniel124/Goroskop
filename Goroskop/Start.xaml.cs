using System;
using System.Collections.Generic;
using System.ComponentModel;
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
        Image img;
        List<string> files;
        List<string> description;
        List<string> info;
        public Start()
        {
            StackLayout st = new StackLayout();
            buttons = new List<Button>();
            pages = new List<ContentPage>();
            files = new List<string> {
                "https://upload.wikimedia.org/wikipedia/commons/e/e6/RR5110-0049R.gif",
                "https://upload.wikimedia.org/wikipedia/commons/7/71/RR5110-0050R.gif",
                "https://upload.wikimedia.org/wikipedia/commons/1/10/RR5110-0051R.gif",
                "https://upload.wikimedia.org/wikipedia/commons/c/cf/RR5110-0052R.gif",
                "https://upload.wikimedia.org/wikipedia/commons/f/f0/RR5110-0040R_%D0%9B%D0%B5%D0%B2.gif",
                "https://upload.wikimedia.org/wikipedia/commons/a/ac/RR5111-0115R.gif",
                "https://upload.wikimedia.org/wikipedia/commons/7/74/RR5110-0042R_%D0%92%D0%B5%D1%81%D1%8B.gif",
                "https://upload.wikimedia.org/wikipedia/commons/1/11/RR5110-0043R_%D0%A1%D0%BA%D0%BE%D1%80%D0%BF%D0%B8%D0%BE%D0%BD.gif",
                "https://upload.wikimedia.org/wikipedia/commons/b/b2/RR5111-0119R.gif",
                "https://upload.wikimedia.org/wikipedia/commons/1/1a/RR5110-0045R_%D0%9A%D0%BE%D0%B7%D0%B5%D1%80%D0%BE%D0%B3.gif",
                "https://upload.wikimedia.org/wikipedia/commons/4/44/RR5111-0122R.gif",
                "https://upload.wikimedia.org/wikipedia/commons/c/c7/RR5110-0048R.gif"
            };
            List<string> dirs = new List<string> { "Овен", "Телец", "Близнецы", "Рак", "Лев", "Дева", "Весы", "Скорпион", "Стрелец", "Козерог", "Водолей", "Рыбы" };
            description = new List<string> {
                "В 2023 году гороскоп для знака Овен рекомендует сосредоточиться на себе и своем исцелении. Вы устали от бешеного темпа жизни, от того, что нет времени на себя. Год Тигра – время, чтобы взять паузу, ведь он обещает быть богатым сюрпризами и периодом для личной трансформации.",
                "Учитесь новому, занимайтесь саморазвитием, повышайте свой профессиональный уровень. В вас может проснуться страстное желание познать такие сакральные науки, как философия, религия, эзотерика, психология. Иностранные языки тоже будут вам даваться как никогда легко.",
                "Близнецы в 2023 году будут на волне энергии, дружбы и приятельства. Любые вопросы они смогут решить с помощью связей. Представителям этого знака нужно расширять круг общения и проявлять себя в разных сферах жизни, быть на виду. Это поможет обрести единомышленников и подтолкнет вверх по карьерной лестнице.",
                "В течение года Раки будут наслаждаться богатством и поддержкой семьи. Но следует соблюдать баланс и максимально укреплять эмоциональные связи с близкими, разграничивая работу и дом. Вероятно, летом возникнут семейные споры, однако семейный гороскоп на 2023 год для знака Рак говорит, что вы их быстро преодолеете.",
                "Гороскоп на 2023 год для знака Лев говорит, что вам следует сосредоточиться на семейной жизни, расширении финансового сотрудничества и инвестиций, а также на собственном внутреннем мире. Кроме того, это год вашего карьерного роста и перемен, возможность изучить новое и усовершенствовать старые навыки.",
                "Дев ждет карьерный рост, дополнительные обязанности, большая нагрузка. Трудолюбие и надежность позволят стать ценным сотрудником и легко выполнять сложные задачи. Но важно настаивать на вознаграждении своих усилий.",
                "Гороскоп на 2023 год для знака Весы говорит, что новый год принесет положительные результаты. Появится время заняться увлечениями. Кроме того, финансовых возможностей будет достаточно: доход, повышение зарплаты, рост вашей значимости. Но вы должны уметь оптимизировать свой рабочий процесс, чтобы стать более успешным.",
                "Индивидуальность Скорпионов ярко засияет в 2023 году. Придет время показать, кто вы, что делаете, получить признание за работу и понять, кто вас поддерживает. Год Тигра – ваш год, который принесет процветание, достаток позволит выразить себя как творческую натуру.",
                "2023 год – период отдохнуть и исцелиться. Пора пройти медицинское обследование, научиться идти на компромиссы, найти четкую цель, быть терпеливым, общительным и смелым. За прошлый год вы устали решать как свои, так и чужие проблемы. Найдите наконец время для себя.",
                "В 2023 году, как говорят астрологи, следует сосредоточиться на налаживании связей, на своих творческих начинаниях и увлечениях, оставаясь открытыми для изменений, возможностей, партнерства и сотрудничества.",
                "2023 год станет важным в профессиональной сфере. По мере того, как развивается карьера, вам будут поступать новые возможности. Водолеям нужно заботиться о себе и поддерживать окружающих, остерегаться больших трат, самостоятельно управлять своими финансами и помогать нуждающимся.",
                "Для Рыб возможностей в 2023 будет предостаточно. Год направит вас к саморазвитию и путешествиям. Выучите новый язык, обретите новые навыки, откройте свой ум и отдайтесь изменениям, но не действуйте спонтанно. В центре внимания вы, ваша искренность и творческая природа."
            };
            info = new List<string>() {
                "https://ru.wikipedia.org/wiki/%D0%9E%D0%B2%D0%B5%D0%BD_(%D0%B7%D0%BD%D0%B0%D0%BA_%D0%B7%D0%BE%D0%B4%D0%B8%D0%B0%D0%BA%D0%B0)",
                "https://ru.wikipedia.org/wiki/%D0%A2%D0%B5%D0%BB%D0%B5%D1%86_(%D0%B7%D0%BD%D0%B0%D0%BA_%D0%B7%D0%BE%D0%B4%D0%B8%D0%B0%D0%BA%D0%B0)",
                "https://ru.wikipedia.org/wiki/%D0%91%D0%BB%D0%B8%D0%B7%D0%BD%D0%B5%D1%86%D1%8B_(%D0%B7%D0%BD%D0%B0%D0%BA_%D0%B7%D0%BE%D0%B4%D0%B8%D0%B0%D0%BA%D0%B0)",
                "https://ru.wikipedia.org/wiki/%D0%A0%D0%B0%D0%BA_(%D0%B7%D0%BD%D0%B0%D0%BA_%D0%B7%D0%BE%D0%B4%D0%B8%D0%B0%D0%BA%D0%B0)",
                "https://ru.wikipedia.org/wiki/%D0%9B%D0%B5%D0%B2_(%D0%B7%D0%BD%D0%B0%D0%BA_%D0%B7%D0%BE%D0%B4%D0%B8%D0%B0%D0%BA%D0%B0)",
                "https://ru.wikipedia.org/wiki/%D0%94%D0%B5%D0%B2%D0%B0_(%D0%B7%D0%BD%D0%B0%D0%BA_%D0%B7%D0%BE%D0%B4%D0%B8%D0%B0%D0%BA%D0%B0)",
                "https://ru.wikipedia.org/wiki/%D0%92%D0%B5%D1%81%D1%8B_(%D0%B7%D0%BD%D0%B0%D0%BA_%D0%B7%D0%BE%D0%B4%D0%B8%D0%B0%D0%BA%D0%B0)",
                "https://ru.wikipedia.org/wiki/%D0%A1%D0%BA%D0%BE%D1%80%D0%BF%D0%B8%D0%BE%D0%BD_(%D0%B7%D0%BD%D0%B0%D0%BA_%D0%B7%D0%BE%D0%B4%D0%B8%D0%B0%D0%BA%D0%B0)",
                "https://ru.wikipedia.org/wiki/%D0%A1%D1%82%D1%80%D0%B5%D0%BB%D0%B5%D1%86_(%D0%B7%D0%BD%D0%B0%D0%BA_%D0%B7%D0%BE%D0%B4%D0%B8%D0%B0%D0%BA%D0%B0)",
                "https://ru.wikipedia.org/wiki/%D0%9A%D0%BE%D0%B7%D0%B5%D1%80%D0%BE%D0%B3_(%D0%B7%D0%BD%D0%B0%D0%BA_%D0%B7%D0%BE%D0%B4%D0%B8%D0%B0%D0%BA%D0%B0)",
                "https://ru.wikipedia.org/wiki/%D0%92%D0%BE%D0%B4%D0%BE%D0%BB%D0%B5%D0%B9_(%D0%B7%D0%BD%D0%B0%D0%BA_%D0%B7%D0%BE%D0%B4%D0%B8%D0%B0%D0%BA%D0%B0)",
                "https://ru.wikipedia.org/wiki/%D0%A0%D1%8B%D0%B1%D1%8B_(%D0%B7%D0%BD%D0%B0%D0%BA_%D0%B7%D0%BE%D0%B4%D0%B8%D0%B0%D0%BA%D0%B0)"
            };
            for (int i = 0; i < files.Count; i++)
            {
                Alamleht p = new Alamleht(dirs[i], files[i], description[i], info[i]);
                pages.Add(p);
            }   
            dp = new DatePicker
            {
                Format = "D"
            };
            dp.DateSelected += Dp_DateSelected;

            pk = new Picker
            {
                ItemsSource = dirs,
                Title = "Выберите знак..",
                TitleColor = Color.YellowGreen
            };
            pk.SelectedIndexChanged += Pk_SelectedIndexChanged;
            img = new Image
            {
                Source = files[0]
            };
            st.Children.Add(img);
            SwipeGestureRecognizer swipe = new SwipeGestureRecognizer
            {
                Direction = SwipeDirection.Left
            };
            swipe.Swiped += Swipe_Swiped;
            img.GestureRecognizers.Add(swipe);
            st.Children.Add(dp);
            st.Children.Add(pk);
            Content = st;
        }
        private async void Dp_DateSelected(object sender, DateChangedEventArgs e)
        {
            var m = e.NewDate.Month;
            var d = e.NewDate.Day;
            
            if (m == 3 && d >= 21 && d <= 31 || m == 4 && d <= 19) // Овен
            {
                await Navigation.PushAsync(pages[0]);
            }
            if (m == 4 && d >= 20 && d <= 30 || m == 5 && d <= 20) // Телец
            {
                await Navigation.PushAsync(pages[1]);
            }
            if (m == 5 && d >= 21 && d <= 31 || m == 6 && d <= 20) // Близнецы
            {
                await Navigation.PushAsync(pages[2]);
            }
            if (m == 6 && d >= 21 && d <= 30 || m == 7 && d <= 22) // Рак
            {
                await Navigation.PushAsync(pages[3]);
            }
            if (m == 7 && d >= 23 && d <= 31 || m == 8 && d <= 22) // Лев
            {
                await Navigation.PushAsync(pages[4]);
            }
            if (m == 8 && d >= 23 && d <= 31 || m == 9 && d <= 22) // Дева
            {
                await Navigation.PushAsync(pages[5]);
            }
            if (m == 9 && d >= 23 && d <= 31 || m == 10 && d <= 22) // Весы
            {
                await Navigation.PushAsync(pages[6]);
            }
            if (m == 10 && d >= 23 && d <= 30 || m == 11 && d <= 21) // Скорпион
            {
                await Navigation.PushAsync(pages[7]);
            }
            if (m == 11 && d >= 22 && d <= 31 || m == 12 && d <= 21) // Стрелец
            {
                await Navigation.PushAsync(pages[8]);
            }
            if (m == 12 && d >= 22 && d <= 31 || m == 1 && d <= 19) // Козерог
            {
                await Navigation.PushAsync(pages[9]);
            }
            if (m == 1 && d >= 20 && d <= 31 || m == 2 && d <= 18) // Водолей
            {
                await Navigation.PushAsync(pages[10]);
            }
            if (m == 2 && d >= 19 && d <= 28 || m == 3 && d <= 20) // Рыбы
            {
                await Navigation.PushAsync(pages[11]);
            }
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
            img.Source = files[i];

        }

        private async void Pk_SelectedIndexChanged(object sender, EventArgs e)
        {
            await Navigation.PushAsync(pages[pk.SelectedIndex]);
        }
    }
}