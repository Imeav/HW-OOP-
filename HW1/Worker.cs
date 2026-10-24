using System;
using System.Collections.Generic;
using System.Text;


using System;
using System.Collections.Generic;

public abstract class Worker
{
  
    public string Name
    { get; set; }
    public string Position
    { get; protected set; }
    public List<string> WorkDay
    { get; set; }


    public Worker(string name)
    {
        Name = name;
        Position = "";
        WorkDay = new List<string>();
    }



    public void Call()
    {
        WorkDay.Add("Call");
    }

    public void WriteCode()
    {
        WorkDay.Add("WriteCode");
    }

    public void Relax()
    {
        WorkDay.Add("Relax");
    }

  
    public abstract void FillWorkDay();
}
