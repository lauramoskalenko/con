using System;

public abstract class Worker
{
    public string Name { get; set; }
    public string Position { get; set; }
    public string WorkDay { get; set; }

    // Конструктор, який приймає ім'я
    public Worker(string name)
    {
        Name = name;
        Position = "Unassigned";
        WorkDay = "Not defined";
    }

    // Методи
    public void Call() => Console.WriteLine($"{Name} is calling...");

    public void WriteCode() => Console.WriteLine($"{Name} is writing code...");

    public void Relax() => Console.WriteLine($"{Name} is relaxing...");

    // Абстрактний метод для заповнення робочого дня
    public abstract void FillWorkDay();
}
