﻿using BoletoBusMonolitic.Web.Data.Core;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BoletoBusMonolitic.Web.Data.Entites
{
    public class Usuario : BaseEntity
    {
        // atributos de la entidad 
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdUsuario { get; set; }
        public string? Nombres { get; set; }
        public string? Apellidos { get; set; }
        public string? Correo { get; set; }
        public string? Clave { get; set; }
        public string? TipoUsuario { get; set; }
        public DateTime FechaCreacion { get; set; }


    }
}
