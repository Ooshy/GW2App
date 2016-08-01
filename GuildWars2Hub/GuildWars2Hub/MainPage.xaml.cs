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

            Task.Run(async () =>
            {
                for (;;)
                {
                    var items = (ObservableCollection<ListItemVM>)_List.ItemsSource;
                    if (items != null)
                    {
                        var sortedItems = new ObservableCollection<ListItemVM>(items.OrderByDescending(i => TimeSpan.Parse(i.TimeCounter.Current)));
                    }
                    await Task.Delay(TimeSpan.FromSeconds(1));
                }
            });
        }

        private async void _List_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var item = e.SelectedItem as ListItemVM;
            if (item == null)
                return;

            _List.SelectedItem = null;

            await Task.Run(() =>
            {

            });
        }
    }
}
