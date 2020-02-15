using System;
using System.Collections.Generic;

namespace UAS_20170140120_DeckyAprianto.Models
{
    public partial class RoomService
    {
        public RoomService()
        {
            Reservasi = new HashSet<Reservasi>();
        }

        public int IdRoomservice { get; set; }
        public string PaketService { get; set; }
        public int? HargaPerservice { get; set; }

        public ICollection<Reservasi> Reservasi { get; set; }
    }
}
