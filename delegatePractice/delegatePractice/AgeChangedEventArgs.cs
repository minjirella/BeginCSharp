using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace delegatePractice
{
    public class AgeChangedEventArgs : EventArgs
    {
        private int _oldAge;
        private int _newAge;
        public int OldAge
        {
            get { return _oldAge; }
            set { _oldAge = value; }
        }

        public int NewAge
        {
            get { return _newAge; }
            set { _newAge = value; }
        }

        public AgeChangedEventArgs(int oldAge, int newAge)
        {
            _oldAge = oldAge;
            _newAge = newAge;
        }
    }
}
