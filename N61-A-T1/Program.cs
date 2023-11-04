using N61_A_T1.DTOs;
using N61_A_T1.Services;
using Sharprompt;


var service = new UserService();


while (true)
{
    var choose = Prompt.Select("Tanlang: ", new[] { "User yaratish", "Get users" });

    if (choose == "User yaratish")
    {
        var firstName = Prompt.Input<string>("Ism kiriting: ");
        var lastName = Prompt.Input<string>("Familya kiriting: ");
        var email = Prompt.Input<string>("Email kiriting: ");
        var password = Prompt.Input<string>("Password kiriting: ");
        var userName = Prompt.Input<string>("UserName kiriting: ");

        var user = new UserForCreation()
        {
            FirstName = firstName,
            LastName = lastName,
            Email = email,
            Password = password,
            UserName = userName
        };

        service.Creste(user);
    }
    else if (choose == "Get users")
    {
        var users = service.GetUsers();
        
        foreach (var user in users)
        {
            Console.WriteLine($"{user.FirstName} {user.LastName} {user.UserName} - {user.CreatedAt}");
            Prompt.Input<string>(" ");
        }
    }

    Console.Clear();
}