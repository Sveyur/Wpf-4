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

namespace Wpf_4
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();           
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {           
            try
            {
                double dollarRate = Convert.ToDouble(textBox1_1.Text);
                double  dollarSumma = Convert.ToDouble(textBox1_2.Text);
                double rublesSumma1 = dollarRate * dollarSumma;
                textBox1_3.Text = rublesSumma1.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Неправильный формат введенных данных");
            }           
        }
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {            
            try
            {
                double euroRate = Convert.ToDouble(textBox2_1.Text);
                double euroSumma = Convert.ToDouble(textBox2_2.Text);
                double rublesSumma2 = euroRate * euroSumma;
                textBox2_3.Text = rublesSumma2.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Неправильный формат введенных данных");
            }
        }
        private void Button_Click_2(object sender, RoutedEventArgs e)
        {            
            try
            {
                double hryvniaRate = Convert.ToDouble(textBox3_1.Text);
                double hryvniaSumma = Convert.ToDouble(textBox3_2.Text);
                double rublesSumma3 = hryvniaRate * hryvniaSumma;
                textBox3_3.Text = rublesSumma3.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Неправильный формат введенных данных");
            }
        }
        private void Button_Click_3(object sender, RoutedEventArgs e)
        {            
            try
            {
                double dramaRate = Convert.ToDouble(textBox4_1.Text);
                double dramaSumma = Convert.ToDouble(textBox4_2.Text);
                double rublesSumma4 = dramaRate * dramaSumma;
                textBox4_3.Text = rublesSumma4.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Неправильный формат введенных данных");
            }
        }
        private void Button_Click_4(object sender, RoutedEventArgs e)
        {            
            try
            {
                double inch = Convert.ToDouble(textBox5_1.Text);
                double meter1 = inch * 0.0254;
                textBox5_2.Text = meter1.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Неправильный формат введенных данных");
            }
        }
        private void Button_Click_5(object sender, RoutedEventArgs e)
        {            
            try
            {
                double ft = Convert.ToDouble(textBox6_1.Text);
                double meter2 = ft * 0.3048;
                textBox6_2.Text = meter2.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Неправильный формат введенных данных");
            }
        }
        private void Button_Click_6(object sender, RoutedEventArgs e)
        {            
            try
            {
                double mile = Convert.ToDouble(textBox7_1.Text);
                double meter3 = mile * 1609.34;
                textBox7_2.Text = meter3.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Неправильный формат введенных данных");
            }
        }
        private void Button_Click_7(object sender, RoutedEventArgs e)
        {            
            try
            {
                double verst = Convert.ToDouble(textBox8_1.Text);
                double meter4 = verst * 1066.8;
                textBox8_2.Text = meter4.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Неправильный формат введенных данных");
            }
        }
    }
}
