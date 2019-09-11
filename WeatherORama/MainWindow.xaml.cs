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
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public WeatherData Data { get; set; } = new WeatherData();


        public MainWindow()
        {
            InitializeComponent();
            DataContext = this;

            setObserver(new ConditionsDisplay(Data));
        }

        private void setObserver(IObserver observer)
        {
            DisplayController.Content = observer;
        }

        private void CurrentConditionsButton_Click(object sender, RoutedEventArgs e)
        {
            setObserver(new ConditionsDisplay(Data));
        }

        private void ForecastButton_Click(object sender, RoutedEventArgs e)
        {
            setObserver(new ForecastDisplay(Data));
        }

        private void StatisticsButton_Click(object sender, RoutedEventArgs e)
        {
            setObserver(new StatisticsDisplay(Data));
        }
    }
}
