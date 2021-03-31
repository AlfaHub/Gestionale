using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace WIP_App.Components
{
    public class Prospetto
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Nome progetto obbligatorio")]
        [StringLength(30, ErrorMessage = "La lunghezza massima {1} caratteri")]
        public string NomeProgetto { get; set; }
        [Required(ErrorMessage = "Cliente obbligatorio")]
        [StringLength(20, ErrorMessage = "La lunghezza massima {1} caratteri")]
        public string Cliente { get; set; }
        public string Descrizione { get; set; }
        public string Note { get; set; }
        //[Required(ErrorMessage = "Data di inizio obbligatoria")]
        public DateTime DataInizio { get; set; }
        //[Required(ErrorMessage = "Data di scadenza obbligatoria")]
        public DateTime DataScadenza { get; set; } 
        public DateTime DataFine { get; set; }
        public double Prezzo { get; set; }
        public double Variazione { get; set; }
        public Boolean Pagato { get; set; }
        public Boolean Archiviato { get; set; }
    }
}
