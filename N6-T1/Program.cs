using N6_T1;

List<Student> student = new List<Student>()
{
    new Student(){ Id = 1, FullName = "Abdulxayev Jasurbek Anvar O'g'li",  BirthDay = new DateTime(2005, 12, 12),  EduType = "DotNET", Payment = 2400000, PaymentAmount = 2000000 },
    new Student(){ Id = 2, FullName = "Abdumannonov Botirjon Davlat O'g'li",  BirthDay = new DateTime(2004, 1, 17),  EduType = "Python", Payment = 1600000, PaymentAmount = 500000 },
    new Student(){ Id = 3, FullName = "Abdurahmonov Azizbek Alisher O'g'li",  BirthDay = new DateTime(2003, 12, 12),  EduType = "DotNET", Payment = 2400000, PaymentAmount = 3000000 },
    new Student(){ Id = 4, FullName = "Anvarjonov Ozodbek Avazxon O'g'li",  BirthDay = new DateTime(2003, 11, 1),  EduType = "SMM", Payment = 1450000, PaymentAmount = 2500000 },
    new Student(){ Id = 5, FullName = "Asadov Firdavs Asqarbek O'g'li",  BirthDay = new DateTime(2006, 7, 18),  EduType = "Dizayn", Payment = 1900000, PaymentAmount = 0 },
    new Student(){ Id = 6, FullName = "Eshmurodov Umarali Abduhalim O'g'li",  BirthDay = new DateTime(2005, 12, 12),  EduType = "SMM", Payment = 1450000, PaymentAmount = 900000 },
    new Student(){ Id = 7, FullName = "Jo'raboyev Boburjon Murodjon O'g'li",  BirthDay = new DateTime(2007, 4, 12),  EduType = "Dizayn", Payment = 1900000, PaymentAmount = 2000000 },
    new Student(){ Id = 8, FullName = "Karimjonov Ilhom Ramzjon O'g'li",  BirthDay = new DateTime(2005, 8, 1),  EduType = "DotNET", Payment = 2400000, PaymentAmount = 2500000 },
    new Student(){ Id = 9, FullName = "Komiljonov Muhammadaziz Abduraximovich",  BirthDay = new DateTime(2002, 1, 12),  EduType = "Python", Payment = 1600000, PaymentAmount = 1500000 },
    new Student(){ Id = 10, FullName = "Rashidov Asadbek",  BirthDay = new DateTime(2001, 3, 12),  EduType = "Dizayn", Payment = 1900000, PaymentAmount = 1900000 },
    new Student(){ Id = 11, FullName = "Sadriddinov Abdurahmon Jurabek O'g'li",  BirthDay = new DateTime(2003, 5, 12),  EduType = "Python", Payment = 1600000, PaymentAmount = 1700000 },
    new Student(){ Id = 12, FullName = "Sattorova Habiba Shuxrat Qizi",  BirthDay = new DateTime(2006, 2, 7),  EduType = "DotNET", Payment = 2400000, PaymentAmount = 2000000 },
    new Student(){ Id = 14, FullName = "Tolibov Firdavs Odil O'g'li",  BirthDay = new DateTime(2003, 5, 6),  EduType = "DotNET", Payment = 2400000, PaymentAmount = 2700000 },
    new Student(){ Id = 15, FullName = "To'rayev Dinur Alisher O'g'li",  BirthDay = new DateTime(2002, 8, 22),  EduType = "Python", Payment = 1600000, PaymentAmount = 2000000 },
    new Student(){ Id = 16, FullName = "Vositov Muhammadrizo Muhammadtolib O'g'li",  BirthDay = new DateTime(2000, 11, 20),  EduType = "SMM", Payment = 1450000, PaymentAmount = 1400000 },
    new Student(){ Id = 17, FullName = "Xaybullayev Mexroj Mansurjonovich",  BirthDay = new DateTime(2005, 2, 12),  EduType = "Dizayn", Payment = 1900000, PaymentAmount = 2000000 },
    new Student(){ Id = 18, FullName = "Xolmuratov Qurbonali Suxrob O'g'li",  BirthDay = new DateTime(2006, 5, 9),  EduType = "DotNET", Payment = 2400000, PaymentAmount = 2400000 },
};

int[,] balls = new int[,]
{
    { 90, 100, 75, 60 },
    { 100, 100, 70, 0 },
    { 90, 50, 60, 100 },
    { 60, 50, 100, 90 },
    { 100, 10, 75, 45 },
    { 55, 85, 70, 60 },
    { 95, 90, 40, 100 },
    { 80, 100, 100, 40 },
    { 65, 80, 100, 50 },
    { 80, 90, 100, 60 },
    { 90, 85, 65, 55 },
    { 100, 55, 90, 100 },
    { 80, 75, 90, 60 },
    { 90, 90, 100, 55 },
    { 100, 60, 90, 75 },
    { 90, 80, 50, 100 },
    { 100, 100, 60, 60 },
    { 90, 50, 80, 90 },
};




while (true)
{
    Console.Write("1-Talabalar ro'yxati:\n2-To'lovlar:\n3-Baholar:\n4-Exit:\nUser >>> ");
    int tanlov = int.Parse(Console.ReadLine());
    Console.Clear();

    if (tanlov == 1 || tanlov == 2 || tanlov == 3)
    {

        switch (tanlov)
        {
            case 1:
                foreach (var item in student)
                {
                    Console.WriteLine($"{item.Id} {item.FullName.PadRight(45, ' ')}");
                }
                Console.Write("1-Talaba qo'shish:\n2-Talabani o'chirish:\nUser >>> ");
                int tanlov1 = int.Parse(Console.ReadLine());
                Console.Clear();
                switch (tanlov1)
                {
                    case 1:
                        Console.Write("FIO: ");
                        string FIO = Console.ReadLine();

                        Console.Write("O'qish yo'nalishini kiriting: ");
                        string EduType = Console.ReadLine();

                        student.Add(new Student
                        {
                            Id = student.Last().Id + 1,
                            FullName = FIO,
                            BirthDay = DateTime.Now,
                            EduType = EduType
                        });
                        Console.Clear() ;
                        Console.WriteLine("Muvaffaqiyatli qo'shildi!");
                        break;
                    case 2:
                        Console.Write("Talaba ID-sini kiriting: ");
                        int IdOchirish = int.Parse(Console.ReadLine());
                        try
                        {
                            Console.Clear();
                            for (int i = 0; i < student.Last().Id - 1; i++)
                            {
                                if (IdOchirish == student[i].Id)
                                {
                                    student.Remove(student[i]);
                                    Console.WriteLine("Muvaffaqiyatli o'chirildi!");
                                    break;
                                }
                            }

                        }
                        catch
                        {
                            Console.WriteLine("Student topilmadi");
                        }
                        break;
                }
                break;

            case 2:
                Console.Write("1-DotNET:\n2-Python:\n3-SMM:\n4-Dizayn:\nUser >>> ");
                int yonalishTanlov = int.Parse(Console.ReadLine());
                Console.Clear();

                switch (yonalishTanlov)
                {
                    case 1:
                        for (int i = 0; i < 17; i++)
                        {
                            if (student[i].EduType.ToString() == "DotNET")
                            {
                                Console.WriteLine(student[i].GetShortName() + "\t" +
                                    student[i].Payment + "\t" + student[i].GetAmount());
                            }
                        }
                        break;
                    case 2:
                        for (int i = 0; i < 17; i++)
                        {
                            if (student[i].EduType.ToString() == "Python")
                            {
                                Console.WriteLine(student[i].GetShortName() + "\t" +
                                    student[i].Payment + "\t" + student[i].GetAmount());
                            }
                        }
                        break;
                    case 3:
                        for (int i = 0; i < 17; i++)
                        {
                            if (student[i].EduType.ToString() == "SMM")
                            {
                                Console.WriteLine(student[i].GetShortName() + "\t" +
                                    student[i].Payment + "\t" + student[i].GetAmount());
                            }
                        }
                        break;
                    case 4:
                        for (int i = 0; i < 17; i++)
                        {
                            if (student[i].EduType.ToString() == "Dizayn")
                            {
                                Console.WriteLine(student[i].GetShortName() + "\t" +
                                    student[i].Payment + "\t" + student[i].GetAmount());
                            }
                        }
                        break;
                    default:
                        break;
                }
                break;

            case 3:
                var name1 = new string[3];
                for (int i = 0; i < 17; i++)
                {
                    name1 = student[i].FullName.Split(' ');
                    Console.Write(student[i].GetShortName());
                    
                    for (int j = 0; j < 4; j++)
                        Console.Write("\t" + balls[i, j] + "\t");
                Console.WriteLine();
                }
                break;
        }

    }
    else
        break;
}