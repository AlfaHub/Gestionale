﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
//using System.ComponentModel.DataAnnotations.ValidationAttribute;
using System.ComponentModel.DataAnnotations;

namespace WIP_App.Components
{
    public class Profilo
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Nome obbligatorio")]
        [StringLength(15, ErrorMessage = "La lunghezza massima {1} caratteri")]
        public string Nome { get; set; }
        [Required(ErrorMessage = "Cognome obbligatorio")]
        [StringLength(15, ErrorMessage = "La lunghezza massima {1} caratteri")]
        public string Cognome { get; set; }
        //[Required(ErrorMessage = "Azienda obbligatoria")]
        //[StringLength(30, ErrorMessage = "La lunghezza massima {1} caratteri")]
        public string Azienda { get; set; }
        //[Required(ErrorMessage = "Indirizzo obbligatorio")]
        //[StringLength(50, ErrorMessage = "La lunghezza massima {1} caratteri")]
        public string Indirizzo { get; set; }
        [Required(ErrorMessage = "Telefono obbligatorio")]
        [StringLength(30, ErrorMessage = "La lunghezza massima {1} caratteri")]
        public string Telefono { get; set; }

        [Required(ErrorMessage = "The email address is required")]
        [DataType(DataType.EmailAddress)]
        [EmailAddress(ErrorMessage = "The email address is not valid")]
        public string Email { get; set; }




        public string Note { get; set; }
    }
}
