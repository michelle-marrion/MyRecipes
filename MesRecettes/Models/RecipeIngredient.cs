using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MesRecettes.Models
{
    public class RecipeIngredient
    {
        public virtual int RecipeId { get; set; }
        public virtual int IngredientId { get; set; }
        public Recipe Recipe { get; set; }
        public Ingredient Ingredient { get; set; }        
    }
}
