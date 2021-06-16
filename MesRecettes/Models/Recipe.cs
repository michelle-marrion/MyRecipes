using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MesRecettes.Models
{
    public class Recipe
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public MeasurementType MeasurementType { get; set; }
        public int? BakeTemperature { get; set; }
        public int? BackTime { get; set; }
        public string Instructions { get; set; }
        public int FoodTypeId { get; set; }
        public int FoodEthnicityId { get; set; }

        public virtual FoodType FoodType { get; set; }

        public virtual FoodEthnicity FoodEthnicity { get; set; }
        public virtual ICollection <RecipeIngredient> RecipeIngredients { get; set; }
    }
}
