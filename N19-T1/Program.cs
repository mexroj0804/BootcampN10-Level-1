

using System.Runtime.CompilerServices;

public class Person
{
    private string _name;
    private int _age;
    private string _city;
    private string nationality = "uzbek";

    public Person()
    {       
    }

    public Person(string name, int age, string city, string nationality)
    {
        _name = name;
        _age = age;
        _city = city;
        this.nationality = nationality;
    }

    public Person(Person person)
    {
        person._name = this._name;
        person._age = this._age;
        person._city = this._city;
        person.nationality = this.nationality;
    }

    static Person()
    {
        if(null == new Person())
        {
            Console.WriteLine("Static construktor!");
        }
    }
}