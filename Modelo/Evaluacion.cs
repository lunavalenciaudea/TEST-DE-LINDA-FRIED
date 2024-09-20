using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    [Table("Evaluacion")]
    public class Evaluacion
    {
        [Key]
        public int Id { get; set; }
        public DateTime Fecha { get; set; }
        public virtual ICollection<RespuestaPregunta> RespuestasPreguntas { get; set; }
        public int IdPersona { get; set; }
        public virtual Personas Personas { get; set; } 

       

    }
}
