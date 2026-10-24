using System;
using System.Collections.Generic;
using System.Text;



public class Manager : Worker
{
    private Random random = new Random();

    public Manager(string name) : base(name)
    {
        Position = "Manager";
    }

    public override void FillWorkDay()
    {
        int count1 = random.Next(1, 11);

        for (int i = 0; i < count1; i++)
        {
            Call();
        }

        Relax();

        int count2 = random.Next(1, 6);

        for (int i = 0; i < count2; i++)
        {
            Call();
        }
    }
}

