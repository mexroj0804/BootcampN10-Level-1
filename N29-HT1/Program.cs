List<string> usernames = new List<string>()
{
    "LEGEND",
    "GooD X BoY",
    "King_M",
    "Mexroj0804",
    "SCoRPioN"
};

var createFileTasks = usernames.Select(user => Task.Run(() =>
{
    // var name = user.Substring(0, user.IndexOf('@'));
    var fileStream = File.Create($"{user.ToLower()}.docx");
    Console.WriteLine($"{user} ga fayl yaratildi");
    return fileStream;
}));


await Task.WhenAll(createFileTasks);


