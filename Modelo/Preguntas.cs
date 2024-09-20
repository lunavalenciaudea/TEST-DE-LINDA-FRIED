using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    [Table("Preguntas")]
    public class Preguntas
    {
        [Key]
        public int Id { get; set; }
        public string Nombre { get; set; }
        public virtual ICollection<RespuestaPregunta> RespuestaPregunta { get; set; }

    }
}
