using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba3_ListBox
{
    class MyValues
    {
        private double xStart;
        public double xStop;
        public double step;
        public double n;

        public double XStart
        {
            get { return xStart; }
            set
            {
                if (value < 5)
                {
                    throw new ArgumentException("Значение должно быть больше 5");
                }
                else
                {
                    xStart = value;
                }
            }
        }

        public double XStop
        {
            get { return xStop; }
            set
            {
                if (value < 5)
                {
                    throw new ArgumentException("Значение должно быть больше 5");
                }
                else
                {
                    xStop = value;
                }
            }
        }
        public double Step
        {
            get { return step; }
            set
            {
                if (value ==0)
                {
                    throw new ArgumentException("Значение должно быть больше 5");
                }
                else
                {
                    step = value;
                }
            }
        }
        public double N
        {
            get { return n; }
            set
            {
                if (value ==0)
                {
                    throw new ArgumentException("Значение должно быть больше 5");
                }
                else
                {
                    n = value;
                }
            }
        }

    }
}
