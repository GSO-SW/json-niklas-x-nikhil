namespace Lieferverwaltung
{
    class Program
    {
        static List<Lieferung> lieferungen = new List<Lieferung>();
        static void Main(string[] args)
        {
            BeispielobjekteAnlegen();
            Console.WriteLine(lieferungen.Count);




            StreamWriter sw = new StreamWriter("Test.json");
            int anzahl = lieferungen.Count();

            sw.WriteLine("{");

            sw.WriteLine($"\t \"anzahl\": {anzahl},");
            sw.WriteLine($"\t \"lieferungen\":");

            sw.WriteLine("\t [");

            for(int i = 0; i < anzahl; i++)
            {
            sw.WriteLine("\t\t {");
            sw.WriteLine($"\t\t\t \"datum\": \"{lieferungen.ElementAt(i).Datum}\",");
            sw.WriteLine($"\t\t\t \"sendungsnummer\": \"{lieferungen.ElementAt(i).Sendungsnummer}\",");
            sw.WriteLine($"\t\t\t \"plz\": \"{Convert.ToInt32(lieferungen.ElementAt(i).PLZ)}\"");
            sw.WriteLine("\t\t }");
                if( i < anzahl-1)
                {
                    sw.Write(",");
                }
            }

            sw.WriteLine("\t ]");
            sw.WriteLine("}");

            sw.Close();
        }

        static void BeispielobjekteAnlegen()
        {
            lieferungen.Add(new Lieferung(
                new DateOnly(2024, 06,22)
                , "HHX05NNW0ZP"
                , "86309"
            ));
            
            lieferungen.Add(new Lieferung(
                new DateOnly(2024, 09, 4)
                , "GSV18EDC4BR"
                , "91139"
            ));
            
            lieferungen.Add(new Lieferung(
                new DateOnly(2023, 04, 8)
                , "CQX55KMY5RW"
                , "07708"
            ));
        }
    }
}
