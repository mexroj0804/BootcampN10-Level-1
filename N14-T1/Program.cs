//animal uchun Animal modelidan foydalaning unda FunFact methodi bo'lsin
//- FunFact methodi parametersiz shunchaki qiziqarli faktni ekranga chiqarsin
//- Animal dan 3 ta hayvon turi uchun tip yarating
//- ularda FunFact methodini e'lon qliing
//- 3 ta tipdan object e'lon qiling va 3 alasini ham Animal tipidagi o'zgaruvchida saqlang
// 3 ta objectdan FunFact methodini chaqiring

Animal animal1 = new Girafe();
Animal animal2 = new Jaguar();
Animal animal3 = new Lion();

Console.WriteLine(animal1.FunFact());
Console.WriteLine(animal2.FunFact());
Console.WriteLine(animal3.FunFact());

public class Animal
{
    public virtual string FunFact()
    {
        return "...";
    }
}

public class Girafe : Animal
{
    public override string FunFact()
    {
        return "Jirafa - eng bo'yni uzun hayvon";
    }
}

public class Jaguar : Animal
{
    public override string FunFact()
    {
        return "Jaguar - eng tez yuguradgan hayvon";
    }
}

public class Lion : Animal
{
    public override string FunFact()
    {
        return "Sher - hayvonlar qiroli!";
    }
}