using N32_T1;

var objetcA = new ShortendLink(1, "a", "a");
var objectB = new ShortendLink(1, "a", "a");
var objectC = objetcA;

Console.WriteLine(objetcA.Equals(objectC));