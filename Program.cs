using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectPenjualan
{
    class Program
    {
        // deklarasi objek collection untuk menampung objek penjualan
        static List<Penjualan> daftarPenjualan = new List<Penjualan>();

        static void Main(string[] args)
        {
            Console.Title = "Responsi UAS Matakuliah Pemrograman";

            while (true)
            {
                TampilMenu();

                Console.Write("\nNomor Menu [1..3]: ");
                int nomorMenu = Convert.ToInt32(Console.ReadLine());

                switch (nomorMenu)
                {
                    case 1:
                        TambahPenjualan();
                        break;

                    case 2:
                        TampilPenjualan();
                        break;

                    case 3: // keluar dari program
                        return;

                    default:
                        break;
                }
            }
        }

        static void TampilMenu()
        {
            Console.Clear();
            Console.Clear();
            Console.Title = "Responsi Pemrograman";
            Console.Write(" Pilih Menu :");
            Console.WriteLine();
            Console.Write("1.Tambah Data Penjualan");
            Console.WriteLine();
            Console.Write("2.Tampilkan Penjualan");
            Console.WriteLine();
            Console.Write("3.Keluar");
            Console.WriteLine();
            // PERINTAH: lengkapi kode untuk menampilkan menu
        }

        static void TambahPenjualan()
        {
            Console.Clear();

            // PERINTAH: lengkapi kode untuk menambahkan penjualan ke dalam collection
            Console.WriteLine("Tambah Penjualan");
            Console.Write("Nota : ");
            string nota = Console.ReadLine();
            Console.Write("Tanggal : ");
            string tanggal = Console.ReadLine();
            Console.Write("Costumer : ");
            string costumer = Console.ReadLine();
            Console.Write("Jenis [T/K] : ");
            string jenis = Console.ReadLine();
            if (jenis == "T")
            {
                jenis = "Tunai";
            }
            else
            {
                jenis = "Kredit";
            }
            Console.Write("Total Nota : ");
            double total = Convert.ToDouble(Console.ReadLine());

            daftarPenjualan.Add(new Penjualan() { Nota = nota, Tanggal = tanggal, Costumer = costumer, Jenis = jenis, Total = total });
            Console.WriteLine("\nTekan ENTER untuk kembali ke menu");
            Console.ReadKey();
        }

        static void TampilPenjualan()
        {
            Console.Clear();

            // PERINTAH: lengkapi kode untuk menampilkan daftar penjualan yang ada di dalam collection
            Console.WriteLine("Data Penjualan");
            int no = 1;
            foreach (Penjualan penjualan in daftarPenjualan)
            {
                Console.WriteLine("{0}. {1}, {2}, {3}, {4}, {5}",
                    no, penjualan.Nota, penjualan.Tanggal, penjualan.Costumer, penjualan.Jenis, penjualan.Total);
                no++;
            }
            Console.WriteLine("\nTekan enter untuk kembali ke menu");
            Console.ReadKey();
        }
    }
}