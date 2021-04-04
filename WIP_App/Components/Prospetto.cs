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
        [StringLength(30, ErrorMessage = "La lunghezza massima {1} caratteri")]
        public string Cliente { get; set; }

        [StringLength(90, ErrorMessage = "La lunghezza massima {1} caratteri")]
        public string Descrizione { get; set; }

        [StringLength(200, ErrorMessage = "La lunghezza massima {1} caratteri")]
        public string Note { get; set; }

        [DataType(DataType.Date)]
        [Required(ErrorMessage = "Il formato della data non è valido")]
        public DateTime DataInizio { get; set; }

        [DataType(DataType.Date)]
        [Required(ErrorMessage = "Il formato della data non è valido")]
        public DateTime DataScadenza { get; set; }

        [DataType(DataType.Date)]
        //[MaxLength (10, ErrorMessage = "Il formato della data non è valido")]
        //[RegularExpression("^(/,[0-9]{9})$", ErrorMessage = "formato data non valido: 0000,00,00")]
        public DateTime DataFine { get; set; }

        //[DataType(double, ErrorMessage = "Inserire il prezzo in formato numerico corretto: xxx,xx")]
        public double Prezzo { get; set; }

        
        public double Variazione { get; set; }

        public Boolean Pagato { get; set; }

        public Boolean Archiviato { get; set; }
    }
}
