using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuildWars2Hub
{
    public class TimeCounter : INotifyPropertyChanged
    {
        private TimeSpan _RefreshInterval = TimeSpan.FromSeconds(1);
        private TimeSpan _InternalTime;

        private readonly TimeSpan _RespawnInterval;
        private readonly TimeSpan _InitialTime;
        public TimeCounter(TimeSpan intialTime, TimeSpan respawnInterval)
        {
            if ((_InitialTime = intialTime) == null)
                throw new ArgumentNullException("Initial time is null.");
            if ((_RespawnInterval = respawnInterval) == null)
                throw new ArgumentNullException("Respawn interval is null.");

            _InternalTime = _InitialTime;

            Current = _InternalTime.ToString();
            Task.Run(async () =>
            {
                for (;;)
                {
                    await Task.Delay(_RefreshInterval);

                    if (_RefreshInterval > _InternalTime)
                    {
                        RestartTimer();
                    }
                    else
                    {
                        TimerTick();
                    }
                }
            });
        }

        private void RestartTimer()
        {
            _InternalTime = _RespawnInterval;
            Current = _InternalTime.ToString();
        }

        private void TimerTick()
        {
            _InternalTime -= _RefreshInterval;
            Current = _InternalTime.ToString();
        }

        private string _Current;
        public string Current
        {
            get
            {
                return _Current;
            }
            set
            {
                if (_Current != value)
                {
                    _Current = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Current)));
                }
            }
        }
        public event PropertyChangedEventHandler PropertyChanged = delegate { };

    }
}
