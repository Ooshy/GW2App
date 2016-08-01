using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace GuildWars2Hub
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            var viewModel = new
            {
                Title = "Guild Wars 2 Hub",
                ListData = new ObservableCollection<ListItemVM>
                {
                    new ListItemVM
                    {
                        Title = "Fake Boss",
                        Subtitle = "He is a real douche.",
                        TimeCounter = new TimeCounter(TimeSpan.FromSeconds(30), TimeSpan.FromSeconds(45))
                    },
                    new ListItemVM
                    {
                        Title = "Shaniqua",
                        Subtitle = "Sister of Tyrone.",
                        TimeCounter = new TimeCounter(TimeSpan.FromSeconds(60), TimeSpan.FromSeconds(120))
                    },
                    new ListItemVM
                    {
                        Title = "Tyrone",
                        Subtitle = "The benevolent dictator.",
                        TimeCounter = new TimeCounter(TimeSpan.FromSeconds(120), TimeSpan.FromSeconds(240))
                    },
                    new ListItemVM
                    {
                        Title = "Bagel Jr.",
                        Subtitle = "A true schmuck.",
                        TimeCounter = new TimeCounter(TimeSpan.FromSeconds(360), TimeSpan.FromSeconds(720))
                    },
                    new ListItemVM
                    {
                        Title = "Hillary Clinton",
                        Subtitle = "???",
                        TimeCounter = new TimeCounter(TimeSpan.FromSeconds(1080), TimeSpan.FromSeconds(2160))
                    },
                    new ListItemVM
                    {
                        Title = "The Donald",
                        Subtitle = "???",
                        TimeCounter = new TimeCounter(TimeSpan.FromSeconds(2160), TimeSpan.FromSeconds(2160))
                    },
                },
                ListTitle = "My List",
                ListShortName = "List"
            };


            MainPage = new GuildWars2Hub.MainPage() { BindingContext = viewModel };
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
