using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Prueba_Web.Models
{
    [Table("Usuarios")]
    public class tbl_Usuarios
    {
        [Key]
        public int Id_usuario { get; set; }
        [Required]
        [StringLength(50)]
        public string Nombre { get; set; }
        [Required]
        [StringLength(50)]
        public string Apellido { get; set; }
        [Required]
        [StringLength(7)]
        public string Carnet { get; set; }
        [Required]
        public string Pass { get; set; }
        
        [NotMapped]
        [Required]
        [Compare(nameof(Pass), ErrorMessage ="Las contraseñas no coinciden")]
        public string ConfirmarPass { get; set; }
        public Boolean Estado { get; set; }

        //Laves foraneas
        
        public int Id_tipo_usuario { get; set; }
        
        //relaciones
        [ForeignKey("Id_tipo_usuario")]
        public tbl_Tipos_usuarios Tbl_Tipos_Usuarios { get; set; }
        public ICollection<tbl_Marcaciones> _Marcaciones { get; set; }
        public ICollection<tbl_Control_actividades> _Control_Actividades { get; set; }
        public ICollection<tbl_Permisos> _Permisos { get; set; }
    }
}
