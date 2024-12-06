using System;

class Program
{
    static void Main(string[] args)
    {
        // Створення команди
        Team team = new Team("Developers Team");

        // Створення співробітників
        Worker developer = new Developer("John Doe");
        Worker manager = new Manager("Jane Smith");

        // Додавання співробітників до команди
        team.AddWorker(developer);
        team.AddWorker(manager);

        // Заповнення робочого дня
        developer.FillWorkDay();
        manager.FillWorkDay();

        // Виведення інформації про команду
        team.DisplayTeamInfo();
        team.DisplayDetailedInfo();
    }
}
