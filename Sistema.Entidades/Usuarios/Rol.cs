﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Sistema.Entidades.Usuarios
{
    public class Rol
    {
        public int idrol { get; set; }
        [Required]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "El nombre no debe tener mas de 50 caracteres ni menos de 3 ceracteres.")]
        public string nombre { get; set; }
        public string descripcion { get; set; }
        public bool condicion { get; set; }

        public ICollection<Usuario> usuarios { get; set; }

    }
}
