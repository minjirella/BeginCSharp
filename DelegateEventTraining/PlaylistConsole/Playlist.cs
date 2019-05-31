using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlaylistLibrary
{
    public class Playlist
    {
        public string TrackName { get; set; }
        public string ArtistName { get; set; }
        public int Hit { get; set; }

        public Playlist(string trackName, string artistName, int hit = 0)
        {
            TrackName = trackName;
            ArtistName = artistName;
            Hit = hit;
        }

        // TODO : 증감메소드를 따로줬는데 이 중복을 해결하는 방법
        public void IncreaseHit()
        {
            int currentHit = Hit;
            Hit++;

            OnHitChanged(currentHit, Hit);
        }

        public void DecreaseHit()
        {
            int currentHit = Hit;
            Hit--;

            OnHitChanged(currentHit, Hit);
        }

        #region HitChanged event things for C# 3.0
        public event EventHandler<HitChangedEventArgs> HitChanged;

        protected virtual void OnHitChanged(HitChangedEventArgs e)
        {
            if (HitChanged != null)
                HitChanged(this, e);
        }

        private HitChangedEventArgs OnHitChanged(int oldHit, int newHit)
        {
            HitChangedEventArgs args = new HitChangedEventArgs(oldHit, newHit);
            OnHitChanged(args);

            return args;
        }

        private HitChangedEventArgs OnHitChangedForOut()
        {
            HitChangedEventArgs args = new HitChangedEventArgs();
            OnHitChanged(args);

            return args;
        }

        public class HitChangedEventArgs : EventArgs
        {
            public int OldHit { get; set; }
            public int NewHit { get; set; }

            public HitChangedEventArgs()
            {
            }

            public HitChangedEventArgs(int oldHit, int newHit)
            {
                OldHit = oldHit;
                NewHit = newHit;
            }
        }
        #endregion

    }

}
