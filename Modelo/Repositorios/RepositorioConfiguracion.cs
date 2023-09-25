using Microsoft.Extensions.Configuration;
using Modelo.Entidades;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.SqlClient;
using System.Linq;

namespace Modelo.Repositorios
{
    public class RepositorioConfiguracion
    {
        private static RepositorioConfiguracion instancia;
        private List<Configuraciones> configuraciones;
        private IConfigurationRoot configuration;

        private RepositorioConfiguracion()
        {
            configuration = ConfigurationHelper.GetConfiguration("appsettings.json");
            configuraciones = new List<Configuraciones>();
            ListarConfiguraciones();
        }

        public static RepositorioConfiguracion Instancia
        {
            get
            {
                if (instancia == null)
                {
                    instancia = new RepositorioConfiguracion();
                }
                return instancia;
            }
        }

        public ReadOnlyCollection<Configuraciones> RecuperarConfiguraciones()
        {
            return configuraciones.AsReadOnly();
        }

        public Configuraciones RecuperarConfiguracion(string nombreConfiguracion)
        {
            return configuraciones.FirstOrDefault(c => c.NombreConfiguracion == nombreConfiguracion);
        }

        public bool Agregar(Configuraciones configuracion)
        {
            if (AgregarConfiguracion(configuracion))
            {
                configuraciones.Add(configuracion);
                return true;
            }
            return false;
        }

        private bool AgregarConfiguracion(Configuraciones configuracion)
        {
            var ok = false;
            var connection = new SqlConnection(configuration.GetConnectionString("DefaultConnection"));
            connection.Open();
            var sqlTransaction = connection.BeginTransaction();
            try
            {
                using var command = new SqlCommand();

                command.CommandType = System.Data.CommandType.StoredProcedure;
                command.CommandText = "SP_AGREGARCONFIGURACION";
                command.Connection = connection;
                command.Transaction = sqlTransaction;
                command.Parameters.Add("@NombreConfiguracion", System.Data.SqlDbType.NVarChar, 50).Value = configuracion.NombreConfiguracion;
                command.Parameters.Add("@Valor", System.Data.SqlDbType.Decimal, 18).Value = configuracion.Valor;
                command.Parameters.Add("@Descripcion", System.Data.SqlDbType.NVarChar, 255).Value = configuracion.Descripcion;
                command.Parameters.Add("@Notificaciones", System.Data.SqlDbType.Bit).Value = configuracion.Notificaciones;

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

        public bool Eliminar(Configuraciones configuracion)
        {
            if (EliminarConfiguracion(configuracion))
            {
                configuraciones.Remove(configuracion);
                return true;
            }
            return false;
        }

        private bool EliminarConfiguracion(Configuraciones configuracion)
        {
            var ok = false;
            var connection = new SqlConnection(configuration.GetConnectionString("DefaultConnection"));
            connection.Open();
            var sqlTransaction = connection.BeginTransaction();

            try
            {
                using var command = new SqlCommand();

                command.CommandType = System.Data.CommandType.StoredProcedure;
                command.CommandText = "SP_ELIMINARCONFIGURACION";
                command.Connection = connection;
                command.Transaction = sqlTransaction;
                command.Parameters.Add("@NombreConfiguracion", System.Data.SqlDbType.NVarChar, 50).Value = configuracion.NombreConfiguracion;

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

        public bool Modificar(Configuraciones configuracion)
        {
            if (ModificarConfiguracion(configuracion))
            {
                var configuracionModificada = configuraciones.FirstOrDefault(c => c.NombreConfiguracion == configuracion.NombreConfiguracion);
                configuracionModificada.Valor = configuracion.Valor;
                configuracionModificada.Descripcion = configuracion.Descripcion;
                configuracionModificada.Notificaciones = configuracion.Notificaciones;
                return true;
            }
            return false;
        }

        private bool ModificarConfiguracion(Configuraciones configuracion)
        {
            var ok = false;
            var connection = new SqlConnection(configuration.GetConnectionString("DefaultConnection"));
            connection.Open();
            var sqlTransaction = connection.BeginTransaction();

            try
            {
                using var command = new SqlCommand();

                command.CommandType = System.Data.CommandType.StoredProcedure;
                command.CommandText = "SP_MODIFICARCONFIGURACION";
                command.Connection = connection;
                command.Transaction = sqlTransaction;

                command.Parameters.Add("@NombreConfiguracion", System.Data.SqlDbType.NVarChar, 50).Value = configuracion.NombreConfiguracion;
                command.Parameters.Add("@Valor", System.Data.SqlDbType.Decimal, 18).Value = configuracion.Valor;
                command.Parameters.Add("@Descripcion", System.Data.SqlDbType.NVarChar, 255).Value = configuracion.Descripcion;
                command.Parameters.Add("@Notificaciones", System.Data.SqlDbType.Bit).Value = configuracion.Notificaciones;

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

        private void ListarConfiguraciones()
        {
            using (var connection = new SqlConnection(configuration.GetConnectionString("DefaultConnection")))

                try
                {
                    using var command = new SqlCommand();
                    command.CommandType = System.Data.CommandType.Text;
                    command.CommandText = "SP_RECUPERARCONFIGURACIONES";
                    command.Connection = connection;
                    command.Connection.Open();
                    var reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        var configuracion = new Configuraciones();
                        configuracion.NombreConfiguracion = reader["NombreConfiguracion"].ToString();
                        configuracion.Valor = Convert.ToDecimal(reader["Valor"]);
                        configuracion.Descripcion = reader["Descripcion"].ToString();
                        configuracion.Notificaciones = Convert.ToBoolean(reader["Notificaciones"]);
                        configuraciones.Add(configuracion);
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
