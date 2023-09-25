using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Entidades
{
    public class Configuraciones
    {
        public string NombreConfiguracion { get; set; }
        public decimal Valor { get; set; }
        public string Descripcion { get; set; }
        public bool Notificaciones { get; set; }

        public override string ToString()
        {
            return NombreConfiguracion;
        }
    }
}
