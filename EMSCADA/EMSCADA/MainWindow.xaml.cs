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

namespace EMSCADA
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            button1GridEnable();
            startingMeter();

        }

        private void voltage_1_Click(object sender, RoutedEventArgs e)
        {
            sec_name.Content = "Voltage1";
            button1GridEnable();
            //Chart_A.StartChart();
            ChartA1.StartChart();
            ChartB1.StartChart();
            ChartC1.StartChart();
            ChartD1.StartChart();


        }


        private void voltage_2_Click(object sender, RoutedEventArgs e)
        {
            sec_name.Content = "Voltage2";
            button2GridEnable();
        }

        private void current_Click(object sender, RoutedEventArgs e)
        {
            sec_name.Content = "Current";
            button3GridEnable();
        }

        private void power_Click(object sender, RoutedEventArgs e)
        {
            sec_name.Content = "Power";
            button4GridEnable();
        }

        private void quality_Click(object sender, RoutedEventArgs e)
        {
            sec_name.Content = "Quality";
            button5GridEnable();
        }

        private void button1GridEnable()
        {
            button1.Visibility = Visibility.Visible;
            button2.Visibility = Visibility.Hidden;
            button3.Visibility = Visibility.Hidden;
            button4.Visibility = Visibility.Hidden;
            button5.Visibility = Visibility.Hidden;
        }

        private void button2GridEnable()
        {
            button1.Visibility = Visibility.Hidden;
            button2.Visibility = Visibility.Visible;
            button3.Visibility = Visibility.Hidden;
            button4.Visibility = Visibility.Hidden;
            button5.Visibility = Visibility.Hidden;
        }

        private void button3GridEnable()
        {
            button1.Visibility = Visibility.Hidden;
            button2.Visibility = Visibility.Hidden;
            button3.Visibility = Visibility.Visible;
            button4.Visibility = Visibility.Hidden;
            button5.Visibility = Visibility.Hidden;
        }

        private void button4GridEnable()
        {
            button1.Visibility = Visibility.Hidden;
            button2.Visibility = Visibility.Hidden;
            button3.Visibility = Visibility.Hidden;
            button4.Visibility = Visibility.Visible;
            button5.Visibility = Visibility.Hidden;
        }

        private void button5GridEnable()
        {
            button1.Visibility = Visibility.Hidden;
            button2.Visibility = Visibility.Hidden;
            button3.Visibility = Visibility.Hidden;
            button4.Visibility = Visibility.Hidden;
            button5.Visibility = Visibility.Visible;
        }

        private void startingMeter()
        {
            vol1a._deviceName("Device Name");
            vol1a.currentValue(0.00);
            vol1a.currentValueName("Value Name");
            vol1a.currentValueUnit("Unit");

            vol1b._deviceName("Device Name");
            vol1b.currentValue(0.00);
            vol1b.currentValueName("Value Name");
            vol1b.currentValueUnit("Unit");

            vol1c._deviceName("Device Name");
            vol1c.currentValue(0.00);
            vol1c.currentValueName("Value Name");
            vol1c.currentValueUnit("Unit");

            vol1d._deviceName("Device Name");
            vol1d.currentValue(0.00);
            vol1d.currentValueName("Value Name");
            vol1d.currentValueUnit("Unit");

            /*********************************************/

            vol2a._deviceName("Device Name");
            vol2a.currentValue(0.00);
            vol2a.currentValueName("Value Name");
            vol2a.currentValueUnit("Unit");

            vol2b._deviceName("Device Name");
            vol2b.currentValue(0.00);
            vol2b.currentValueName("Value Name");
            vol2b.currentValueUnit("Unit");

            vol2c._deviceName("Device Name");
            vol2c.currentValue(0.00);
            vol2c.currentValueName("Value Name");
            vol2c.currentValueUnit("Unit");

            vol2d._deviceName("Device Name");
            vol2d.currentValue(0.00);
            vol2d.currentValueName("Value Name");
            vol2d.currentValueUnit("Unit");

            /*********************************************/

            currenta._deviceName("Device Name");
            currenta.currentValue(0.00);
            currenta.currentValueName("Value Name");
            currenta.currentValueUnit("Unit");

            currentb._deviceName("Device Name");
            currentb.currentValue(0.00);
            currentb.currentValueName("Value Name");
            currentb.currentValueUnit("Unit");

            currentc._deviceName("Device Name");
            currentc.currentValue(0.00);
            currentc.currentValueName("Value Name");
            currentc.currentValueUnit("Unit");

            currentd._deviceName("Device Name");
            currentd.currentValue(0.00);
            currentd.currentValueName("Value Name");
            currentd.currentValueUnit("Unit");

            /*********************************************/


            powera._deviceName("Device Name");
            powera.currentValue(0.00);
            powera.currentValueName("Value Name");
            powera.currentValueUnit("Unit");

            powerb._deviceName("Device Name");
            powerb.currentValue(0.00);
            powerb.currentValueName("Value Name");
            powerb.currentValueUnit("Unit");

            powerc._deviceName("Device Name");
            powerc.currentValue(0.00);
            powerc.currentValueName("Value Name");
            powerc.currentValueUnit("Unit");


            /*********************************************/


            qualitya._deviceName("Device Name");
            qualitya.currentValue(0.00);
            qualitya.currentValueName("Value Name");
            qualitya.currentValueUnit("Unit");

            qualityb._deviceName("Device Name");
            qualityb.currentValue(0.00);
            qualityb.currentValueName("Value Name");
            qualityb.currentValueUnit("Unit");

            qualityc._deviceName("Device Name");
            qualityc.currentValue(0.00);
            qualityc.currentValueName("Value Name");
            qualityc.currentValueUnit("Unit");

            qualityd._deviceName("Device Name");
            qualityd.currentValue(0.00);
            qualityd.currentValueName("Value Name");
            qualityd.currentValueUnit("Unit");

            /*********************************************/
        }
    }
}
