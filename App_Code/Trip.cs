using System;
using System.Collections.Generic;
using System.Web;

/// <summary>
/// Trip contains all of the pertinent information for an SOE outing
/// </summary>
public class Trip
{
    //Class members
    public string TripName {get; set;}
    public List<string> Leaders {get; set;}
    public DateTime Date {get; set;}
    public int NumPeople {get; set;}
    public int NumMeals {get; set;}

    public Trip()
    {
        //constructor
        TripName="";
        Date = System.DateTime.Now; //store the date/time of instantiation as default
        NumMeals = 0;
        NumPeople = 0;
        Leaders = new List<string>();
    }
}
