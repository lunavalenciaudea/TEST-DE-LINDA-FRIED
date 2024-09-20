using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    [Table("Usuario")]
    public class Usuario
    {
        [Key]
        public int Id { get; set; }
        public string NombreUsuario { get; set; }
        public string Contraseña { get; set; }
        public int IdPersona { get; set; }
        public virtual Personas Personas { get; set; }

    }
}
