using N32_T4.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N32_T4.Services
{
    abstract class MusicService
    {
        public abstract void SwitchNext();
        public abstract void SwitchPrevious();
        public abstract void DisplayCurrentSong();
        public abstract void Add(int id, string name, string singerName);
    }
}
