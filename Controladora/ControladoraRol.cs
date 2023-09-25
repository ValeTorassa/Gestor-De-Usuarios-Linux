using Modelo.Entidades;
using Modelo.Repositorios;
using System;
using System.Collections.ObjectModel;
using System.Linq;

namespace Controladora
{
    public class ControladoraRol
    {
        private static ControladoraRol instancia;

        private ControladoraRol() { }

        public static ControladoraRol Instancia
        {
            get
            {
                if (instancia == null)
                {
                    instancia = new ControladoraRol();
                }
                return instancia;
            }
        }

        public ReadOnlyCollection<Rol> RecuperarRoles()
        {
            try
            {
                return RepositorioRol.Instancia.RecuperarRoles();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public string AgregarRol(Rol rol)
        {
            try
            {
                var listaRoles = RepositorioRol.Instancia.RecuperarRoles();
                var rolEncontrado = listaRoles.FirstOrDefault(x => x.Nombre == rol.Nombre);
                if (rolEncontrado == null)
                {
                    var ok = RepositorioRol.Instancia.Agregar(rol);
                    if (ok)
                    {
                        return $"El Rol {rol.Nombre} se agregó correctamente";
                    }
                    else
                    {
                        return $"El Rol {rol.Nombre} no se ha podido agregar";
                    }
                }
                else
                {
                    return $"El Rol {rol.Nombre} ya existe.";
                }
            }
            catch (Exception)
            {
                return "Error desconocido";
            }
        }

        public string ModificarRol(Rol rol)
        {
            try
            {
                var listaRoles = RepositorioRol.Instancia.RecuperarRoles();
                var rolEncontrado = listaRoles.FirstOrDefault(x => x.Nombre == rol.Nombre);
                if (rolEncontrado != null)
                {
                    var ok = RepositorioRol.Instancia.Modificar(rol);
                    if (ok)
                    {
                        return $"El Rol {rol.Nombre} se modificó correctamente";
                    }
                    else
                    {
                        return $"El Rol {rol.Nombre} no se ha podido modificar";
                    }
                }
                else
                {
                    return $"El Rol {rol.Nombre} no existe.";
                }
            }
            catch (Exception)
            {
                return "Error desconocido";
            }
        }

        public string EliminarRol(Rol rol)
        {
            try
            {
                var listaRoles = RepositorioRol.Instancia.RecuperarRoles();
                var rolEncontrado = listaRoles.FirstOrDefault(x => x.Nombre.ToLower() == rol.Nombre.ToLower());

                if (rolEncontrado != null)
                {
                    var ok = RepositorioRol.Instancia.Eliminar(rol);
                    if (ok)
                    {
                        return $"El Rol {rolEncontrado.Nombre} se eliminó correctamente.";
                    }
                    else
                    {
                        return $"El Rol {rolEncontrado.Nombre} no se ha podido eliminar.";
                    }
                }
                else
                {
                    return $"El Rol {rol.Nombre} no existe.";
                }
            }
            catch (Exception)
            {
                return "Error desconocido al intentar eliminar el Rol.";
            }
        }


        public bool PuedeEliminarRol(Rol rol)
        {
            try
            {
                var listaUsuarios = RepositorioUsuario.Instancia.RecuperarUsuarios();

                bool rolAsociado = listaUsuarios.Any(usuario => usuario.Roles.Any(r => r.Nombre == rol.Nombre));

                return !rolAsociado;
            }
            catch (Exception)
            {               
                return false;
            }
        }


    }
}
