using System;
using System.Collections.Generic;
using System.Text;


public class Mountain : IGeographicObject
{
    public double X { get; set; }
    public double Y { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }

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

    public string GetInfo()
    {
        return $"Name: {Name}\n" +
               $"Coordinates: {X}, {Y}\n" +
               $"Description: {Description}\n" +
               $"Highest point: {HighestPoint} m";
    }
}

