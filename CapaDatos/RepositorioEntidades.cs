using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Capa_Datos.Modelos;

namespace Capa_Datos
{
    public class RepositorioEntidades
    {

        public SqlConnection _conexion;
        public RepositorioEntidades(SqlConnection conexion)
        {
            _conexion = conexion;
        }

        public bool Agregar(Entidades entidad)
        {
            SqlCommand comando = new SqlCommand(@"insert into Entidades values (@descripcion, @direccion, @localidad, @tipoEntidad,
            @tipoDocumento, @numeroDocumento, @telefono, @urlPaginaWeb, @urlFacebook, @urlInstagram, @urlTwitter, @urlTikTok, @idGrupoEntidad,
            @idTipoEntidad, @limiteCredito, @userNameEntidad, @passwordEntidad, @rolUserEntidad, @comentario, @status, @noEliminable, @fechaRegistro)", _conexion);

            comando.Parameters.AddWithValue("@descripcion", entidad.Descripcion);
            comando.Parameters.AddWithValue("@direccion", entidad.Direccion);
            comando.Parameters.AddWithValue("@localidad", entidad.Localidad);
            comando.Parameters.AddWithValue("@tipoEntidad", entidad.TipoEntidad);
            comando.Parameters.AddWithValue("@tipoDocumento", entidad.TipoDocumento);
            comando.Parameters.AddWithValue("@numeroDocumento", entidad.NumeroDocumento);
            comando.Parameters.AddWithValue("@telefono", entidad.Teléfonos);
            comando.Parameters.AddWithValue("@urlPaginaWeb", entidad.URLPaginaWeb);
            comando.Parameters.AddWithValue("@urlFacebook", entidad.URLFacebook);
            comando.Parameters.AddWithValue("@urlInstagram", entidad.URLInstagram);
            comando.Parameters.AddWithValue("@urlTwitter", entidad.URLTwitter);
            comando.Parameters.AddWithValue("@urlTikTok", entidad.URLTikTok);
            comando.Parameters.AddWithValue("@idGrupoEntidad", entidad.IdGrupoEntidad);
            comando.Parameters.AddWithValue("@idTipoEntidad", entidad.IdTipoEntidad);
            comando.Parameters.AddWithValue("@limiteCredito", entidad.LimiteCredito);
            comando.Parameters.AddWithValue("@userNameEntidad", entidad.UserNameEntidad);
            comando.Parameters.AddWithValue("@passwordEntidad", entidad.PasswordEntidad);
            comando.Parameters.AddWithValue("@rolUserEntidad", entidad.RolUserEntidad);
            comando.Parameters.AddWithValue("@comentario", entidad.Comentario);
            comando.Parameters.AddWithValue("@status", entidad.Status);
            comando.Parameters.AddWithValue("@noEliminable", entidad.NoEliminable);
            comando.Parameters.AddWithValue("@fechaRegistro", entidad.FechaRegistro);

            _conexion.Close();

            return EjecutarConsulta(comando);
        }

        public bool Eliminar(int id)
        {
            SqlCommand comando = new SqlCommand("Delete Entidades where IdEntidad = @id", _conexion);

            comando.Parameters.AddWithValue("@id", id);

            return EjecutarConsulta(comando);
        }

        public bool Editar(Entidades entidad)
        {
            SqlCommand comando = new SqlCommand(@"
                Update Entidades set 
                Descripcion = @descripcion,
                Direccion = @direccion,
                Localidad = @localidad,
                TipoEntidad = @tipoEntidad,
                TipoDocumento = @tipoDocumento,
                NumeroDocumento = @numeroDocumento,
                Teléfonos = @telefono,
                URLPaginaWeb = @urlPaginaWeb,
                URLFacebook = @urlFacebook,
                URLInstagram = @urlInstagram,
                URLTwitter = @urlTwitter,
                URLTikTok = @urlTikTok,
                IdGrupoEntidad = @idGrupoEntidad,
                IdTipoEntidad = @idTipoEntidad,
                LimiteCredito = @limiteCredito,
                UserNameEntidad = @userNameEntidad,
                PassworEntidad = @passwordEntidad,
                RolUserEntidad = @rolUserEntidad, 
                Comentario = @comentario,
                Status = @status,
                
                NoEliminable = @noEliminable
                where IdEntidad = @id", _conexion);

            comando.Parameters.AddWithValue("@id", entidad.IdEntidad);
            comando.Parameters.AddWithValue("@descripcion", entidad.Descripcion);
            comando.Parameters.AddWithValue("@direccion", entidad.Direccion);
            comando.Parameters.AddWithValue("@localidad", entidad.Localidad);
            comando.Parameters.AddWithValue("@tipoEntidad", entidad.TipoEntidad);
            comando.Parameters.AddWithValue("@tipoDocumento", entidad.TipoDocumento);
            comando.Parameters.AddWithValue("@numeroDocumento", entidad.NumeroDocumento);
            comando.Parameters.AddWithValue("@telefono", entidad.Teléfonos);
            comando.Parameters.AddWithValue("@urlPaginaWeb", entidad.URLPaginaWeb);
            comando.Parameters.AddWithValue("@urlFacebook", entidad.URLFacebook);
            comando.Parameters.AddWithValue("@urlInstagram", entidad.URLInstagram);
            comando.Parameters.AddWithValue("@urlTwitter", entidad.URLTwitter);
            comando.Parameters.AddWithValue("@urlTikTok", entidad.URLTikTok);
            comando.Parameters.AddWithValue("@idGrupoEntidad", entidad.IdGrupoEntidad);
            comando.Parameters.AddWithValue("@idTipoEntidad", entidad.IdTipoEntidad);
            comando.Parameters.AddWithValue("@limiteCredito", entidad.LimiteCredito);
            comando.Parameters.AddWithValue("@userNameEntidad", entidad.UserNameEntidad);
            comando.Parameters.AddWithValue("@passwordEntidad", entidad.PasswordEntidad);
            comando.Parameters.AddWithValue("@rolUserEntidad", entidad.RolUserEntidad);
            comando.Parameters.AddWithValue("@comentario", entidad.Comentario);
            comando.Parameters.AddWithValue("@status", entidad.Status);
            comando.Parameters.AddWithValue("@noEliminable", 0);

            return EjecutarConsulta(comando);
        }

        public DataTable Listar()
        {
            SqlDataAdapter lista = new SqlDataAdapter(@"select * from Entidades", _conexion);

            return ObtenerDatos(lista);
        }

        public bool UsuarioExiste(string userName)
        {
            try
            {
                int Existe = 0;

                _conexion.Open();

                SqlCommand command = new SqlCommand("select count(UserNameEntidad) from Entidades where UserNameEntidad = @nombreUsuario", _conexion);

                command.Parameters.AddWithValue("@nombreUsuario", userName);

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Existe = reader.IsDBNull(0) ? 0 : reader.GetInt32(0);
                }

                reader.Close();
                reader.Dispose();

                _conexion.Close();

                if (Existe >= 1)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch
            {
                _conexion.Close();

                return false;
            }
        }

        public Entidades EnlistarPorId(int id)
        {
            try
            {
                _conexion.Open();

                Entidades entidad = new Entidades();

                SqlCommand sqlCommand = new SqlCommand(@"select * from Entidades where IdEntidad = @id", _conexion);

                sqlCommand.Parameters.AddWithValue("@id", id);

                SqlDataReader dataReader = sqlCommand.ExecuteReader();

                while (dataReader.Read())
                {
                    entidad.IdEntidad = dataReader.IsDBNull(0) ? 0 : dataReader.GetInt32(0);
                    entidad.Descripcion = dataReader.IsDBNull(1) ? "" : dataReader.GetString(1);
                    entidad.Direccion = dataReader.IsDBNull(2) ? "" : dataReader.GetString(2);
                    entidad.Localidad = dataReader.IsDBNull(3) ? "" : dataReader.GetString(3);
                    entidad.TipoEntidad = dataReader.IsDBNull(4) ? "" : dataReader.GetString(4);
                    entidad.TipoDocumento = dataReader.IsDBNull(5) ? "" : dataReader.GetString(5);
                    entidad.NumeroDocumento = dataReader.IsDBNull(6) ? "" : dataReader.GetString(6);
                    entidad.Teléfonos = dataReader.IsDBNull(7) ? "" : dataReader.GetString(7);
                    entidad.URLPaginaWeb = dataReader.IsDBNull(8) ? "" : dataReader.GetString(8);
                    entidad.URLFacebook = dataReader.IsDBNull(9) ? "" : dataReader.GetString(9);
                    entidad.URLInstagram = dataReader.IsDBNull(10) ? "" : dataReader.GetString(10);
                    entidad.URLTwitter = dataReader.IsDBNull(11) ? "" : dataReader.GetString(11);
                    entidad.URLTikTok = dataReader.IsDBNull(12) ? "" : dataReader.GetString(12);
                    entidad.IdGrupoEntidad = dataReader.IsDBNull(13) ? 0 : dataReader.GetInt32(13);
                    entidad.IdTipoEntidad = dataReader.IsDBNull(14) ? 0 : dataReader.GetInt32(14);
                    entidad.LimiteCredito = dataReader.IsDBNull(15) ? 0 : (int)dataReader.GetDecimal(15);
                    entidad.UserNameEntidad = dataReader.IsDBNull(16) ? "" : dataReader.GetString(16);
                    entidad.PasswordEntidad = dataReader.IsDBNull(17) ? "" : dataReader.GetString(17);
                    entidad.RolUserEntidad = dataReader.IsDBNull(18) ? "" : dataReader.GetString(18);
                    entidad.Comentario = dataReader.IsDBNull(19) ? "" : dataReader.GetString(19);
                    entidad.Status = dataReader.IsDBNull(20) ? "" : dataReader.GetString(20);
                    entidad.NoEliminable = 1;
                    entidad.FechaRegistro = dataReader.IsDBNull(22) ? DateTime.Now : dataReader.GetDateTime(22);
                }

                dataReader.Close();
                dataReader.Dispose();

                _conexion.Close();

                return entidad;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
        }

        public Entidades EnlistarPorUser(string userName)
        {
            try
            {
                _conexion.Open();

                Entidades entidad = new Entidades();

                SqlCommand sqlCommand = new SqlCommand("select IdEntidad, UserNameEntidad, PassworEntidad from Entidades where UserNameEntidad = @userName", _conexion);

                sqlCommand.Parameters.AddWithValue("@userName", userName);

                SqlDataReader dataReader = sqlCommand.ExecuteReader();

                while (dataReader.Read())
                {
                    entidad.IdEntidad = dataReader.IsDBNull(0) ? 0 : dataReader.GetInt32(0);
                    entidad.UserNameEntidad = dataReader.IsDBNull(1) ? "NULL" : dataReader.GetString(1);
                    entidad.PasswordEntidad = dataReader.IsDBNull(2) ? "NULL" : dataReader.GetString(2);
                }

                dataReader.Close();
                dataReader.Dispose();

                _conexion.Close();

                return entidad;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);

                return null;
            }
        }

        public SqlConnection conexion()
        {
            return _conexion;
        }

        private bool EjecutarConsulta(SqlCommand command)
        {
            try
            {
                _conexion.Open();
                command.ExecuteNonQuery();
                _conexion.Close();

                return true;
            }
            catch (Exception e)
            {
                _conexion.Close();
                Console.Write(e.Message);
                return false;
            }
        }

        private DataTable ObtenerDatos(SqlDataAdapter dataAdapter)
        {
            try
            {
                DataTable data = new DataTable();

                _conexion.Open();
                dataAdapter.Fill(data);
                _conexion.Close();

                return data;
            }
            catch (Exception e)
            {
                _conexion.Close();
                Console.Write(e.Message);
                return null;
            }
        }
    }
}