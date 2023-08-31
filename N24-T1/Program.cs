//#region
//using N24_T1;
//using System.Text.Json;
////using Newtonsoft.Json;

//var result = new List<Person>
//{
//    new Person { Id = 1, Name = "Begzod", Age = 18 },
//    new Person { Id = 2, Name = "Bunyod", Age = 20 }
//};

//string path = @"D:\NT\Files\Person.txt";


//string jsonperson = JsonSerializer.Serialize(result);


//using (StreamWriter writer = new StreamWriter(path, true))
//{
//    writer.Write(jsonperson);
//}

//using (StreamReader reader = new StreamReader(path))
//{
//    var people = JsonSerializer.Deserialize<List<Person>>(reader.ReadToEnd());
//    foreach (var item in people)
//    {
//        Console.WriteLine($"Id: {item.Id}\tName: {item.Name}\tAge: {item.Age}");
//    }
//}

////foreach (var item in result)
////    Console.WriteLine($"Id: {item.Id}\tName: {item.Name}\tAge: {item.Age}");

//#endregion


using N24_T1;
using System.Text.Json;

string savePath = @"D:\NT\Files\AllCountries\AllCountries.txt";

var jsonFile = File.ReadAllText(savePath);

var result = JsonSerializer.Deserialize<List<Countries>>(jsonFile);

//foreach (var item in result)
//{
//    Console.WriteLine(item.Region); 
//}


while (true)
{
    Console.Write("1-Asia:\n2-Europe\n3-Africa\n4-Americas\n5-Oceania\n6-Exit:\nUser >>> ");
    var chooseRegion = int.Parse(Console.ReadLine());
    Console.Clear();
    if (chooseRegion == 6)
    {
        break;
    } else
    {
        switch (chooseRegion)
        {
            case 1:
                Console.WriteLine("Asia Countries: ");
                result.Where(item => item.Region == "Asia").ToList()
                    .ForEach(item => Console.WriteLine($"Country: {item.Name.Common}"));
                break;
            case 2:
                Console.WriteLine("Europe Countries: ");
                result.Where(item => item.Region == "Europe").ToList()
                    .ForEach(item => Console.WriteLine($"Country: {item.Name.Common}"));
                break;
            case 3:
                Console.WriteLine("Africa Countries: ");
                result.Where(item => item.Region == "Africa").ToList()
                    .ForEach(item => Console.WriteLine($"Country: {item.Name.Common}"));
                break;
            case 4:
                Console.WriteLine("Americas Countries: ");
                result.Where(item => item.Region == "Americas").ToList()
                    .ForEach(item => Console.WriteLine($"Country: {item.Name.Common}"));
                break;
            case 5:
                Console.WriteLine("Oceania Countries: ");
                result.Where(item => item.Region == "Oceania").ToList()
                    .ForEach(item => Console.WriteLine($"Country: {item.Name.Common}"));
                break;
        }
    }
}
