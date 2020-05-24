using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Collections.ObjectModel;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Laba3_ListBox
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        MyValues myValues;
        ObservableCollection<string> results;

        public MainWindow()
        {
            InitializeComponent();
            myValues = new MyValues();
            myGrid.DataContext = myValues;

            results = new ObservableCollection<string>();
            ListBoxResults.DataContext = results;

        }

        private void btn_Calculate_Click(object sender, RoutedEventArgs e)
        {
            results.Clear();
            myValues.getResults(results);
        }


        private void checkStopBox()
        {
            BindingExpression bindingStop = tbXStop.GetBindingExpression(TextBox.TextProperty);
            bindingStop.UpdateSource();
        }

        private void checkBothBoxes()
        {
            BindingExpression bindingStart = tbXStart.GetBindingExpression(TextBox.TextProperty);
            bindingStart.UpdateSource();
            checkStopBox();
        }

        private void tbXStop_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key.ToString() == "Return")
            {
                checkStopBox();
            }
        }

        private void tbXStop_LostFocus(object sender, RoutedEventArgs e)
        {
            checkStopBox();
        }

        private void tbXStart_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key.ToString() == "Return")
            {
                checkBothBoxes();
            }
        }

        private void tbXStart_LostFocus(object sender, RoutedEventArgs e)
        {
            checkBothBoxes();
        }

       
    }
}
