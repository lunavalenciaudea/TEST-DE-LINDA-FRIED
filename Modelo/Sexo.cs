using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    [Table("Sexo")]
    public class Sexo
    {
        [Key]
        public int Id { get; set; }
        public string Genero { get; set; }
        public virtual ICollection<Personas> Personas { get; set; }

    }
}
