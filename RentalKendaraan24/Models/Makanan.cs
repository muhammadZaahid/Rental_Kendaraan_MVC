using System;
using System.Collections.Generic;

namespace UAS_20170140120_DeckyAprianto.Models
{
    public partial class Makanan
    {
        public Makanan()
        {
            Reservasi = new HashSet<Reservasi>();
        }

        public int IdMakanan { get; set; }
        public string PaketMakanan { get; set; }
        public int? HargaPermakanan { get; set; }

        public ICollection<Reservasi> Reservasi { get; set; }
    }
}
