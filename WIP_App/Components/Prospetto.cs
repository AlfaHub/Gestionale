using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace WIP_App.Components
{
    public class Prospetto
    {
        public int Id { get; set; }
        public string NomeProgetto { get; set; }
        public string Cliente { get; set; }
        public string Descrizione { get; set; }
        public string Note { get; set; }
        public DateTime DataInizio { get; set; }
        public DateTime DataScadenza { get; set; }
        public DateTime DataFine { get; set; }
        public double Prezzo { get; set; }
        public double Variazione { get; set; }
        public Boolean Pagato { get; set; }
        public Boolean Archiviato { get; set; }
    }
}
