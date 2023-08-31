using N21_T1;

Developer developer = new Developer("admin", "admin", 1, "admin@gmail.com");




while (true)
{
    Console.Write("1 - Kirish:\n2 - Chiqish:\nUser >>> ");
    var choose = int.Parse(Console.ReadLine());
    Console.Clear();
    
    if (choose == 1)
    {
        Console.Write("Kirish:\nLogin: ");
        var chooseLogin = Console.ReadLine();
        Console.Clear();

        Console.Write("Password: ");
        var choosePassword = Console.ReadLine();
        Console.Clear();
        
        if (chooseLogin == "admin" && choosePassword == "admin")
        {
            Console.Write("1 - Project yaratish:\n2 - Task yaratish:\n3 - User yaratish:\n4 - Notification jo'natish:\nUser >>> ");
            var chooseInAdmin = int.Parse(Console.ReadLine());
            Console.Clear();
            
            if (chooseInAdmin == 1 || chooseInAdmin == 2 || chooseInAdmin == 3 || chooseInAdmin == 4)
            {
                switch(chooseInAdmin)
                {
                    case 1:
                        break;
                    case 2:

                        break;
                    case 3:
                        break;
                    default:
                        Console.WriteLine("Xato tanlov!");
                        break;
                }

            }
            else
            {
                Console.WriteLine("Mavjud bo'lmagan xizmatni tanladingiz!");
            }
        }
    }
    else
    {
        break;
    }
}