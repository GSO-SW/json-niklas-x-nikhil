 
namespace Lieferverwaltung
{
    public class Lieferung
    {
        private DateOnly datum;
        private string sendungsnummer;
        private int plz;

        public Lieferung(DateOnly datum, string sendungsnummer, int plz)
        {
            this.datum = datum;
            this.sendungsnummer = sendungsnummer;
            this.plz = plz;
        }
        
        public DateOnly Datum { get { return datum; } }
        public string Sendungsnummer { get { return sendungsnummer; } }
        public int PLZ { get { return plz; } }
    }
}