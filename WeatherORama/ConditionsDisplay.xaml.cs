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

namespace WeatherORama
{
    /// <summary>
    /// Interaction logic for ConditionsDisplay.xaml
    /// </summary>
    public partial class ConditionsDisplay : UserControl, IObserver
    {

        public ConditionsDisplay()
        {
            InitializeComponent();
        }

        public void update(float temp, float humidity, float pressure)
        {
            LabelTemperature.Content = temp.ToString();
            LabelHumidity.Content = humidity.ToString();
            LabelPressure.Content = pressure.ToString();
        }
    }
}
