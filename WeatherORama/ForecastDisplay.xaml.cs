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
    /// Interaction logic for ForecastDisplay.xaml
    /// </summary>
    public partial class ForecastDisplay : UserControl, IObserver
    {
        Random random = new Random();
        private ISubject weatherData;

        public ForecastDisplay(WeatherData data)
        {
            InitializeComponent();
            data.registerObserver(this);
            weatherData = data;
        }

        ~ForecastDisplay()
        {
            weatherData.removeObserver(this);
        }

        public void update(float temp, float humidity, float pressure)
        {
            LabelTemperature.Content = (temp + random.Next(4) - 2).ToString();
            LabelHumidity.Content = (humidity + random.Next(4) - 2).ToString();
            LabelPressure.Content = (pressure + random.Next(4) - 2).ToString();
        }
    }
}
