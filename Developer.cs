using System;

public class Developer : Worker
{
    public Developer(string name) : base(name)
    {
        Position = "Developer";
    }

    // Перевизначення методу FillWorkDay
    public override void FillWorkDay()
    {
        WriteCode();
        Call();
        Relax();
        WriteCode();
    }
}
