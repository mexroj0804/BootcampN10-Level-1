using N28_HT1.Models;

var eventA = new EventStack<Event>();
eventA.Push(new Event("Maktab", new DateTime(2023, 9, 4)));
eventA.Push(new Event("Bayram", new DateTime(2023, 10, 1)));

Console.WriteLine(eventA.Peek().ToString());
Console.WriteLine(eventA.Pop().ToString());