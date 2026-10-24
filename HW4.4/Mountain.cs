using System;
using System.Collections.Generic;
using System.Text;


public class Mountain : GeographicObject
{
    public double HighestPoint { get; set; } 

    public Mountain(string name, string description,
                 double x, double y, double highestPoint)
    {
        Name = name;
        Description = description;
        X = x;
        Y = y;
        HighestPoint = highestPoint;
    }

    public override string GetInfo()
    {
        return base.GetInfo() +
               $"\nHighest point: {HighestPoint} m";
    }
}
