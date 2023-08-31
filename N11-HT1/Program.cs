

public class ToDo
{
    public string Vazifa { get; set; }
    public bool VazifaHolati { get; set; }

    public ToDo(string vazifa, bool vazifaHolati)
    {
        Vazifa = vazifa;
        VazifaHolati = vazifaHolati;
    }


}

public class ToDoList
{
    List<ToDo> list = new List<ToDo>();

    public void Display()
    {
        foreach (var item in list)
        {
            if (item.VazifaHolati == true)
                Console.WriteLine($"{item.Vazifa} - qilingan!");
            else
                Console.WriteLine($"{item.Vazifa} - qilinmagan!");
        }
    }

    public void MarkDone(string vazifa)
    {
        foreach(var item in list)
        {
            if(vazifa == item.Vazifa)
            {
                item.VazifaHolati = true; break;
            }
        }
    }

    public void Add(string vazifa, bool holati)
    {
        list.Add(new ToDo(vazifa, holati));
    }
}
