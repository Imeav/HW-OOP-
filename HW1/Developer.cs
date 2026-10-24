using System;
using System.Collections.Generic;
using System.Text;


public class Developer : Worker
{
    public Developer(string name) : base(name)
    {
        Position = "Developer";
    }

    public override void FillWorkDay()
    {
        WriteCode();
        Call();
        Relax();
        WriteCode();
    }
}




