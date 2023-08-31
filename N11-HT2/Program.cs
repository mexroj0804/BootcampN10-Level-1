MusicPlayer musiqa1 = new MusicPlayer();
musiqa1.Add("Ona", "Ulug'bek Rahmatullayev");
musiqa1.Add("Vatan", "Ozodbek Nazarbekov");
musiqa1.Add("Qizim", "Miron Ashrapov");
musiqa1.Next();


public class Track
{
    public string Name {  get; set; }
    public string Author { get; set; }
    public Track(string name, string author)
    {
        Name = name;
        Author = author;
    }

}

public class MusicPlayer
{
    public void Add(string name, string author)
    {
        MusiqaniSaqlovchi.Add(new Track(name, author));
    }
    public List<Track> MusiqaniSaqlovchi { get; set; }
    public List<Track> MusiqaniIjroEtayotgan { get; set; }

    public void Next()
    {
        for (int i = 0; i < MusiqaniSaqlovchi.Count; i++)
        {
            for (int j = 0; j < MusiqaniIjroEtayotgan.Count; j++)
            {
                if (MusiqaniIjroEtayotgan == null)
                {
                    MusiqaniIjroEtayotgan.Add(new Track(MusiqaniSaqlovchi[0].Name, MusiqaniSaqlovchi[0].Author));
                }
                else if (MusiqaniIjroEtayotgan[j].Name == MusiqaniSaqlovchi[MusiqaniSaqlovchi.Count - 1].Name)
                {
                    MusiqaniIjroEtayotgan[j].Name = MusiqaniSaqlovchi[0].Name;
                    MusiqaniIjroEtayotgan[j].Author = MusiqaniSaqlovchi[0].Author;
                }
                else
                {
                    MusiqaniIjroEtayotgan[j].Name = MusiqaniSaqlovchi[i].Name;
                    MusiqaniIjroEtayotgan[j].Author = MusiqaniSaqlovchi[i].Author;
                }
            }
        }
    }

    public void Previous()
    {
        for (int i = 0; i < MusiqaniSaqlovchi.Count; i++)
        {
            for (int j = 0; j < MusiqaniIjroEtayotgan.Count; j++)
            {
                if (MusiqaniIjroEtayotgan[j].Name == MusiqaniSaqlovchi[0].Name)
                {
                    MusiqaniIjroEtayotgan[j].Name = MusiqaniSaqlovchi[MusiqaniSaqlovchi.Count - 1].Name;
                    MusiqaniIjroEtayotgan[j].Author = MusiqaniSaqlovchi[MusiqaniSaqlovchi.Count - 1].Author;
                }
                else
                {
                    MusiqaniIjroEtayotgan[j].Name = MusiqaniSaqlovchi[i - 1].Name;
                    MusiqaniIjroEtayotgan[j].Author = MusiqaniSaqlovchi[i - 1].Author;
                }
            }
        }
    }

    public void Pause()
    {
        foreach (var item in MusiqaniIjroEtayotgan)
            Console.WriteLine($"Paused - {item.Name}");
    }

    public void Play()
    {
        foreach (var item in MusiqaniIjroEtayotgan)
            Console.WriteLine($"Paused - {item.Name}");
    }
}

