using Microsoft.Extensions.Configuration;
using Modelo.Entidades;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.SqlClient;
using System.Linq;

namespace Modelo.Repositorios
{
    public class RepositorioRol
    {
        private static RepositorioRol instancia;
        private List<Rol> roles;
        private IConfigurationRoot configuration;

        private RepositorioRol()
        {
            configuration = ConfigurationHelper.GetConfiguration("appsettings.json");
            roles = new List<Rol>();
            ListarRoles();
        }

        public static RepositorioRol Instancia
        {
            get
            {
                if (instancia == null)
                {
                    instancia = new RepositorioRol();
                }
                return instancia;
            }
        }

        public ReadOnlyCollection<Rol> RecuperarRoles()
        {
            return roles.AsReadOnly();
        }

        public Rol RecuperarRol(string nombre)
        {
            return roles.FirstOrDefault(r => r.Nombre == nombre);
        }

        public bool Agregar(Rol rol)
        {
            if (AgregarRol(rol))
            {
                roles.Add(rol);
                return true;
            }
            return false;
        }

        private bool AgregarRol(Rol rol)
        {
            var ok = false;
            var connection = new SqlConnection(configuration.GetConnectionString("DefaultConnection"));
            connection.Open();
            var sqlTransaction = connection.BeginTransaction();
            try
            {
                using var command = new SqlCommand();

                command.CommandType = System.Data.CommandType.StoredProcedure;
                command.CommandText = "SP_AGREGARROL";
                command.Connection = connection;
                command.Transaction = sqlTransaction;
                command.Parameters.Add("@Nombre", System.Data.SqlDbType.NVarChar, 50).Value = rol.Nombre;
                command.Parameters.Add("@Descripcion", System.Data.SqlDbType.NVarChar, 255).Value = rol.Descripcion;
                command.Parameters.Add("@Habilitado", System.Data.SqlDbType.Bit).Value = rol.Habilitado;
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

        public bool Eliminar(Rol rol)
        {
            if (EliminarRol(rol))
            {
                roles.Remove(rol);
                return true;
            }
            return false;
        }

        private bool EliminarRol(Rol rol)
        {
            var ok = false;
            var connection = new SqlConnection(configuration.GetConnectionString("DefaultConnection"));
            connection.Open();
            var sqlTransaction = connection.BeginTransaction();

            try
            {
                using var command = new SqlCommand();

                command.CommandType = System.Data.CommandType.StoredProcedure;
                command.CommandText = "SP_ELIMINARROL";
                command.Connection = connection;
                command.Transaction = sqlTransaction;
                command.Parameters.Add("@Nombre", System.Data.SqlDbType.NVarChar, 50).Value = rol.Nombre;

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

        public bool Modificar(Rol rol)
        {
            if (ModificarRol(rol))
            {
                var rolModificado = roles.FirstOrDefault(r => r.Nombre == rol.Nombre);
                rolModificado.Descripcion = rol.Descripcion;
                rolModificado.Habilitado = rol.Habilitado;
                return true;
            }
            return false;
        }

        private bool ModificarRol(Rol rol)
        {
            var ok = false;
            var connection = new SqlConnection(configuration.GetConnectionString("DefaultConnection"));
            connection.Open();
            var sqlTransaction = connection.BeginTransaction();

            try
            {
                using var command = new SqlCommand();

                command.CommandType = System.Data.CommandType.StoredProcedure;
                command.CommandText = "SP_MODIFICARROL";
                command.Connection = connection;
                command.Transaction = sqlTransaction;

                command.Parameters.Add("@Nombre", System.Data.SqlDbType.NVarChar, 50).Value = rol.Nombre;
                command.Parameters.Add("@Descripcion", System.Data.SqlDbType.NVarChar, 255).Value = rol.Descripcion;
                command.Parameters.Add("@Habilitado", System.Data.SqlDbType.Bit).Value = rol.Habilitado;

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

        private void ListarRoles()
        {
            using (var connection = new SqlConnection(configuration.GetConnectionString("DefaultConnection")))

                try
                {
                    using var command = new SqlCommand();
                    command.CommandType = System.Data.CommandType.Text;
                    command.CommandText = "SP_RECUPERARROLES";
                    command.Connection = connection;
                    command.Connection.Open();
                    var reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        var rol = new Rol();
                        rol.Nombre = reader["Nombre"].ToString();
                        rol.Descripcion = reader["Descripcion"].ToString();
                        rol.Habilitado = Convert.ToBoolean(reader["Habilitado"]);
                        roles.Add(rol);
                    }
                    command.Connection.Close();
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
