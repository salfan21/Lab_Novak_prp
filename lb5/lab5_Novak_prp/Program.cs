using System;

namespace lab5_Novak_prp
{
    class Program
    {
        static void Main(string[] args)
        {
            Surgeon surgeon = new Surgeon();
            NeuroSurgeon neuroSurgeon = new NeuroSurgeon();

            surgeon.TreatPatient();
            neuroSurgeon.TreatPatient();

            Console.ReadLine();
        }
    }
}
