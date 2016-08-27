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

namespace WPF.Meter
{
    /// <summary>
    /// Interaction logic for UserControl1.xaml
    /// </summary>
    public partial class WPFMeter : UserControl
    {
        private double _value;
        private string _unit;
        private string _title;

        public WPFMeter()
        {
            InitializeComponent();
            Value = 225;
            Unit = "Unit";
            Title = "Voltage A-B";
            value.Content = Value;
            unit.Content = Unit;
            titleblock.Text = Title;
            
        }

        public double Value
        {
            get { return _value; }
            set
            {
                _value = value;
            }
        }
        public string Unit
        {
            get { return _unit; }
            set
            {
                _unit = value;
            }
        }
        public string Title
        {
            get { return _title; }
            set
            {
                _title = value;
            }
        }
    }
}
