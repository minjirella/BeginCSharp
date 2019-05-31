using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace delegatePractice
{
    public class Person
    {
        private int _age;
        public int Age
        {
            get { return _age; }
            set { _age = value; }
        }

        private string _name;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public Person(int age, string name)
        {
            _age = age;
            _name = name;
        }

        //public delegate void AgeChangedDelegate(int oldAge, int newAge);
        //public AgeChangedDelegate AgeChanged;

        //public event AgeChangedEventHandler AgeChanged;
        public event EventHandler<AgeChangedEventArgs> AgeChanged;

        public void IncreaseAge()
        {
            int oldAge = _age;
            _age++;

            if (AgeChanged != null)
                AgeChanged(this, new AgeChangedEventArgs(oldAge, _age));
        }
    }

    public delegate void AgeChangedEventHandler(int oldAge, int newAge);
}
