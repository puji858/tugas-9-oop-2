using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TugasLab8.ClassAnak;
using TugasLab8.ClassInduk;

namespace TugasLab8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Tugas Lab 8 - Inheritance, Polymorphsim, Abstraction & Collection";

            // Membuat objek untuk semua karyawan

            KaryawanTetap karyawanTetap = new KaryawanTetap();
            karyawanTetap.nik = "1113-4231-3131";
            karyawanTetap.nama = "muhammad sandiko";
            karyawanTetap.GajiBulanan = 8000000;

            KaryawanHarian karyawanHarian = new KaryawanHarian();
            karyawanHarian.nik = "4242-4552-2525";
            karyawanHarian.nama = "safa lina";
            karyawanHarian.upahperJam = 200000;
            karyawanHarian.jumlahjamkerja = 9;

            Sales sales = new Sales();
            sales.nik = "5342-4242-4245";
            sales.nama = "mikhael sujarwo";
            sales.jumlahPenjualan = 50;
            sales.komisi = 50000;

            // Objek class collection
            List<Karyawan> listKaryawan = new List<Karyawan>();

            listKaryawan.Add(karyawanTetap);
            listKaryawan.Add(karyawanHarian);
            listKaryawan.Add(sales);

            int noUrut = 1;

            foreach (Karyawan karyawan in listKaryawan)
            {
                Console.WriteLine("{0}. nik: {1}, nama: {2}, Gaji: {3}", noUrut, karyawan.nik, karyawan.nama, karyawan.Gaji());

                noUrut++;
            }
			void tambahkaryawantetap(string jenis karyawan,string nik,string nama,int gajibulanan)
			{
				list.karyawan.add(new karyawantetap{jenis_karyawan = jeniskaryawan,nik = nik,nama = nama,gajibulanan = gajibulanan});
			}
			void tambahkaryawanharian(string jenis karyawan,string nik,string nama,int gajibulanan)
			{
				list.karyawan.add(new karyawanharian{jenis_karyawan = jeniskaryawan,nik = nik,nama = nama,gajibulanan = gajibulanan});
			}
			void tambahsale(string jenis karyawan,string nik,string nama,int gajibulanan)
			{
				list.karyawan.add(new sales{jenis_karyawan = jeniskaryawan,nik = nik,nama = nama,gajibulanan = gajibulanan});
			}
			void hapuskaryawan()
			{
				int no = 1;
				int jumlah_array = 0;
				
				foreach (karyawan karyawan in listkaryawan)
				{
					console.writeline("{0}.nik:{1}",no , karyawan.nik);
					
					no++;
					jumlah_array +=1;
				}
				console.writeline();
				console.write("pilih data yang ingin dihapus[1-");
				console.write(jumlah_array);
				console.write("] : ");
				int index_nik = int.parse(console.readline());
				index_nik = index_nik - 1
				listKaryawan.RemoveAt(index_nik);
                Console.WriteLine();
                Console.WriteLine("Data Karyawan Berhasil Dihapus ");
                Console.WriteLine();
                Console.WriteLine("\nTekan Enter Untuk Kembali ke Menu");
            }

            bool keluar = false;
            while (keluar == false)
            {
                Console.Title = "Tugas Lab 9 (Pertemuan 12)- Polymorphsim, Inheritance, Abstraction & Collection Part #2";
                Console.WriteLine("Pilih Menu Aplikasi :");
                Console.WriteLine();
                Console.WriteLine("1. Tambah Data Karyawan");
                Console.WriteLine("2. Hapus Data Karyawan");
                Console.WriteLine("3. Tampilkan Data Karyawan");
                Console.WriteLine("4. Keluar");
                Console.WriteLine();
                Console.Write("Nomer Menu [1..4] = ");
                int menu = int.Parse(Console.ReadLine());
                Console.Clear();
                Console.WriteLine();
                if (menu < 1)
                {
                    Console.WriteLine("Maaf, Menu Yang Anda Pilih Tidak Tersedia");
                }
                else if (menu > 4)
                {
                    Console.WriteLine("Maaf, Menu Yang Anda Pilih Tidak Tersedia");
                }
                else if (menu == 1)
                {
                    Console.WriteLine("Tambah Data Karyawan");
                    Console.WriteLine();
                    Console.Write("Jenis Karyawan [1. Karyawan Tetap, 2. Karyawan Harian, 3. Sales] : ");
                    int jk = int.Parse(Console.ReadLine());
                    Console.WriteLine();
                    if (jk == 1)
                    {
                        Console.Write("Nik = ");
                        string nik = Console.ReadLine();
                        Console.Write("Nama = ");
                        string nama = Console.ReadLine();
                        Console.Write("Gaji Bulanan = ");
                        int gb = int.Parse(Console.ReadLine());
                        string jenis = "Karyawan Tetap";

                        tambahKarywanTetap(jenis, nik, nama, gb);
                    }
                    else if (jk == 2)
                    {
                        Console.Write("Nik = ");
                        string nik = Console.ReadLine();
                        Console.Write("Nama = ");
                        string nama = Console.ReadLine();
                        Console.Write("Jumlah Jam Kerja = ");
                        int jamkerja = int.Parse(Console.ReadLine());
                        Console.Write("Upah Per Jam = ");
                        int upah = int.Parse(Console.ReadLine());
                        string jenis = "Karyawan Harian";

                        tambahKaryawanHarian(jenis, nik, nama, jamkerja, upah);
                    }
                    else if (jk == 3)
                    {

                        Console.Write("Nik = ");
                        string nik = Console.ReadLine();
                        Console.Write("Nama = ");
                        string nama = Console.ReadLine();
                        Console.Write("Jumlah Jual = ");
                        int jumlahjual = int.Parse(Console.ReadLine());
                        Console.Write("Komisi = ");
                        int komisi = int.Parse(Console.ReadLine());
                        string jenis = "Sales";

                        tambahSales(jenis, nik, nama, jumlahjual, komisi);
                    }
                    else
                    {
                        Console.WriteLine("Menu salah");
                    }
                    Console.WriteLine();
                    Console.WriteLine("\nTekan Enter Untuk Kembali ke Menu");


                }
                else if (menu == 2)
                {
                    hapusKaryawan();
                }
                else if (menu == 3)
                {
                    Console.WriteLine("Data Karyawan");
                    Console.WriteLine();
                    tampilKaryawan();

                    Console.WriteLine("\nTekan Enter Untuk Kembali ke Menu");
                }
                else if (menu == 4)
                {
                    keluar = true;
                }


            Console.ReadLine();
        }
    }
}
