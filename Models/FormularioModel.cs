using System;
using System.ComponentModel.DataAnnotations;

namespace PC1_Programacion.Models
{
    [Table("t_contactos")]
    public class Formulario
    {
        [Required(ErrorMessage="Por favor ingrese Datos")]
        [Display(Name="nombre")]
        public String nombre {get;set;}

        [Required(ErrorMessage="Por favor ingrese Datos")]
        [Display(Name="apellido")]
        public String apellido {get;set;}

        [Required(ErrorMessage="Por favor ingrese Datos")]
        [Display(Name="distrito")]
        
        public String distrito {get;set;}
        
        [Required(ErrorMessage="Por favor ingrese Datos")]
        [Display(Name="banco")]
        public String banco {get;set;}

        [Required(ErrorMessage="Por favor ingrese Datos")]
        [Display(Name="edad")]
        public String edad {get;set;}
        
        public String genero {get;set;}
        [Required(ErrorMessage="Por favor ingrese Datos")]
        [Display(Name="autor")]
        public String autor {get;set;}

         [Display(Name="Output")]

         public string Respuesta{get;set;}
    }
}