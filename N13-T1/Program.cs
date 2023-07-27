//hero class yaratish va string methodini override qilish
//gameengine class yaratish
//herolarni listga joylash
//gameengine display methodini yaratish va ekranga chiqarish
//gameenginedagi kanstruktor ichiga 3 ta hero qoshish
//optimizedgameengine servis yaratish
//undagi listga yana 3 ta hero qoshish
//optimizedgameengine dan object olib displayni chiqarish



OptimizedGameEngine Dastur = new OptimizedGameEngine();
Dastur.Display();
public class Hero
{
    public Guid Id;
    public string Name;

    public Hero(string name)
    {
        Id = Guid.NewGuid();
        Name = name;
    }

    public override string ToString()
    {
        return $"Id: {Id} {Name}";
    }
}

public class gameEngine
{
    public List<Hero> HeroList = new List<Hero>();

    public gameEngine()
    {
        HeroList.Add(new Hero("Yurnero"));
        HeroList.Add(new Hero("Sven"));
        HeroList.Add(new Hero("Tiny"));
    }

    public void Display()
    {
        for (int i = 0; i < HeroList.Count; i++)
        {
            Console.WriteLine(HeroList[i].ToString());
        }
    }
}

public class OptimizedGameEngine : gameEngine
{
    public OptimizedGameEngine()
    {
        HeroList.Add(new Hero("Invoker"));
        HeroList.Add(new Hero("Lina"));
        HeroList.Add(new Hero("Medusa"));
    }
}