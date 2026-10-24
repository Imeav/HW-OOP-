using System;
using System.Collections.Generic;
using System.Text;

public class River : GeographicObject
{
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

    public override string GetInfo()
    {
        return base.GetInfo() +
               $"\nFlow speed: {FlowSpeed} m/s" +
               $"\nLength: {Length} km";
    }
}
