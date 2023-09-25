using Modelo.Entidades;
using Modelo.Repositorios;
using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Collections.Generic;

namespace Controladora
{
    public class ControladoraUsuario
    {
        private static ControladoraUsuario instancia;

        private ControladoraUsuario() { }

        public static ControladoraUsuario Instancia
        {
            get
            {
                if (instancia == null)
                {
                    instancia = new ControladoraUsuario();
                }
                return instancia;
            }
        }

        public ReadOnlyCollection<Usuario> RecuperarUsuarios()
        {
            try
            {
                return RepositorioUsuario.Instancia.RecuperarUsuarios();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public string AgregarUsuario(Usuario usuario)
        {
            try
            {
                var listaUsuarios = RepositorioUsuario.Instancia.RecuperarUsuarios();
                var usuarioEncontrado = listaUsuarios.FirstOrDefault(x => x.NombreDeUsuario == usuario.NombreDeUsuario);
                if (usuarioEncontrado == null)
                {
                    var ok = RepositorioUsuario.Instancia.Agregar(usuario);
                    if (ok)
                    {
                        return $"El Usuario {usuario.NombreDeUsuario} se agregó correctamente";
                    }
                    else
                    {
                        return $"El Usuario {usuario.NombreDeUsuario} no se ha podido agregar";
                    }
                }
                else
                {
                    return $"El Usuario {usuario.NombreDeUsuario} ya existe.";
                }
            }
            catch (Exception)
            {
                return "Error desconocido";
            }
        }

        public string ModificarUsuario(Usuario usuario)
        {
            try
            {
                var listaUsuarios = RepositorioUsuario.Instancia.RecuperarUsuarios();
                var usuarioEncontrado = listaUsuarios.FirstOrDefault(x => x.NombreDeUsuario == usuario.NombreDeUsuario);
                if (usuarioEncontrado != null)
                {
                    var ok = RepositorioUsuario.Instancia.Modificar(usuario);
                    if (ok)
                    {
                        return $"El Usuario {usuario.NombreDeUsuario} se modificó correctamente";
                    }
                    else
                    {
                        return $"El Usuario {usuario.NombreDeUsuario} no se ha podido modificar";
                    }
                }
                else
                {
                    return $"El Usuario {usuario.NombreDeUsuario} no existe.";
                }
            }
            catch (Exception)
            {
                return "Error desconocido";
            }
        }

        public string EliminarUsuario(Usuario usuario)
        {
            try
            {
                var listaUsuarios = RepositorioUsuario.Instancia.RecuperarUsuarios();
                var usuarioEncontrado = listaUsuarios.FirstOrDefault(x => x.NombreDeUsuario.ToLower() == usuario.NombreDeUsuario.ToLower());

                if (usuarioEncontrado != null)
                {
                    var ok = RepositorioUsuario.Instancia.Eliminar(usuario);
                    if (ok)
                    {
                        return $"El Usuario {usuarioEncontrado.NombreDeUsuario} se eliminó correctamente.";
                    }
                    else
                    {
                        return $"El Usuario {usuarioEncontrado.NombreDeUsuario} no se ha podido eliminar.";
                    }
                }
                else
                {
                    return $"El Usuario {usuario.NombreDeUsuario} no existe.";
                }
            }
            catch (Exception)
            {
                return "Error desconocido al intentar eliminar el Usuario.";
            }
        }
    }
}
