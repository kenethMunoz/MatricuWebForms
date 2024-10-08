using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MatricuWebForms.Models
{
    public class UsuarioModel
    {
        public int ID { get; set; }
        public string NickName { get; set; }
        public string Correo { get; set; }
        public string Contrasena { get; set; }
        public string rol { get; set; }
        public string AdicionadoPor { get; set; }
        public DateTime FechaAdicion { get; set; }
        public string ModificadoPor { get; set; }
        public DateTime FechaModificacion { get; set; }

        public UsuarioModel()
        {
            
        }


    }
}