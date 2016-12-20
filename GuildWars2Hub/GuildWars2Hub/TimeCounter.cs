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
        private static TimeSpan _RefreshInterval = TimeSpan.FromSeconds(1);
        private TimeSpan _InternalTime;

        private readonly TimeSpan _RespawnInterval;
        private readonly TimeSpan _InitialTime;
        public TimeCounter(TimeSpan intialTime, TimeSpan respawnInterval)
        {
            if ((_InitialTime = intialTime) == null)
                throw new ArgumentNullException("Initial time is null.");
            if ((_RespawnInterval = respawnInterval) == null)
                throw new ArgumentNullException("Respawn interval is null.");

            if (EventIsActive())
            {
                // do nothing
            }
            else if (EventIsExpired())
                _InitialTime += TimeSpan.FromHours(24);

            _InternalTime = _InitialTime;

            Current = FormattedInternalTime();
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

        private bool EventIsExpired()
        {
            return _InitialTime.Ticks < 0 && !EventIsActive();
        }

        private bool EventIsActive()
        {
            return _InitialTime.Hours == 0 && _InitialTime.Minutes > -15 && _InitialTime.Minutes <= 0;
        }

        private void RestartTimer()
        {
            _InternalTime = _RespawnInterval;
            Current = FormattedInternalTime();
        }

        private void TimerTick()
        {
            _InternalTime -= _RefreshInterval;
            Current = FormattedInternalTime();
        }

        private string FormattedInternalTime()
        {
            return _InternalTime.ToString(@"hh\:mm\:ss");
        }

        private string _Current;
        public string Current
        {
            get
            {
                return EventIsActive() ? "Active" : _Current;
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
