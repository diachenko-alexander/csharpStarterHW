using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace AdditionalTask
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private string message = "Minimal value is {0}\nMaximal value is {1}";

        public MainWindow()
        {
            InitializeComponent();            
        }

        private void _sbyte_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(String.Format(message, sbyte.MinValue,sbyte.MaxValue));
        }

        private void _byte_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(String.Format(message, byte.MinValue, byte.MaxValue));
        }

        private void _short_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(String.Format(message, short.MinValue, short.MaxValue));
        }

        private void _ushort_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(String.Format(message, ushort.MinValue, ushort.MaxValue));
        }

        private void _int_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(String.Format(message, int.MinValue, int.MaxValue));
        }

        private void _uint_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(String.Format(message, uint.MinValue, uint.MaxValue));
        }

        private void _long_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(String.Format(message, long.MinValue, long.MaxValue));
        }

        private void _ulong_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(String.Format(message, ulong.MinValue, ulong.MaxValue));
        }
    }
}
