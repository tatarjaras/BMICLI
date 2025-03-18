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


        public double bmi()
        {
            return Math.Round(Testsuly/Math.Pow(Magassag/100.0,2),2);
        }

        public string bmiKategoria()
        {
            if (bmi() <18.5) 
            {
                return ("Sovány");
            }
            else if (bmi() <24.9)
            {
                return ("Normál testsúlyú");
            }
            else if (bmi()<29.9)
            {
                return ("Túlsúlyos");
            }
            else 
            {
                return ("Elhízott"); 
            }
        }

    }


}
