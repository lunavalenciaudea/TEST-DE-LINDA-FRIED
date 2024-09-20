using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    [Table("Personas")]
    public class Personas
    {
        [Key]
        public int Id { get; set; }
        public string PrimerNombre { get; set; }
        public string SegundoNombre { get; set; }
        public string PrimerApellido { get; set; }
        public string SegundoApellido { get; set; }
        public int IdTipoDeDocumento { get; set; }
        public virtual TipoDeDocumento TipoDeDocumento { get; set; }
       
        public string NumeroDeDocumento { get; set; }
        public DateTime FechaDeNacimiento { get; set; }
        public int IdSexo { get; set; }
        public virtual Sexo Sexo { get; set; }
        
        public string DireccionDeResidencia { get; set; }
        public int IdCiudad { get; set; }
        public virtual Ciudad Ciudad { get; set; }
        public virtual ICollection<Usuario> Usuarios { get; set; }
        public virtual ICollection<Evaluacion> Evaluaciones { get; set; }






    }
}
