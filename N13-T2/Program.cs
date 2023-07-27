EventManager dastur = new EventManager();
dastur.Add("Bayram", new DateOnly(2023, 7, 12));
dastur.Add("Bayram2", new DateOnly(2023, 7, 27));
dastur.Add("Bayram3", new DateOnly(2023, 7, 30));
dastur.Add("Dars", new TimeOnly(17, 30));

dastur.Display();
public class EventManager
{
    Dictionary<string, DateOnly> dictDate = new Dictionary<string, DateOnly>();
    Dictionary<string, TimeOnly> dictTime = new Dictionary<string, TimeOnly>();
    public void Add(string name, DateOnly vaqt)
    {
        dictDate.Add(name, vaqt);
    }

    public void Add(string name, TimeOnly vaqt)
    {
        dictTime.Add(name, vaqt);
    }

    public void Display()
    {
        var nowTime = DateTime.Now;
        var now = new DateOnly(nowTime.Year, nowTime.Month, nowTime.Day);

        foreach(var time in dictTime)
        {
            Console.WriteLine(time.ToString());
        }
        foreach (var data in dictDate)
        {
            if (data.Value == now.AddDays(1) 
                || data.Value == now.AddDays(2) 
                || data.Value == now.AddDays(3))
            Console.WriteLine(data.ToString());
        }
    }
}