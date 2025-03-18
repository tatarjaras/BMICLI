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
                if (legmagasabb.Magassag > item.Magassag) 
                {
                    legmagasabb = item;
                }
                
                Console.WriteLine(item.Magassag);

            }
        }
    }
}
