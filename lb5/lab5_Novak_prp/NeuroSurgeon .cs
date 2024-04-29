using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5_Novak_prp
{
    class NeuroSurgeon : Surgeon
    {
        public void TreatPatient()
        {
            Console.WriteLine("NeuroSurgeon is performing brain surgery.");
        }
    }
}
