using System;

public class Manager : Worker
{
    private Random random;

    public Manager(string name) : base(name)
    {
        Position = "Manager";
        random = new Random();
    }

    // Перевизначення методу FillWorkDay
    public override void FillWorkDay()
    {
        int callsFirstPart = random.Next(1, 11); // Випадкова кількість дзвінків від 1 до 10
        for (int i = 0; i < callsFirstPart; i++)
        {
            Call();
        }

        Relax();

        int callsSecondPart = random.Next(1, 6); // Випадкова кількість дзвінків від 1 до 5
        for (int i = 0; i < callsSecondPart; i++)
        {
            Call();
        }
    }
}
