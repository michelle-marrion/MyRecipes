using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MesRecettes.Models
{
    public class Ingredient
    {
        public int Id { get; set; }
        public  string Name { get; set; }
        public virtual int UnitOfMeasureId { get; set; }
        public int Amount { get; set; }
        public UnitsOfMeasure UnitsOfMeasure { get; set; }
    }  

}
