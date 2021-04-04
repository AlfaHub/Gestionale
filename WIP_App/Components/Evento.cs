using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace WIP_App.Components
{
    public class Evento
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Nome appuntamento obbligatorio")]
        [StringLength(30, ErrorMessage = "La lunghezza massima {1} caratteri")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Luogo appuntamento obbligatorio")]
        [StringLength(40, ErrorMessage = "La lunghezza massima {1} caratteri")]
        public string Localita { get; set; }

        public string Descrizione { get; set; }

        public string Note { get; set; }

        [DataType(DataType.Date)]
        [Required(ErrorMessage = "Il formato della data non è valido")]
        public DateTime Data { get; set; }
        
        [DataType(DataType.Time)]
        //[DataTime(ErrorMessage = "Il formato dell'ora non è valido")]
        public DateTime Ora { get; set; }
    }
}
