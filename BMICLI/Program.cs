using System.Reflection.Emit;

namespace BMICLI
{
    internal class Program
    {
        static List<Diak> diakok = new List<Diak>();
        static void Main(string[] args)
        {
            string filePath = "bmi.txt";
            string[] sorok = File.ReadAllLines(filePath);
            for (int i = 0; i < sorok.Length; i++)
            {
                diakok.Add(new Diak(sorok[i]));
            }

            Console.WriteLine($"3. a, feladat: A diákok száma:{diakok.Count}");
            Diak legmagasabb = diakok[0];
            foreach (var item in diakok)
            {
                if (legmagasabb.Magassag < item.Magassag) 
                {
                    legmagasabb = item;
                }
                
                

            }
            Console.WriteLine($"3. b, Feladat: A legmagasabb diák: {legmagasabb.Nev} magassága {legmagasabb.Magassag}");


            double atlag = diakok.Average(X=>X.Testsuly);
            Console.WriteLine($"5. a, Feladat: Az átlagos testsúly: {atlag:0.0} kg");
            int egeszseg = diakok.Count(x => x.bmiKategoria() == "Normál testsúlyú");
            Console.WriteLine($"5. b, Feladat: Egészséges BMI tartományba eső diákok száma: {egeszseg}");
            bool eva = diakok.Any(x =>x.Nev== "Tóth Éva");
            Console.WriteLine($"5. c, Feladat: Van-e Tóth Éva a diákok között?  {(eva? "igen":"nem")}");
        }


    }
}
