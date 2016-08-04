using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace GuildWars2Hub
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            _List.ItemSelected += _List_ItemSelected;

            _List.ChildAdded += _List_ChildAdded;

            //Task.Run(async () =>
            //{
            //    for (;;)
            //    {
            //        var items = (ObservableCollection<Boss>)_List.ItemsSource;
            //        if (items != null)
            //        {
            //            var sortedItems = new ObservableCollection<Boss>(items.OrderByDescending(i => TimeSpan.Parse(i.SpawnTime)));
            //        }
            //        await Task.Delay(TimeSpan.FromSeconds(1));
            //    }
            //});
        }

        private void _List_ChildAdded(object sender, ElementEventArgs e)
        {
            
        }

        public void OnMore(object sender, EventArgs e)
        {
            var mi = ((MenuItem)sender);
            DisplayAlert("More Context Action", mi.CommandParameter + " more context action", "OK");
        }

        public void OnDelete(object sender, EventArgs e)
        {
            var mi = ((MenuItem)sender);
            DisplayAlert("Delete Context Action", mi.CommandParameter + " delete context action", "OK");
        }

        private void _List_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var item = e.SelectedItem as Boss;
            
            

            if (item == null)
                return;

            _List.SelectedItem = null;

          
        }
    }
}
