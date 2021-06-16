using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MesRecettes.Models
{
    public abstract class LookUp
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
    public enum MeasurementType { Imperial, Metric}
    public enum TemperatureUnit { Celcuis, Fahrenheit}

}
