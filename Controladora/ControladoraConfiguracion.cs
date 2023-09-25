using Modelo.Entidades;
using Modelo.Repositorios;
using System;
using System.Collections.ObjectModel;
using System.Linq;

namespace Controladora
{
    public class ControladoraConfiguracion
    {
        private static ControladoraConfiguracion instancia;

        private ControladoraConfiguracion() { }

        public static ControladoraConfiguracion Instancia
        {
            get
            {
                if (instancia == null)
                {
                    instancia = new ControladoraConfiguracion();
                }
                return instancia;
            }
        }

        public ReadOnlyCollection<Configuraciones> RecuperarConfiguraciones()
        {
            try
            {
                return RepositorioConfiguracion.Instancia.RecuperarConfiguraciones();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public string AgregarConfiguracion(Configuraciones configuracion)
        {
            try
            {
                var listaConfiguraciones = RepositorioConfiguracion.Instancia.RecuperarConfiguraciones();
                var configuracionEncontrada = listaConfiguraciones.FirstOrDefault(x => x.NombreConfiguracion == configuracion.NombreConfiguracion);
                if (configuracionEncontrada == null)
                {
                    var ok = RepositorioConfiguracion.Instancia.Agregar(configuracion);
                    if (ok)
                    {
                        return $"La configuración {configuracion.NombreConfiguracion} se agregó correctamente";
                    }
                    else
                    {
                        return $"La configuración {configuracion.NombreConfiguracion} no se ha podido agregar";
                    }
                }
                else
                {
                    return $"La configuración {configuracion.NombreConfiguracion} ya existe.";
                }
            }
            catch (Exception)
            {
                return "Error desconocido";
            }
        }

        public string ModificarConfiguracion(Configuraciones configuracion)
        {
            try
            {
                var listaConfiguraciones = RepositorioConfiguracion.Instancia.RecuperarConfiguraciones();
                var configuracionEncontrada = listaConfiguraciones.FirstOrDefault(x => x.NombreConfiguracion == configuracion.NombreConfiguracion);
                if (configuracionEncontrada != null)
                {
                    var ok = RepositorioConfiguracion.Instancia.Modificar(configuracion);
                    if (ok)
                    {
                        return $"La configuración {configuracion.NombreConfiguracion} se modificó correctamente";
                    }
                    else
                    {
                        return $"La configuración {configuracion.NombreConfiguracion} no se ha podido modificar";
                    }
                }
                else
                {
                    return $"La configuración {configuracion.NombreConfiguracion} no existe.";
                }
            }
            catch (Exception)
            {
                return "Error desconocido";
            }
        }

        public string EliminarConfiguracion(Configuraciones configuracion)
        {
            try
            {
                var listaConfiguraciones = RepositorioConfiguracion.Instancia.RecuperarConfiguraciones();
                var configuracionEncontrada = listaConfiguraciones.FirstOrDefault(x => x.NombreConfiguracion.ToLower() == configuracion.NombreConfiguracion.ToLower());

                if (configuracionEncontrada != null)
                {
                    var ok = RepositorioConfiguracion.Instancia.Eliminar(configuracion);
                    if (ok)
                    {
                        return $"La configuración {configuracionEncontrada.NombreConfiguracion} se eliminó correctamente.";
                    }
                    else
                    {
                        return $"La configuración {configuracionEncontrada.NombreConfiguracion} no se ha podido eliminar.";
                    }
                }
                else
                {
                    return $"La configuración {configuracion.NombreConfiguracion} no existe.";
                }
            }
            catch (Exception)
            {
                return "Error desconocido al intentar eliminar la configuración.";
            }
        }
    }
}
