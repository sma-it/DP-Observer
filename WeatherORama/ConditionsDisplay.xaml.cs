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
        private ISubject weatherData;

        public ConditionsDisplay(WeatherData data)
        {
            InitializeComponent();
            data.registerObserver(this);
            weatherData = data;
        }

        ~ConditionsDisplay()
        {
            weatherData.removeObserver(this);
        }

        public void update()
        {
            LabelTemperature.Content = weatherData.Temperature.ToString();
            LabelHumidity.Content = weatherData.Humidity.ToString();
            LabelPressure.Content = weatherData.Pressure.ToString();
            LabelHeatIndex.Content = weatherData.HeatIndex.ToString();
        }
    }
}
