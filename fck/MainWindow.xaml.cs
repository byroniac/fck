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

namespace fck
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        private double degreesFahrenheit = 0;
        private double degreesCelsius = 0;
        private double degreesKelvin = 0;

        private void outputResults()
        {
            textBox1.Text = degreesFahrenheit.ToString();
            textBox2.Text = degreesCelsius.ToString();
            textBox3.Text = degreesKelvin.ToString();
        }

        private void convertFahrenheit()
        {
            if (!double.TryParse(textBox1.Text, out degreesFahrenheit))
            {
                degreesFahrenheit = 0;
            }
            degreesCelsius = (degreesFahrenheit - 32) * 5 / 9;
            degreesKelvin = degreesCelsius + 273.15;
            outputResults();
        }

        private void convertCelsius()
        {
            if (!double.TryParse(textBox2.Text, out degreesCelsius))
            {
                degreesCelsius = 0;
            }
            degreesFahrenheit = (degreesCelsius * 9 / 5) + 32;
            degreesKelvin = degreesCelsius + 273.15;
            outputResults();
        }

        private void convertKelvin()
        {
            if (!double.TryParse(textBox3.Text, out degreesKelvin))
            {
                degreesKelvin = 0;
            }
            degreesCelsius = degreesKelvin - 273.15;
            degreesFahrenheit = (degreesCelsius * 9 / 5) + 32;
            outputResults();
        }

        public MainWindow()
        {
            InitializeComponent();
            convertCelsius();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            convertFahrenheit();
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            convertCelsius();
        }

        private void button3_Click(object sender, RoutedEventArgs e)
        {
            convertKelvin();
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Return)
            {
                convertFahrenheit();
            }
        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Return)
            {
                convertCelsius();
            }
        }

        private void textBox3_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Return)
            {
                convertKelvin();
            }
        }
    }
}
