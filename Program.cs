class Program
{
    static void Main(string[] args)
    {
        // Simulasi Tabel-Driven (Bagian C)
        KodePos kPos = new KodePos();
        string kel = "Batununggal";
        Console.WriteLine($"Kode Pos {kel}: " + kPos.getKodePos(kel));

        Console.WriteLine("--------------------------------");

        // Simulasi State-Based (Bagian E)
        DoorMachine pintu = new DoorMachine();
        pintu.PerubahanState("BukaPintu");  // Output: Pintu tidak terkunci
        pintu.PerubahanState("KunciPintu"); // Output: Pintu terkunci
    }
}