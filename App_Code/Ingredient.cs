using System;
using System.Collections.Generic;
using System.Web;

/// <summary>
/// Contains all of the pertinent information about an ingredient
/// </summary>
public class Ingredient
{
    //Class members
    public string IngredientName {get; set;}
    public string Type {get; set;}
    public string Source {get; set;}
    public string AllergyInfo {get; set;}

    public Ingredient()
    {
        //constructor
        IngredientName="";
        Type="";
        Source="";
        AllergyInfo="";
    }
}

