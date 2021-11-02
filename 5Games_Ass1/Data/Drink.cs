using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5Games_Ass1
{
    public class Drink
    {
        public int DrinkId { get; set; }
        public string Name { get; set; }
        public string ImageName { get; set; }
        public string Recipe { get; set; }
        public string Mix { get; set; }

        public Drink()
        {
            Name = "";
            ImageName = "";
            Recipe = "";
            Mix = "";
        }

        public Drink(string inputName, string inputImageName, string inputRecipe, string inputMix)
        {
            Name = inputName;
            ImageName = inputImageName;
            Recipe = inputRecipe;
            Mix = inputMix;
        }

    }
    
}
