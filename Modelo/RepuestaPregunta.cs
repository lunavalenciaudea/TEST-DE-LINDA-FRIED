using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    [Table("RespuestasPregunta")]
    public class RespuestaPregunta
    {
        [Key]
        public int Id { get; set; }
        public int IdPregunta { get; set; }
        public virtual Preguntas Preguntas { get; set; }
        public bool Respuesta { get; set; }
        public int IdEvaluacion { get; set; }
        public virtual Evaluacion Evaluacion { get; set; }

    }
}
