using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace Laba3_ListBox
{
    class MyValues
    {
        private double xStart;
        public double xStop;
        public double step;
        public double n;

        public MyValues()
        {
            XStart = 0;
            xStop = 0;
            Step = 1;
            N = 1;

        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName]string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }

        public double XStart
        {
            get { return xStart; }
            set
            {

                xStart = value;
                OnPropertyChanged("XStart");

            }
        }

        public double XStop
        {
            get { return xStop; }
            set
            {
                xStop = value;
                OnPropertyChanged("XStop");

            }
        }
        public double Step
        {
            get { return step; }
            set
            {
                step = value;
                OnPropertyChanged("step");

            }
        }
        public double N
        {
            get { return n; }
            set
            {
                n = value;
                OnPropertyChanged("N");
            }
        }

        public void getResults(ObservableCollection<string> results)
        {
            double currentX = xStart;
            StringBuilder allResultString = new StringBuilder();
            double Yresult;
            while (currentX <= xStop)
            {
                int k = 0;
                double sum = 0;
                while (k <= N)
                {
                    sum += Math.Pow(currentX, 2 * k) * (2 * k + 1) / calculateFactorial(k);
                    k += 1;
                }
                allResultString.Append($"S({currentX}) = {sum}")
                    .Append("; ");


                Yresult = (1 + 2 * Math.Pow(currentX, 2)) * Math.Exp(Math.Pow(currentX, 2));
                allResultString.Append($"Y({currentX}) = {Yresult}");

                results.Add(allResultString.ToString());
                allResultString.Clear();
                currentX += step;
            }
        }

        private double calculateFactorial(int maxNumber)
        {
            double result = 1;
            while (maxNumber != 1 && maxNumber != 0)
                while (maxNumber != 1 && maxNumber != 0)
                {
                    result = result * maxNumber;
                    maxNumber--;
                }
            return result;
        }
    }
}
