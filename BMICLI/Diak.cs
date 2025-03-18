using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMICLI
{
    public class Diak
    {
        public string? Nev { get; set; }
        public int Eletkor { get; set; }
        public int Magassag { get; set; }
        public int Testsuly { get; set; }

        public Diak(string sor) 
        {
            string[] bontas = sor.Split(';');
            Nev = bontas[0];
            Eletkor = int.Parse(bontas[1]);
            Magassag = int.Parse(bontas[2]);
            Testsuly = int.Parse(bontas[3]);
        }

    }
}
