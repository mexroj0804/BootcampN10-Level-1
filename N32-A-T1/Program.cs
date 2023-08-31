


using N32_A_T1.Service;
using System.Text.Json;

var filePathStudent = @"D:\NT\Files\Project_N32\Student.json";
var filePathLocation = @"D:\NT\Files\Project_N32\Location.json";
var filePathSpeciallity = @"D:\NT\Files\Project_N32\Speciality.json";

//List<Student> students = new();


var students = JsonSerializer.Deserialize<List<Student>>(File.ReadAllText(filePathStudent));
var locations = JsonSerializer.Deserialize<List<Location>>(File.ReadAllText(filePathLocation));
var speciallties = JsonSerializer.Deserialize<List<Speciallity>>(File.ReadAllText(filePathSpeciallity));

var result = speciallties.GroupJoin(students,
    s => s.id,
    x => x.speciality_id,
    (speciallties, students) => new
    {
        Speiciality = speciallties,
        Students = students
    });

var result2 = locations.GroupJoin(students,
    x => x.id,
    y => y.location_id,
    (locations, students) => new
    {
        locations = locations,
        Students = students
    });





//Console.WriteLine(JsonSerializer.Serialize(result));
Console.WriteLine(JsonSerializer.Serialize(result2));

