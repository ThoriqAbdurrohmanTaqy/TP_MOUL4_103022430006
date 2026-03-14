using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class DoorMachine
{
    // Definisi State
    public enum State { Terkunci, Terbuka };
    public State currentState;

    public DoorMachine()
    {
        // Asumsikan state awal adalah Terkunci sesuai instruksi
        currentState = State.Terkunci;
        Console.WriteLine("Pintu terkunci");
    }

    public void PerubahanState(string command)
    {
        if (currentState == State.Terkunci && command == "BukaPintu")
        {
            currentState = State.Terbuka;
            Console.WriteLine("Pintu tidak terkunci");
        }
        else if (currentState == State.Terbuka && command == "KunciPintu")
        {
            currentState = State.Terkunci;
            Console.WriteLine("Pintu terkunci");
        }
        // Jika command sama dengan state sekarang (misal BukaPintu saat sudah Terbuka), 
        // state tetap sama sesuai diagram.
    }
}
