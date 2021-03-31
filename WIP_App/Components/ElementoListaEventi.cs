using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace WIP_App.Components
{
    public class ElementoListaEventi
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Localita { get; set; }
        public string Descrizione { get; set; }
        public string Note { get; set; }
        public DateTime Data { get; set; }
        public DateTime Ora { get; set; }

    }
}