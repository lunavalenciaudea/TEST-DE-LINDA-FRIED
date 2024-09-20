using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    [Table("Ciudad")]
    public class Ciudad
    {
        [Key]
        public int Id { get; set; }
        public string Nombre { get; set; }
        public int IdDepartamento { get; set; }
        public virtual Departamento Departamento { get; set; }
        public virtual ICollection<Personas> Personas { get; set; }


    }
}
