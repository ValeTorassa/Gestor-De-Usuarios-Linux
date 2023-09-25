using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Entidades
{
    public class Usuario
    {
        public string NombreDeUsuario { get; set; }
        public string Email { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public List<Rol> Roles { get; set; }
        public Configuraciones Configuracion { get; set; }

        public Usuario() 
        {
            Roles = new List<Rol>();
        }
    }
}
