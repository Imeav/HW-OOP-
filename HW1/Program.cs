
using System;
using System.Collections.Generic;


using System;
using System.Collections.Generic;

List<Team> teams = new List<Team>();

while (true)
{
    Console.WriteLine("1. Create team");
    Console.WriteLine("2. Add developer");
    Console.WriteLine("3. Add manager");
    Console.WriteLine("4. Show all teams");
    Console.WriteLine("5. Show detailed team information");

    Console.Write("Choose option: ");

    try
    {
        int choice = int.Parse(Console.ReadLine() ?? "");

        switch (choice)
        {
            case 1:
                {
                    Console.Write("Enter team name: ");
                    string name = Console.ReadLine() ?? "";

                    teams.Add(new Team(name));

                    Console.WriteLine("Team created!");
                    break;
                }

            case 2:
                {
                    Team team = ChooseTeam(teams);

                    Console.Write("Enter developer name: ");
                    string name = Console.ReadLine() ?? "";

                    Developer developer = new Developer(name);

                    developer.FillWorkDay();
                    team.AddWorker(developer);

                    Console.WriteLine("Developer added!");
                    break;
                }

            case 3:
                {
                    Team team = ChooseTeam(teams);

                    Console.Write("Enter manager name: ");
                    string name = Console.ReadLine() ?? "";

                    Manager manager = new Manager(name);

                    manager.FillWorkDay();
                    team.AddWorker(manager);

                    Console.WriteLine("Manager added!");
                    break;
                }

            case 4:
                {
                    switch (teams.Count)
                    {
                        case 0:
                            throw new Exception("No teams available!");
                    }

                    foreach (Team team in teams)
                    {
                        team.ShowTeam();
                    }

                    break;
                }

            case 5:
                {
                    Team team = ChooseTeam(teams);
                    team.ShowDetailedTeam();
                    break;
                }

            default:
                Console.WriteLine("Invalid option!");
                break;
        }
    }
    catch (FormatException)
    {
        Console.WriteLine("Please enter a number!");
    }
    catch (OverflowException)
    {
        Console.WriteLine("Number is too large!");
    }
    catch (ArgumentOutOfRangeException)
    {
        Console.WriteLine("Invalid team number!");
    }
    catch (Exception ex)
    {
        Console.WriteLine(ex.Message);
    }
}

static Team ChooseTeam(List<Team> teams)
{
    switch (teams.Count)
    {
        case 0:
            throw new Exception("Create a team first!");
    }

    Console.WriteLine("Available teams:");

    for (int i = 0; i < teams.Count; i++)
    {
        Console.WriteLine($"{i + 1}. {teams[i].Name}");
    }

    Console.Write("Enter team number: ");

    int number = int.Parse(Console.ReadLine() ?? "");

    return teams[number - 1];
}


