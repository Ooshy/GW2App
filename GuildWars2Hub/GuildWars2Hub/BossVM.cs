using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace GuildWars2Hub
{
    public class Boss : StackLayout, INotifyPropertyChanged
    {
        public Boss()
        {
            VerticalOptions = LayoutOptions.FillAndExpand;
            HorizontalOptions = LayoutOptions.FillAndExpand;
        }

        public ImageSource Image { get; set; }


        public bool Active
        {
            get; private set;
        }

        public void Update()
        {
            if (Active != IsActive)
            {
                Active = IsActive;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Active)));
            }
        }

        private bool IsActive => Counter.Current == "Active";

        private TimeSpan _SpawnTime;
        public TimeSpan SpawnTime
        {
            get
            {
                return _SpawnTime;
            }
            set
            {
                if (_SpawnTime != value)
                {
                    _SpawnTime = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(SpawnTime)));
                }
            }
        }

        private TimeCounter _Counter;
        public TimeCounter Counter
        {
            get
            {
                return _Counter;
            }
            set
            {
                if (_Counter != value)
                {
                    _Counter = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Counter)));
                }
            }
        }



        private string _Title;
        public string Name
        {
            get
            {
                return _Title;
            }
            set
            {
                if (_Title != value)
                {
                    _Title = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Name)));
                }
            }
        }


        private string _EventDescription;
        public string EventDescription
        {
            get
            {
                return _EventDescription;
            }
            set
            {
                if (_EventDescription != value)
                {
                    _EventDescription = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(EventDescription)));
                }
            }
        }


        public event PropertyChangedEventHandler PropertyChanged = delegate { };
    }
}
