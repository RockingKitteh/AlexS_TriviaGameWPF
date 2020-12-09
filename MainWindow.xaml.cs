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

namespace TriviaGameWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        String Name;
        String A1;
        String A2;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void NameBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            Name = NameBox.Text;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Hello " + Name + "!");
        }

        private void Q1_TextChanged(object sender, TextChangedEventArgs e)
        {
            A1 = Q1.Text;
        }

        private void Q2_TextChanged(object sender, TextChangedEventArgs e)
        {
            A2 = Q2.Text;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("For Question 1, you answered, " + A1 + ". \nThe correct answer is True!\n\nFor Question 2, you answered, " + A2 + ". \nThe correct answer is False!");
        }
    }
}
