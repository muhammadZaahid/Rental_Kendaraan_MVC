using System;
using System.Collections.Generic;

namespace UAS_20170140120_DeckyAprianto.Models
{
    public partial class Kamar
    {
        public Kamar()
        {
            ReservasiIdKamar1Navigation = new HashSet<Reservasi>();
            ReservasiIdKamarNavigation = new HashSet<Reservasi>();
        }

        public int IdKamar { get; set; }
        public string TypeKamar { get; set; }
        public string NoKamar { get; set; }
        public string Lantai { get; set; }
        public int? Biaya { get; set; }
        public string Status { get; set; }

        public ICollection<Reservasi> ReservasiIdKamar1Navigation { get; set; }
        public ICollection<Reservasi> ReservasiIdKamarNavigation { get; set; }
    }
}
