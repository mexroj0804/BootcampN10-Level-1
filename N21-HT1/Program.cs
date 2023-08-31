//CustomList - list kolleksiyasnini implementatsiyasini yarating, bunda generics dan foydalaning

//unda konstruktorlar
//- default
//- parameterli ( int capacity ) -list hajmini oldindan belgilash uchun

//unda methodlar
//- Add ( item ) -bitta element qo'shadi - item 
//- AddRange ( items ) -bir nechta element qo'shadi
//- Contains ( item ) -bitta element bor/yo'qligini tekshiradi
//- CopyTo ( array ) -list elementlarini berilgan arrayga copy qiladi
//- IndexOf ( item ) -berilgan element listda uchrassa index qaytaradi, bo'lmasa -1
//- Insert ( index, item ) -berilgan index mavjud bo'lsa element qo'shadi, bo'lmasa exception
//- InsertRange ( index, items ) -berilgan index mavjud bo'lsa elementlarni qo'shadi bo'lmasa exception
//- Remove ( item ) -berilgan element listda uchrasa o'chiradi va true qaytaradi, bo'lmasa false
//- RemoveAt ( index ) -berilgan indexdagi elementni o'chiradi va true qaytaradi, bo'lmasa false
//- ToArray - list elementlarini array ko'rinishida qaytaradi 


using N21_HT1;

var dastur = new CustomList<int>();

dastur.Add(1);
dastur.Add(2);
dastur.Add(3);
dastur.Add(4);
dastur.Add(5);

Console.WriteLine(dastur.ToString());

Console.WriteLine(dastur.Contains(1));

var dastur2 = new int[8];

dastur.CopyTo(dastur2);

Console.WriteLine(dastur2.ToString());

dastur.AddRange(new int[] {1, 2, 3, 4, 5});

Console.WriteLine(dastur.ToString());

dastur.Insert(0, 1);
Console.WriteLine(dastur.ToString());

dastur.RemoveAt(0);
Console.WriteLine(dastur.ToString());
