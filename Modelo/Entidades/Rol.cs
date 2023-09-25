using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Entidades
{
    public class Rol
    {
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public bool Habilitado { get; set; }


        public override string ToString()
        {
            return Nombre;
        }

    }
}
