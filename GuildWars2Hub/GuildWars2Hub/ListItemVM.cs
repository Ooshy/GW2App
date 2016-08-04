using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace GuildWars2Hub
{
    public class Boss : View, INotifyPropertyChanged
    {
        public string ImageUri { get; set; }

        private TimeSpan _TimeCounter;
        public TimeSpan SpawnTime
        {
            get
            {
                return _TimeCounter;
            }
            set
            {
                if (_TimeCounter != value)
                {
                    _TimeCounter = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(SpawnTime)));
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


        private string _Subtitle;
        public string Description
        {
            get
            {
                return _Subtitle;
            }
            set
            {
                if (_Subtitle != value)
                {
                    _Subtitle = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Description)));
                }
            }
        }


        public event PropertyChangedEventHandler PropertyChanged = delegate { };
    }
}
