using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace PC1_Programacion.Models
{
    [Table("t_contactos")]
    public class Formulario
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] 
        [Column("id")]
        public int ID { get; set; }
        
        [Required(ErrorMessage="Por favor ingrese Datos")]
        [Display(Name="nombre")]
        [Column("nombre")]
        public String nombre {get;set;}

        [Required(ErrorMessage="Por favor ingrese Datos")]
        [Display(Name="apellido")]
        [Column("apellido")]
        public String apellido {get;set;}

        [Required(ErrorMessage="Por favor ingrese Datos")]
        [Display(Name="distrito")]
        [Column("distrito")]
        
        public String distrito {get;set;}
        
        [Required(ErrorMessage="Por favor ingrese Datos")]
        [Display(Name="banco")]
        [Column("banco")]
        public String banco {get;set;}

        [Required(ErrorMessage="Por favor ingrese Datos")]
        [Display(Name="edad")]
        [Column("edad")]
        public String edad {get;set;}
        
        
     [Required(ErrorMessage="Por favor ingrese Datos")]
        [Display(Name="genero")]
       [Column("genero")]
        public String genero {get;set;}
        [Required(ErrorMessage="Por favor ingrese Datos")]
        [Display(Name="autor")]
       [Column("autor")]
        public String autor {get;set;}

         [NotMapped]
         public string Respuesta{get;set;}
    }
}