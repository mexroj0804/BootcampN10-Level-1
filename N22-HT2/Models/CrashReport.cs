using N22_HT2.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N22_HT2.Models
{
    internal class CrashReport : IReview
    {
        public int Id { get; set; }
        public int Star { get; set; }
        public string Massage { get; set; }
        public string Screenshot { get; set; }

        public CrashReport(int id, int star, string massage, string screenshot)
        {
            Id = id;
            Star = star;
            Massage = massage;
            Screenshot = screenshot;
        }
    }
}
