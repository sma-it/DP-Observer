using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherORama
{
    public class WeatherData : ISubject
    {
        private List<IObserver> observers;
        private float temperature;
        public float Temperature
        {
            get => temperature;
            set
            {
                temperature = value;
                measurementsChanged();
            }
        }

        private float humidity;
        public float Humidity
        {
            get => humidity;
            set
            {
                humidity = value;
                measurementsChanged();
            }
        }

        private float pressure;
        public float Pressure
        {
            get => pressure;
            set
            {
                pressure = value;
                measurementsChanged();
            }
        }

        private float heatIndex;
        public float HeatIndex
        {
            get => heatIndex;
            set
            {
                heatIndex = value;
                measurementsChanged();
            }
        }

        public WeatherData()
        {
            observers = new List<IObserver>();
        }

        public void registerObserver(IObserver observer)
        {
            observers.Add(observer);
        }

        public void removeObserver(IObserver observer)
        {
            observers.Remove(observer);
        }

        public void notifyObservers()
        {
            observers.ForEach((observer) =>
            {
                observer.update();
            });
        }

        public void measurementsChanged()
        {
            notifyObservers();
        }
    }
}
