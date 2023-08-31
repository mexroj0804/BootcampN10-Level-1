using N32_T4.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace N32_T4.Services
{
    sealed class OptimizedMusicService : MusicService
    {
        private Music currentMusic;
        List<Music> musics = new()
        {
            new Music(1, "qizg'aldoq", "Y. Usmonova"),
            new Music(2, "Qirmizi", "U. Rahmatullayev"),
            new Music(3, "Tentakcham", "H. Sobirov"),
            new Music(4, "Maktabimda", "H. Sobirov"),
            new Music(5, "Yomonsan", "J. Rasul")
        };
        public OptimizedMusicService()
        {
            ChooseCurrentMusic();
        }
        public void ChooseCurrentMusic()
        {
            Random randomForCurrenMusic = new Random();
            currentMusic = musics[randomForCurrenMusic.Next(1, musics.Count)];

        }
        
        public override void Add(int id,string name, string singerName)
        {
            var result = musics.FirstOrDefault(item => item.Name == name && item.SingerName == singerName);
            if (result == null) musics.Add(new(id, name, singerName));
            else Console.WriteLine("Bunday qo'shiq va muallifi majvud!");
        }
        
        public override void DisplayCurrentSong()
        {
            Console.WriteLine($"Id: {currentMusic.Id}    Music Name: {currentMusic.Name}    Singer name: {currentMusic.SingerName}");
        }

        public override void SwitchNext()
        {
            if (!IsCurrentTheLastOne()) currentMusic = musics[currentMusic.Id + 1];
            else SwitchToFirst();
        }

        public override void SwitchPrevious()
        {
            if (!IsCurrentTheFirstOne()) SwitchToLast();
            else currentMusic = musics[currentMusic.Id - 1];

        }

        private void SwitchToFirst()
        {
            currentMusic = musics[0];
        }
        private void SwitchToLast()
        {
            currentMusic = musics[musics.Count - 1];
        }
        private bool IsCurrentTheLastOne()
        {
            if (currentMusic == musics[musics.Count - 1]) return true;
            else return false;
        }
        private bool IsCurrentTheFirstOne()
        {
            if (currentMusic == musics[0]) return true;
            else return false;
        }

    }
}
