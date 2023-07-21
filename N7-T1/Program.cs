TimeOnly startWork = new TimeOnly(7, 30);
TimeOnly endWork = new TimeOnly(19, 30);

TimeOnly[] meetings = new TimeOnly[10];
meetings[0] = new TimeOnly(10, 30);
meetings[1] = new TimeOnly(8, 23);
meetings[2] = new TimeOnly(9, 24);
meetings[3] = new TimeOnly(17, 25);
meetings[4] = new TimeOnly(11, 26);
meetings[5] = new TimeOnly(12, 27);
meetings[6] = new TimeOnly(18, 28);
meetings[7] = new TimeOnly(14, 29);
meetings[8] = new TimeOnly(15, 30);
meetings[9] = new TimeOnly(16, 31);

int[] davomiyligi = new int[10]
{
    20,
    30,
    15,
    25,
    35,
    45,
    40,
    10,
    30,
    50
};


DateTime[] metting1 = new DateTime[10];
metting1[0] = new DateTime(2023, 7, 18, 8, 20, 22);
metting1[1] = new DateTime(2023, 7, 18, 8, 20, 22);
metting1[2] = new DateTime(2023, 7, 18, 8, 20, 22);
metting1[3] = new DateTime(2023, 7, 18, 8, 20, 22);
metting1[4] = new DateTime(2023, 7, 18, 8, 20, 22);
metting1[5] = new DateTime(2023, 7, 18, 8, 20, 22); 
metting1[6] = new DateTime(2023, 7, 18, 8, 20, 22);
metting1[7] = new DateTime(2023, 7, 18, 8, 20, 22);
metting1[8] = new DateTime(2023, 7, 18, 8, 20, 22);
metting1[9] = new DateTime(2023, 7, 18, 8, 20, 22);


for  (int i = 0; i < meetings.Length; i++)
{
    Console.WriteLine($"Meeting boshlanish vaqti: { meetings[i].ToString()}. Davomiyligi: {davomiyligi[i]}");
}

Console.WriteLine("Bad meetinglar:");
for (int i = 0;i < meetings.Length; i++)
{
    if (meetings[i].Hour - 2 <= startWork.Hour || meetings[i].Hour + 2 >= endWork.Hour)
        Console.WriteLine(meetings[i].ToString());
}

Console.WriteLine("30 minutdan oshgan meetinglar:");
for (int i = 0; i < davomiyligi.Length - 1; i++)
{
    if (davomiyligi[i] >= 30)
        Console.WriteLine(davomiyligi[i]);
}

Console.WriteLine("Umumiy meetinglar vaqti: " + davomiyligi.Sum());