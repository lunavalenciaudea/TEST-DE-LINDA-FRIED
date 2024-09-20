using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Evaluacion
    {
        public int Id { get; set; }
        public DateTime Fecha { get; set; }
        public ICollection<RespuestaPregunta> RespuestasPreguntas { get; set; }
        public Persona Persona { get; set; }
    }
}
