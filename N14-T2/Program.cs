using System.ComponentModel;

UltimatePlanner event1 = new UltimatePlanner();

event1.Add("dars", new TimeOnly(10, 30));
event1.Add("abed", new TimeOnly(10, 30));
event1.Add("uyga qaytish", new TimeOnly(18, 00));

event1.Add("Maktab boshlanadi", new DateOnly(2023, 9, 1));
event1.Add("Kanstitutsiya", new DateOnly(2023, 12, 8));
event1.Add("Yangi yil", new DateOnly(2024, 1, 1));
event1.Display();
public class Planner
{
    public Dictionary<string, TimeOnly> lst = new Dictionary<string, TimeOnly>();
    public virtual void Add(string eventName, TimeOnly time)
    {
        lst.Add(eventName, time);
    }
    public virtual void Display()
    {
        foreach(var item in lst)
        {
            Console.WriteLine(item.ToString());
        }
    }
}

public class UltimatePlanner : Planner
{
    public Dictionary<string, DateOnly> lst2 = new Dictionary<string, DateOnly>();
    public override void Add(string eventName, TimeOnly time)
    {
        var vaqt = time.Hour;
        var bilish = true;
        foreach(var item in lst.Values)
        {
            if (item.Hour == vaqt)
            {
                bilish = false;
                Console.WriteLine("You have conflict in daily plan");
                break;
            }
        }
        if (bilish == true)
        {
            lst.Add(eventName, time);
        }
    }
    public void Add(string eventNameKal, DateOnly kun)
    {
        lst2.Add(eventNameKal, kun);
    }
    public override void Display()
    {
        foreach (var item in lst2)
        {
            Console.WriteLine(item.ToString());
        }
        foreach (var item in lst)
        {
            Console.WriteLine(item.ToString());
        }
    }
}