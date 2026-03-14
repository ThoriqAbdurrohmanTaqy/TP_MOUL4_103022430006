using System;

namespace TP_MODUL4_103022430006
{
    public class DoorMachine
    {
        public enum State { Terkunci, Terbuka };
        public State currentState = State.Terkunci;

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
        }
    }
}