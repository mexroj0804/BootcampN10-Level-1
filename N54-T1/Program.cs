

var foulderPath = @"D:\\NT\\dotNET\\BootcampN10-Level-1\\N54-T1\\test";

var dir = Directory.CreateDirectory(foulderPath);

for  (int i = 1;  i <= 3; i++)
{
    var txt = "test" + i;
    
    var dir2 = Directory.CreateDirectory($"{dir}\\{txt}");   
}

