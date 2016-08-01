using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuildWars2Hub
{
    public class ListItemVM : INotifyPropertyChanged
    {


        private TimeCounter _TimeCounter;
        public TimeCounter TimeCounter
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
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(TimeCounter)));
                }
            }
        }


        private string _Title;
        public string Title
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
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Title)));
                }
            }
        }


        private string _Subtitle;
        public string Subtitle
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
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Subtitle)));
                }
            }
        }


        public event PropertyChangedEventHandler PropertyChanged = delegate { };
    }
}
