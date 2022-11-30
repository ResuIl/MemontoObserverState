public class Life
{
    private string time;
    public void Set(string time)
    {
        Console.WriteLine("Setting time to " + time);
        this.time = time;
    }
    public Memento SaveToMemory()
    {
        Console.WriteLine("Saving time to memento");
        return new Memento(time);
    }
    public void RestoreFromMemento(Memento memento)
    {
        time = memento.GetSavedTime();
        Console.WriteLine("Time Restored from memento " + time);
    }
}

public class Memento
{
    private readonly string time;
    public Memento(string time)
    {
        this.time = time;
    }
    public string GetSavedTime() => time;
}

class Program
{
    static void Main()
    {
        List<Memento> SavedTimes = new List<Memento>();
        Life life = new Life();
        life.Set("12:00");
        SavedTimes.Add(life.SaveToMemory());
        life.Set("13:00");
        SavedTimes.Add(life.SaveToMemory());
        life.Set("14:00");
        SavedTimes.Add(life.SaveToMemory());
        life.Set("15:00");
        life.RestoreFromMemento(SavedTimes[2]);
    }
}