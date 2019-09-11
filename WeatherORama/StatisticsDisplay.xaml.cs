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
    /// Interaction logic for StatisticsDisplay.xaml
    /// </summary>
    public partial class StatisticsDisplay : UserControl, IObserver
    {
        List<float> temperatures = new List<float>();
        List<float> humidities = new List<float>();
        List<float> pressures = new List<float>();

        private ISubject weatherData;

        public StatisticsDisplay(WeatherData data)
        {
            InitializeComponent();
            data.registerObserver(this);
            weatherData = data;
        }

        ~StatisticsDisplay()
        {
            weatherData.removeObserver(this);
        }

        public void update()
        {
            temperatures.Add(weatherData.Temperature);
            humidities.Add(weatherData.Humidity);
            pressures.Add(weatherData.Pressure);

            LabelTemperature.Content = temperatures.Average().ToString();
            LabelHumidity.Content = humidities.Average().ToString();
            LabelPressure.Content = pressures.Average().ToString();
        }
    }
}
