using System;
using System.Collections.Generic;

namespace UAS_20170140120_DeckyAprianto.Models
{
    public partial class Reservasi
    {
        public int IdReservasi { get; set; }
        public string NamaCustomer { get; set; }
        public string Alamat { get; set; }
        public string NoHp { get; set; }
        public DateTime? TanggalLahir { get; set; }
        public string JenisKelamin { get; set; }
        public string JumlahTamu { get; set; }
        public DateTime? TglCekin { get; set; }
        public DateTime? TglCekout { get; set; }
        public int? Haripermalam { get; set; }
        public int? IdKamar1 { get; set; }
        public int? IdKamar { get; set; }
        public string Lantai { get; set; }
        public int? BiayaKamar { get; set; }
        public int? IdMakanan { get; set; }
        public int? BanyakMakanan { get; set; }
        public int? HargaMakanan { get; set; }
        public int? IdRoomservice { get; set; }
        public int? BanyakHari { get; set; }
        public int? HargaService { get; set; }
        public int? Total { get; set; }
        public string CreditCard { get; set; }
        public string NoCc { get; set; }
        public string Status { get; set; }

        public Kamar IdKamar1Navigation { get; set; }
        public Kamar IdKamarNavigation { get; set; }
        public Makanan IdMakananNavigation { get; set; }
        public RoomService IdRoomserviceNavigation { get; set; }
    }
}
