using Microsoft.Extensions.Configuration;
using Modelo.Entidades;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.SqlClient;
using System.Linq;

namespace Modelo.Repositorios
{
    public class RepositorioUsuario
    {
        private static RepositorioUsuario instancia;
        private List<Usuario> usuarios;
        private IConfigurationRoot configuration;

        private RepositorioUsuario()
        {
            configuration = ConfigurationHelper.GetConfiguration("appsettings.json");
            usuarios = new List<Usuario>();
            ListarUsuarios();
        }

        public static RepositorioUsuario Instancia
        {
            get
            {
                if (instancia == null)
                {
                    instancia = new RepositorioUsuario();
                }

                return instancia;
            }
        }

        public ReadOnlyCollection<Usuario> RecuperarUsuarios()
        {
            try
            {
                return usuarios.AsReadOnly();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public bool Agregar(Usuario usuario)
        {
            if (AgregarUsuario(usuario))
            {
                usuarios.Add(usuario);
                return true;
            }
            return false;
        }

        private bool AgregarUsuario(Usuario usuario)
        {
            var ok = false;
            var connection = new SqlConnection(configuration.GetConnectionString("DefaultConnection"));
            connection.Open();
            var sqlTransaction = connection.BeginTransaction();

            try
            {
                using var command = new SqlCommand();

                command.CommandType = System.Data.CommandType.StoredProcedure;
                command.CommandText = "SP_AGREGARUSUARIO";
                command.Connection = connection;
                command.Transaction = sqlTransaction;

                command.Parameters.Add("@NombreDeUsuario", System.Data.SqlDbType.NVarChar, 50).Value = usuario.NombreDeUsuario;
                command.Parameters.Add("@Email", System.Data.SqlDbType.NVarChar, 255).Value = usuario.Email;
                command.Parameters.Add("@Nombre", System.Data.SqlDbType.NVarChar, 50).Value = usuario.Nombre;
                command.Parameters.Add("@Apellido", System.Data.SqlDbType.NVarChar, 50).Value = usuario.Apellido;
                command.Parameters.Add("@NombreConfiguracion", System.Data.SqlDbType.NVarChar, 20).Value = usuario.Configuracion.NombreConfiguracion;
                command.ExecuteNonQuery();

                using SqlCommand command2 = new SqlCommand();

                command2.CommandType = System.Data.CommandType.StoredProcedure;
                command2.CommandText = "SP_AGREGARROLAUSUARIO";
                command2.Connection = connection;
                command2.Transaction = sqlTransaction;

                command2.Parameters.Add("@NombreDeUsuario", System.Data.SqlDbType.NVarChar, 50).Value = usuario.NombreDeUsuario;
                command2.Parameters.Add("@NombreRol", System.Data.SqlDbType.NVarChar, 25);

                foreach (var rol in usuario.Roles)
                {
                    command2.Parameters["@NombreRol"].Value = rol.Nombre;
                    command2.ExecuteNonQuery();
                }

                command.ExecuteNonQuery();
                sqlTransaction.Commit();
                connection.Close();
                ok = true;
            }
            catch (SqlException ex)
            {
                sqlTransaction.Rollback();
                connection.Close();
                connection.Dispose();
            }
            catch (Exception ex)
            {
                sqlTransaction.Rollback();
                connection.Close();
                connection.Dispose();
            }
            return ok;
        }

        public bool Eliminar(Usuario usuario)
        {
            if (EliminarUsuario(usuario))
            {
                usuarios.Remove(usuario);
                return true;
            }
            return false;
        }

        private bool EliminarUsuario(Usuario usuario)
        {
            var ok = false;
            var connection = new SqlConnection(configuration.GetConnectionString("DefaultConnection"));
            connection.Open();
            var sqlTransaction = connection.BeginTransaction();

            try
            {
                using var command = new SqlCommand();

                command.CommandType = System.Data.CommandType.StoredProcedure;
                command.CommandText = "SP_ELIMINARUSUARIO";
                command.Connection = connection;
                command.Transaction = sqlTransaction;

                command.Parameters.Add("@NombreDeUsuario", System.Data.SqlDbType.NVarChar, 50).Value = usuario.NombreDeUsuario;

                command.ExecuteNonQuery();
                sqlTransaction.Commit();
                connection.Close();
                ok = true;
            }
            catch (SqlException ex)
            {
                sqlTransaction.Rollback();
                connection.Close();
                connection.Dispose();
            }
            catch (Exception ex)
            {
                sqlTransaction.Rollback();
                connection.Close();
                connection.Dispose();
            }
            return ok;
        }

        public bool Modificar(Usuario usuario)
        {
            if (ModificarUsuario(usuario))
            {
                var usuarioModificado = usuarios.FirstOrDefault(u => u.NombreDeUsuario == usuario.NombreDeUsuario);
                usuarioModificado.Email = usuario.Email;
                usuarioModificado.Nombre = usuario.Nombre;
                usuarioModificado.Apellido = usuario.Apellido;
                usuarioModificado.Configuracion = usuario.Configuracion;
                usuarioModificado.Roles = usuario.Roles;
                return true;
            }
            return false;
        }

        private bool ModificarUsuario(Usuario usuario)
        {
            var ok = false;
            var connection = new SqlConnection(configuration.GetConnectionString("DefaultConnection"));
            connection.Open();
            var sqlTransaction = connection.BeginTransaction();

            try
            {
                using SqlCommand command = new SqlCommand();

                command.CommandType = System.Data.CommandType.StoredProcedure;
                command.CommandText = "SP_MODIFICARUSUARIO";
                command.Connection = connection;
                command.Transaction = sqlTransaction;

                command.Parameters.Add("@NombreDeUsuario", System.Data.SqlDbType.NVarChar, 50).Value = usuario.NombreDeUsuario;
                command.Parameters.Add("@Email", System.Data.SqlDbType.NVarChar, 255).Value = usuario.Email;
                command.Parameters.Add("@Nombre", System.Data.SqlDbType.NVarChar, 50).Value = usuario.Nombre;
                command.Parameters.Add("@Apellido", System.Data.SqlDbType.NVarChar, 50).Value = usuario.Apellido;
                command.Parameters.Add("@NombreConfiguracion", System.Data.SqlDbType.NVarChar, 20).Value = usuario.Configuracion.NombreConfiguracion;

                command.ExecuteNonQuery();

                using SqlCommand command2 = new SqlCommand();

                command2.CommandType = System.Data.CommandType.StoredProcedure;
                command2.CommandText = "SP_AGREGARROLAUSUARIO";
                command2.Connection = connection;
                command2.Transaction = sqlTransaction;

                command2.Parameters.Add("@NombreDeUsuario", System.Data.SqlDbType.NVarChar, 50).Value = usuario.NombreDeUsuario;
                command2.Parameters.Add("@NombreRol", System.Data.SqlDbType.NVarChar, 25);

                foreach (var rol in usuario.Roles)
                {
                    command2.Parameters["@NombreRol"].Value = rol.Nombre;
                    command2.ExecuteNonQuery();
                }

                sqlTransaction.Commit();
                connection.Close();
                ok = true;
            }
            catch (SqlException ex)
            {
                sqlTransaction.Rollback();
                connection.Close();
                connection.Dispose();
            }
            catch (Exception ex)
            {
                sqlTransaction.Rollback();
                connection.Close();
                connection.Dispose();
            }
            return ok;
        }


        private void ListarUsuarios()
        {
            using (var connection = new SqlConnection(configuration.GetConnectionString("DefaultConnection")))

                try
                {
                    using var command = new SqlCommand();

                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    command.CommandText = "SP_RECUPERARUSUARIOS";
                    command.Connection = connection;

                    connection.Open();

                    using var reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        var usuario = new Usuario();
                        usuario.NombreDeUsuario = reader["NombreDeUsuario"].ToString();
                        usuario.Email = reader["Email"].ToString();
                        usuario.Nombre = reader["Nombre"].ToString();
                        usuario.Apellido = reader["Apellido"].ToString();
                        usuario.Configuracion = RepositorioConfiguracion.Instancia.RecuperarConfiguracion(reader["NombreConfiguracion"].ToString());

                        using var command2 = new SqlCommand();
                        command2.CommandType = System.Data.CommandType.StoredProcedure;
                        command2.CommandText = "SP_RECUPERARROLESPORUSUARIO";
                        command2.Parameters.Add("@NombreDeUsuario", System.Data.SqlDbType.NVarChar, 50).Value = usuario.NombreDeUsuario;
                        command2.Connection = connection;

                        using var reader2 = command2.ExecuteReader();
                        while (reader2.Read())
                        {
                            var Rol = new Rol();
                            Rol.Nombre = reader2["Nombre"].ToString();
                            Rol = RepositorioRol.Instancia.RecuperarRol(Rol.Nombre);

                            usuario.Roles.Add(Rol);
                        }

                        usuarios.Add(usuario);
                    }
                    connection.Close();
                }
                catch (SqlException ex)
                {
                    connection.Close();
                    connection.Dispose();
                }
                catch (Exception ex)
                {
                    connection.Close();
                    connection.Dispose();
                }
        }

    }
}
