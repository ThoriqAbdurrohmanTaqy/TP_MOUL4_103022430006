using System;

namespace TP_MODUL4_103022430006
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Output Tugas Table-Driven (Daftar Kode Pos) ===");
            KodePos kPos = new KodePos();

            string[] daftarKelurahan = {
                "Batununggal", "Kujangsari", "Mengger", "Wates", "Cijaura",
                "Jatisari", "Margasari", "Sekejati", "Kebonwaru", "Maleer", "Samoja"
            };

            Console.WriteLine("{0,-15} | {1,-10}", "Kelurahan", "Kode Pos");
            Console.WriteLine("----------------------------");

            foreach (string kelurahan in daftarKelurahan)
            {
                int kodePos = kPos.getKodePos(kelurahan);
                Console.WriteLine("{0,-15} | {1,-10}", kelurahan, kodePos);
            }
            Console.WriteLine();

            Console.WriteLine("=== Output Tugas State-Based (Door Machine) ===");
            DoorMachine pintu = new DoorMachine();
            pintu.PerubahanState("BukaPintu");
            pintu.PerubahanState("KunciPintu");

            Console.WriteLine("\nTekan tombol apa saja untuk keluar...");
            Console.ReadKey();
        }
    }
}