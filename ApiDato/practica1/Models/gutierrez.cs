using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace practica1.Models
{
    public enum Departamentos
    {
        Santa_Cruz=1,
        Cochabamba=2,
        La_Paz=3,
        Tarija=5,
    }
    public class gutierrez
    {
        [Key]
        public int gutierrezID { get; set; }

        [Required]
        [Display(Name = "Nombre Completo")]
        [StringLength(24, MinimumLength = 2, ErrorMessage = "Ingrese nombre entre 2 a 24 caracteres")]
        public string Friendofgutierrez { get; set; }

        [Required]
        public Departamentos Place { get; set; }

        [EmailAddress(ErrorMessage ="Ingrese correo valido")]
        public string Email { get; set; }

        [DisplayFormat(DataFormatString ="{0:yyyy/MM/dd}")]
        public DateTime Birthdate { get; set; }

    }
}