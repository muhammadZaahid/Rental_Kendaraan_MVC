using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

//import
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace UAS_20170140120_DeckyAprianto.Models
{
    public partial class UASPAWContext : IdentityDbContext
    {
        public UASPAWContext()
        {
        }

        public UASPAWContext(DbContextOptions<UASPAWContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Kamar> Kamar { get; set; }
        public virtual DbSet<Makanan> Makanan { get; set; }
        public virtual DbSet<Reservasi> Reservasi { get; set; }
        public virtual DbSet<RoomService> RoomService { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=DESKTOP-A10O2PP;Database=UASPAW;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Kamar>(entity =>
            {
                entity.HasKey(e => e.IdKamar);

                entity.Property(e => e.IdKamar).HasColumnName("ID_kamar");

                entity.Property(e => e.Lantai)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.NoKamar)
                    .HasColumnName("No_kamar")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.TypeKamar)
                    .HasColumnName("Type_kamar")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Makanan>(entity =>
            {
                entity.HasKey(e => e.IdMakanan);

                entity.Property(e => e.IdMakanan).HasColumnName("ID_makanan");

                entity.Property(e => e.HargaPermakanan).HasColumnName("Harga_permakanan");

                entity.Property(e => e.PaketMakanan)
                    .HasColumnName("Paket_makanan")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Reservasi>(entity =>
            {
                entity.HasKey(e => e.IdReservasi);

                entity.Property(e => e.IdReservasi).HasColumnName("ID_reservasi");

                entity.Property(e => e.Alamat)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.BanyakHari).HasColumnName("Banyak_hari");

                entity.Property(e => e.BanyakMakanan).HasColumnName("Banyak_Makanan");

                entity.Property(e => e.BiayaKamar).HasColumnName("Biaya_kamar");

                entity.Property(e => e.CreditCard)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.HargaMakanan).HasColumnName("Harga_makanan");

                entity.Property(e => e.HargaService).HasColumnName("Harga_service");

                entity.Property(e => e.IdKamar).HasColumnName("ID_kamar");

                entity.Property(e => e.IdKamar1).HasColumnName("ID_kamar1");

                entity.Property(e => e.IdMakanan).HasColumnName("ID_makanan");

                entity.Property(e => e.IdRoomservice).HasColumnName("ID_roomservice");

                entity.Property(e => e.JenisKelamin)
                    .HasColumnName("Jenis_Kelamin")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.JumlahTamu)
                    .HasColumnName("Jumlah_tamu")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.Lantai)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.NamaCustomer)
                    .HasColumnName("Nama_Customer")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.NoCc)
                    .HasColumnName("No_CC")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.NoHp)
                    .HasColumnName("No_hp")
                    .HasMaxLength(13)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.TanggalLahir)
                    .HasColumnName("Tanggal_lahir")
                    .HasColumnType("datetime");

                entity.Property(e => e.TglCekin)
                    .HasColumnName("Tgl_cekin")
                    .HasColumnType("datetime");

                entity.Property(e => e.TglCekout)
                    .HasColumnName("Tgl_cekout")
                    .HasColumnType("datetime");

                entity.HasOne(d => d.IdKamarNavigation)
                    .WithMany(p => p.ReservasiIdKamarNavigation)
                    .HasForeignKey(d => d.IdKamar)
                    .HasConstraintName("FK_Reservasi_Kamar");

                entity.HasOne(d => d.IdKamar1Navigation)
                    .WithMany(p => p.ReservasiIdKamar1Navigation)
                    .HasForeignKey(d => d.IdKamar1)
                    .HasConstraintName("FK_Reservasi_Kamar1");

                entity.HasOne(d => d.IdMakananNavigation)
                    .WithMany(p => p.Reservasi)
                    .HasForeignKey(d => d.IdMakanan)
                    .HasConstraintName("FK_Reservasi_Makanan");

                entity.HasOne(d => d.IdRoomserviceNavigation)
                    .WithMany(p => p.Reservasi)
                    .HasForeignKey(d => d.IdRoomservice)
                    .HasConstraintName("FK_Reservasi_Room_Service");
            });

            modelBuilder.Entity<RoomService>(entity =>
            {
                entity.HasKey(e => e.IdRoomservice);

                entity.ToTable("Room_Service");

                entity.Property(e => e.IdRoomservice).HasColumnName("ID_roomservice");

                entity.Property(e => e.HargaPerservice).HasColumnName("Harga_perservice");

                entity.Property(e => e.PaketService)
                    .HasColumnName("Paket_service")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            //masukkan ini 
            base.OnModelCreating(modelBuilder);
        }
    }
}
