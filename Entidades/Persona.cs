using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Entidades
{
    public class Persona
    {
        public int IdPersona { get; set; }
        public string PrimerNombre { get; set; }
        public string SegundoNombre { get; set;}
        public string PrimerApellido { get; set;}
        public string SegundoApellido { get; set; }

        public long NumeroDeDocumento { get; set;}
        public DateTime FechaNacimiento { get; set;}
        public TipoDocumento TipoDocumento { get; set; }
        public Sexo Sexo { get; set; }
        public string DireccionResidencia { get; set; }

        

    }
}
