//KODE = C

using System;
using System.Collections.Generic;
using System.Numerics;

public class Pelanggan
{
    private string nama;
    private string idPelanggan;
    private string tujuanWisata;

    public Pelanggan()
    {
        this.nama = nama;
        this.idPelanggan = idPelanggan;
        this.tujuanWisata = tujuanWisata;
    }

    public Pelanggan(string nama, string idPelanggan, string tujuanWisata)
    {
        this.nama = nama;
        this.idPelanggan = idPelanggan;
        this.tujuanWisata = tujuanWisata;
    }

    public string Nama
    {
        get { return nama; }
        set { nama = value; }
    }

    public string idpelanggan
    {
        get { return idPelanggan; }
        set { idPelanggan = value; }
    }

    public string tujuaanWisata
    {
        get { return tujuanWisata; }
        set { tujuanWisata = value; }
    }

    public void tampilinfo()
    {
        Console.WriteLine($"Nama : {nama}");
        Console.WriteLine($"idPelanggan : {idpelanggan}");
        Console.WriteLine($"Tujuan Wisata : {tujuanWisata}");
    }

    public class PaketStandar : Pelanggan
    {
        private int hargaPerHari;

        public PaketStandar(string nama, string idPelanggan, string tujuanWisata, int hargaPerhari) : base(nama, idPelanggan, tujuanWisata)
        {
            this.hargaPerHari = hargaPerHari;
        }

        public int HargaPerHari
        {
            get { return hargaPerHari; }
            set { hargaPerHari = value; }
        }
    }

    public class PaketPremium : Pelanggan
    {
        private int hargaPerHari;
        private int biayaFasilitas;

        public PaketPremium(string nama, string idPelanggan, string tujuanWisata, int hargaPerhari, int biayaFasilitas) : base(nama, idPelanggan, tujuanWisata)
        {
            this.hargaPerHari = hargaPerHari;
            this.biayaFasilitas = biayaFasilitas;
        }

        public int HargaPerHari
        {
            get { return hargaPerHari; }
            set
            {
                hargaPerHari = biayaFasilitas * value;
            }
        }
        public int BiayaFasilitas
        {
            get { return biayaFasilitas; }
            set { biayaFasilitas = value; }
        }
    }


    class Program
    {
        static void Main()
        {
            Pelanggan plgn = new Pelanggan();

            plgn.Nama = "Clara Melani";
            plgn.idpelanggan = "TRV203";
            plgn.tujuaanWisata = "Bali";
            Console.WriteLine("=== Data Pelanggan ===");
            Console.WriteLine($"Nama          : {plgn.Nama}");
            Console.WriteLine($"ID Pelanggan  : {plgn.idpelanggan}");
            Console.WriteLine($"Tujuan Wisata : {plgn.tujuaanWisata}");
            Console.WriteLine();
            Console.WriteLine("=== Detail Pemesanan ===");
            Console.WriteLine($"Jenis Paket   : Paket Premium");
            Console.WriteLine($"Lama Hari     : 4 Hari ");
        }

    }
}
