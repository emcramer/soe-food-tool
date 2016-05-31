using System;
using System.Collections.Generic;
using System.Web;

namespace FoodTool{
    /// <summary>
    /// Summary description for IngredientClass
    /// </summary>
    public class IngredientClass{
        //Class Members
        public string Name { get; set; }
        public int Ratio { get; set; }

        //Instance Constructor
        public IngredientClass(){
          Name = "";
          Ratio = 0;
        }
    }
}