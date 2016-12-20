using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace GuildWars2Hub
{
    public class EventCollection<T> : ObservableCollection<T> where T : Boss
    {
        private static TimeSpan _RefreshInterval = TimeSpan.FromSeconds(1);
        public void Initialze()
        {
            Task.Run(async () =>
            {
                for (;;)
                {
                    await Task.Delay(_RefreshInterval.Seconds * 1000);
                    foreach (var item in this)
                    {
                        item.Update();

                        var counter = item.Counter;
                        counter.Update(_RefreshInterval);
                    }
                }
            });
        }
    }
}
