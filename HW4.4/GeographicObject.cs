using System;
using System.Collections.Generic;
using System.Text;

public abstract class GeographicObject
{
    public double X { get; set; }
    public double Y { get; set; }

    public string Name { get; set; } = "";
    public string Description { get; set; } = "";

    public virtual string GetInfo()
    {
        return $"Name: {Name}\n" +
               $"Coordinates: {X}, {Y}\n" +
               $"Description: {Description}";
    }
}
