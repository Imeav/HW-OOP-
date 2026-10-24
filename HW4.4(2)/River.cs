using System;
using System.Collections.Generic;
using System.Text;


public class River : IGeographicObject
{
    public double X { get; set; }
    public double Y { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }

    public double FlowSpeed { get; set; }
    public double Length { get; set; }

    public River(string name, string description,
                 double x, double y,
                 double flowSpeed, double length)
    {
        Name = name;
        Description = description;
        X = x;
        Y = y;
        FlowSpeed = flowSpeed;
        Length = length;
    }

    public string GetInfo()
    {
        return $"Name: {Name}\n" +
               $"Coordinates: {X}, {Y}\n" +
               $"Description: {Description}\n" +
               $"Flow speed: {FlowSpeed} m/s\n" +
               $"Length: {Length} km";
    }
}
