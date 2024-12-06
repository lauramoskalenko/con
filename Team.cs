using System;
using System.Collections.Generic;

public class Team
{
    public string TeamName { get; set; }
    private List<Worker> workers;

    public Team(string teamName)
    {
        TeamName = teamName;
        workers = new List<Worker>();
    }

    // Метод для додавання співробітника
    public void AddWorker(Worker worker)
    {
        workers.Add(worker);
    }

    // Метод для виведення інформації про команду
    public void DisplayTeamInfo()
    {
        Console.WriteLine($"Team: {TeamName}");
        foreach (var worker in workers)
        {
            Console.WriteLine(worker.Name);
        }
    }

    // Метод для виведення детальної інформації про команду
    public void DisplayDetailedInfo()
    {
        Console.WriteLine($"Team: {TeamName}");
        foreach (var worker in workers)
        {
            Console.WriteLine($"{worker.Name} - {worker.Position} - {worker.WorkDay}");
        }
    }
}
