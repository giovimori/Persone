using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace morelli.giovanni._4h.persone.Models
{
    public enum TipoPersona { NonDefinito,ATA,Alunno,Docente};
    public class Persone
    {
        public TipoPersona Tipo { get; set; }
        public string Nome { get; set; }
        public string Cognome { get; set; }
        public string Email { get; set; }
    }

    public class ATA : Persone
    {
        public ATA() 
        {
            Tipo = TipoPersona.ATA;        
        }

        public ATA( string nomeFile ) { }
    }
}

