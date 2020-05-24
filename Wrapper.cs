using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Laba3_ListBox
{
    class Wrapper : DependencyObject
    {
        
        public static readonly DependencyProperty StartProperty =
             DependencyProperty.Register("start", typeof(double),
             typeof(Wrapper), new FrameworkPropertyMetadata(null));    

        public double start
        {
            get { return (double)GetValue(StartProperty); }
            set { SetValue(StartProperty, value); }
        }

    }
}
