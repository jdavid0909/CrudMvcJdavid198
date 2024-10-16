using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CapaEntidad;
using System.Data.SqlClient;
using System.Data;
using System.Security.Claims;

namespace CapaDatos
{
    public class CD_Usuarios
    {
        public List<Usuario> Listar()
        {
            List<Usuario> listaUSuario=  new List<Usuario>();
            try
            {
                using (SqlConnection connection = new SqlConnection(Conexion.cn))
                {

                    string query = "select IdUsuario, nombres,apellidos, Correo, clave,Restablecer, Activo from usuario";
                    SqlCommand cmd = new SqlCommand(query, connection);
                    cmd.CommandType = CommandType.Text;
                    connection.Open();
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read()) { 
                            listaUSuario.Add(new Usuario()
                            { 
                                idUsuario = Convert.ToInt32(dr["IdUsuario"]),
                                nombres = dr["nombres"].ToString(),
                                apellidos = dr["apellidos"].ToString(),
                                correo = dr["Correo"].ToString(),
                                clave = dr["clave"].ToString(),
                                Reestablecer = Convert.ToBoolean(dr["Restablecer"]),
                                activo = Convert.ToBoolean(dr["Activo"]),

                            });
                        
                        }
                    }
                }
            }
            catch (Exception ex)
            {

                listaUSuario = new List<Usuario>();

            }

            return listaUSuario;
        }

        public void SaveUser(Usuario usuario)
        {

            try
            {

                using (SqlConnection connection = new SqlConnection(Conexion.cn))
                {
                    string sql = $"Insert Into Usuario(nombres, Apellidos,correo) Values('{usuario.nombres}', '{usuario.apellidos}', '{usuario.correo}')";

                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.CommandType = CommandType.Text;

                        connection.Open();
                        command.ExecuteNonQuery();
                        connection.Close();
                    }
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine("error al ejecutar sentencia sql");
            }


        }

        public void EditUser(Usuario usuario, int id)
        {

            try
            {
            
                using (SqlConnection connection = new SqlConnection(Conexion.cn))
                {
                    string sql = $"Update USUARIO SET nombres='{usuario.nombres}', apellidos='{usuario.apellidos}', correo='{usuario.correo}' Where idUsuario='{id}'";
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        connection.Open();
                        command.ExecuteNonQuery();
                        connection.Close();
                    }
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine("error al ejecutar sentencia sql");
            }


        }

        public void DeleteUser(int id)
            {

                try
                {
                    using (SqlConnection connection = new SqlConnection(Conexion.cn))
                    {
                        string sql = $"Delete From USUARIO Where IdUsuario='{id}'";
                        using (SqlCommand command = new SqlCommand(sql, connection))
                        {
                            connection.Open();
                 
                            command.ExecuteNonQuery();
              
                            connection.Close();
                        }
                    }

                }
                catch (Exception ex)
                {
                    Console.WriteLine("error al ejecutar sentencia sql");
                }


            }


        public Usuario EditUser(int id)
        {

            Usuario usuario = new Usuario();

            try
            {
            
                using (SqlConnection connection = new SqlConnection(Conexion.cn))
                {
                    string sql = $"Select IdUsuario, nombres,apellidos, Correo, clave,Restablecer, Activo From USUARIO Where IdUsuario='{id}'";
                    SqlCommand command = new SqlCommand(sql, connection);

                    connection.Open();

                    using (SqlDataReader dr = command.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            usuario.idUsuario = Convert.ToInt32(dr["IdUsuario"]);
                            usuario.nombres = dr["nombres"].ToString();
                            usuario.apellidos = dr["apellidos"].ToString();
                            usuario.correo = dr["Correo"].ToString();
                            usuario.clave = dr["clave"].ToString();
                            usuario.Reestablecer = Convert.ToBoolean(dr["Restablecer"]);
                            usuario.activo = Convert.ToBoolean(dr["Activo"]);

                        }
                    }
                    connection.Close();
                }

               
            }
            catch (Exception ex)
            {
                Console.WriteLine("error al ejecutar sentencia sql");
            }

            return usuario;


        }
    }


    

}


    

