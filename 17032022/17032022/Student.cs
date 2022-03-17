using System;
using System.Collections.Generic;
using System.Text;

namespace _17032022
{
    internal class Student
    {
        private int _avgPoint;

        public string Name { get; set; }

        public string Surname { get; set; }

        public int AvgPoint
        {
            get => _avgPoint;
            set
            {
                if (value >= 0 && value <= 100)
                    _avgPoint = value;
            }
        }
    }
}
