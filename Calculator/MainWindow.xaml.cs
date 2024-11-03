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

namespace Calculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void sum1_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Calculated!!!");

            allSum1.Text = (float.Parse(txtBox3.Text) / (float.Parse(txtBox1.Text) - float.Parse(txtBox2.Text))).ToString();
        }
    }
}
