using System;

namespace TP_MODUL4_103022430006
{
    class Program
    {
        static void Main(string[] args)
        {
            // --- TUGAS 1: Implementasi Table-Driven (Kode Pos) ---
            Console.WriteLine("=== Output Tugas Table-Driven ===");
            KodePos kPos = new KodePos();

            // Contoh mencari kode pos kelurahan Batununggal
            string kelurahan = "Batununggal";
            int hasilKodePos = kPos.getKodePos(kelurahan);

            Console.WriteLine($"Kelurahan: {kelurahan}");
            Console.WriteLine($"Kode Pos : {hasilKodePos}");
            Console.WriteLine();

            // --- TUGAS 2: Implementasi State-Based (Door Machine) ---
            Console.WriteLine("=== Output Tugas State-Based ===");
            DoorMachine pintu = new DoorMachine(); // State awal: Terkunci

            // Simulasi perubahan state berdasarkan command
            // 1. Mencoba membuka pintu
            pintu.PerubahanState("BukaPintu");

            // 2. Mencoba mengunci pintu kembali
            pintu.PerubahanState("KunciPintu");

            // Agar console tidak langsung tertutup
            Console.WriteLine("\nTekan tombol apa saja untuk keluar...");
            Console.ReadKey();
        }
    }
}