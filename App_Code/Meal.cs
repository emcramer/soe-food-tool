using System;
using System.Collections.Generic;
using System.Web;

/// <summary>
/// Contains all of the pertinent information to cooking a meal
/// </summary>
public class Meal
{
    //Class members
    public string MealName {get; set;}
    public string Type {get; set;}
    public List<int> Ratios {get; set;}
    public List<string> Ingredients {get; set;}
    public int NumIngredients {get; set;}

    public Meal()
    {
        //constructor
        MealName="";
        Type="";
        Ratios = new List<int>();
        Ingredients = new List<string>();
        NumIngredients = 0;
    }
}
