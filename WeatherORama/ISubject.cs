using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherORama
{
    public interface ISubject
    {
        void registerObserver(IObserver observer);
        void removeObserver(IObserver observer);
        void notifyObservers();

        float Temperature { get; }
        float Humidity { get; }
        float Pressure { get; }
        float HeatIndex { get; }
    }
}
