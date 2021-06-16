using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MesRecettes.Models
{
    public class UnitsOfMeasure : LookUp
    {
     /*   public int Id { get; set; }
        public string Name {get; set;}*/
     public UnitsOfMeasure() : base() { }
     public UnitsOfMeasure(MeasurementType m) : base()
     {
            this.MeasurementType = m;
     }
    public MeasurementType MeasurementType { get; set; }
    }
}
