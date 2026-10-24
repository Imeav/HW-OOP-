using System;
using System.Collections.Generic;
using System.Text;



using System;
using System.Collections.Generic;

public class Team
{
    public string Name { get; set; }

    private List<Worker> workers;


    public Team(string name)
    {
        Name = name;
        workers = new List<Worker>();
    }


    public void AddWorker(Worker worker)
    {
        workers.Add(worker);
    }

 
    public void ShowTeam()
    {
        Console.WriteLine($"Команда: {Name}");

        foreach (Worker worker in workers)
        {
            Console.WriteLine(worker.Name);
        }
    }


    public void ShowDetailedTeam()
    {
        Console.WriteLine($"Team: {Name}");

        foreach (Worker worker in workers)
        {
            Console.WriteLine(
                $"{worker.Name} - {worker.Position} - " +
                $"{string.Join(", ", worker.WorkDay)}"
            );
        }
    }
}


