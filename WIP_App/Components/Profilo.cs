using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WIP_App.Components
{
    public class Profilo
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Cognome { get; set; }
        public string Azienda { get; set; }
        
        //[Required(ErrorMessage = "Indirizzo obbligatorio")]
        //[StringLength(50, ErrorMessage = "La lunghezza massima {1} caratteri")]
        public string Indirizzo { get; set; }

        public string Telefono { get; set; }
        public string Email { get; set; }
        public string Note { get; set; }
    }
}
