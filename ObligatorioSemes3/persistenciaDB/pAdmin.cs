using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ObligatirioSemes3.Dominio;
using System.Data.SqlClient;
using System.Data;

namespace persistenciaDB
{
    class pAdmin
    {
        public List<Admin> Admin_ObtenerTodos()
        {
            List<Admin> resultado = new List<Admin>();
            try
            {
                Admin admin;

                //Se crea la conexion con la base de datos mediante la clase SQLConection propia del .net framework
                //var conexionSQL = new SqlConnection(CadenadaDeConexion);
                //conexionSQL.Open();
                SqlConnection conect = Conexion.Conectar();

                //Se debe identificar el storedprocedure que creamos en la base de datos ObtenerClientes
                SqlCommand cmd = new SqlCommand("ObtAdmin", conect);

                //Se identifica el tipo de ejecución, en este caso un SP
                cmd.CommandType = CommandType.StoredProcedure;

                //Se ejecuta el Procedimiento almacenado que obtuvimos
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        admin = new Admin();
                        admin.Id = int.Parse(reader["id"].ToString());
                        admin.Nombre = reader["nombre"].ToString();
                        admin.Apellido = reader["apellido"].ToString();
                        admin.Password = reader["pass"].ToString();
                        admin.User = reader["users"].ToString();

                        resultado.Add(admin);
                    }
                }

                conect.Close();
            }
            catch (Exception ex)
            {

                throw new Exception(ex.ToString());

            }


            return resultado;

        }

        public bool AdminAlta(Admin admin)
        {
            bool resultado = false;

            try
            {
                //Se crea la conexion con la base de datos mediante la clase SQLConection propia del .net framework
                SqlConnection conect = Conexion.Conectar();

                //Se debe identificar el storedprocedure que creamos en la base de datos ObtenerClientes
                SqlCommand cmd = new SqlCommand("AltaAdmin", conect);

                //Se identifica el tipo de ejecución, en este caso un SP
                cmd.CommandType = CommandType.StoredProcedure;

                //Se agrega parámetro que espera recibir el storedProcedure

                // buscar la manera de sacar el id del sql por que es identity

                cmd.Parameters.Add(new SqlParameter("@nombre", admin.Nombre));
                cmd.Parameters.Add(new SqlParameter("@apellido", admin.Apellido));
                cmd.Parameters.Add(new SqlParameter("@password", admin.Password));
                cmd.Parameters.Add(new SqlParameter("@user", admin.User));


                //Se ejecuta el procedimiento y retorna un int (si es mayor a cero es que se ejecutó correctamente)
                int resBD = cmd.ExecuteNonQuery();

                if (resBD > 0)
                {

                    resultado = true;
                }
                if (conect.State == ConnectionState.Open)
                {
                    conect.Close();

                }

            }
            catch (Exception ex)
            {
                throw ex;
            }

            return resultado;

        }

        public Admin BuscarAdmin(int id)
        {
            Admin admin = new Admin();

            try
            {

                //Se crea la conexion con la base de datos mediante la clase SQLConection propia del .net framework
                SqlConnection conect = Conexion.Conectar();

                //Se debe identificar el storedprocedure que creamos en la base de datos ObtenerClientes
                SqlCommand cmd = new SqlCommand("BuscarAdmin", conect);

                //Se identifica el tipo de ejecución, en este caso un SP
                cmd.CommandType = CommandType.StoredProcedure;

                //Se agrega parámetro que espera recibir el storedProcedure

                cmd.Parameters.Add(new SqlParameter("@id", id));
                using (SqlDataReader reader = cmd.ExecuteReader())
                {

                    while (reader.Read())
                    {
                        admin = new Admin();
                        admin.Id = int.Parse(reader["id"].ToString());
                        admin.Nombre = reader["nombre"].ToString();
                        admin.Apellido = reader["apellido"].ToString();
                        admin.Password = reader["pass"].ToString();
                        admin.User = reader["users"].ToString();
                    }


                }

                conect.Close();



            }
            catch (Exception ex)
            {
                throw ex;
            }
            return admin;

        }


        public bool AdminBaja(int id)
        {

            try
            {

                //Se crea la conexion con la base de datos mediante la clase SQLConection propia del .net framework
                SqlConnection conect = Conexion.Conectar();

                //Se debe identificar el storedprocedure que creamos en la base de datos ObtenerClientes
                SqlCommand cmd = new SqlCommand("EliminarAdmin", conect);

                //Se identifica el tipo de ejecución, en este caso un SP
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@id", id));

                using (SqlDataReader reader = cmd.ExecuteReader())
                    while (reader.Read())
                    {

                        cmd.Parameters.Add(new SqlParameter("@id", id));

                    }

                conect.Close();

                return true;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool Admin_Mod(Admin admin)
        {
            bool resultado = false;

            try
            {
                //Se crea la conexion con la base de datos mediante la clase SQLConection propia del .net framework
                SqlConnection conect = Conexion.Conectar();

                //Se debe identificar el storedprocedure que creamos en la base de datos ObtenerClientes
                SqlCommand cmd = new SqlCommand("ModAdmin", conect);

                //Se identifica el tipo de ejecución, en este caso un SP
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@id", admin.Id));
                cmd.Parameters.Add(new SqlParameter("@nombre", admin.Nombre));
                cmd.Parameters.Add(new SqlParameter("@apellido", admin.Apellido));
    
                cmd.Parameters.Add(new SqlParameter("@user", admin.User));


                //Se ejecuta el procedimiento y retorna un int (si es mayor a cero es que se ejecutó correctamente)
                int resBD = cmd.ExecuteNonQuery();

                if (resBD > 0)
                {
                    resultado = true;
                }
                if (conect.State == ConnectionState.Open)
                {
                    conect.Close();

                }

            }
            catch (Exception ex)
            {
                throw ex;
            }

            return resultado;

        }







        public bool IniciarSesionA(string user, string pass)
        {

            bool resultado = false;

            try
            {

                //Se crea la conexion con la base de datos mediante la clase SQLConection propia del .net framework
                SqlConnection conect = Conexion.Conectar();

                //Se debe identificar el storedprocedure que creamos en la base de datos ObtenerClientes
                SqlCommand cmd = new SqlCommand("IniciarSesionA", conect);

                //Se identifica el tipo de ejecución, en este caso un SP
                cmd.CommandType = CommandType.StoredProcedure;

                //Se agrega parámetro que espera recibir el storedProcedure

                cmd.Parameters.Add(new SqlParameter("@user", user));
                cmd.Parameters.Add(new SqlParameter("@pass", pass));
                using (SqlDataReader reader = cmd.ExecuteReader())
                {

                    while (reader.Read())
                    {

                        int Id = int.Parse(reader["id"].ToString());
                        resultado = true;
                    }


                }

                conect.Close();



            }
            catch (Exception ex)
            {
                throw ex;
            }
            return resultado;
        }



        public bool IniciarSesionSA(string user, string pass)
        {

            bool resultado = false;

            try
            {

                //Se crea la conexion con la base de datos mediante la clase SQLConection propia del .net framework
                SqlConnection conect = Conexion.Conectar();

                //Se debe identificar el storedprocedure que creamos en la base de datos ObtenerClientes
                SqlCommand cmd = new SqlCommand("IniciarSesionSA", conect);

                //Se identifica el tipo de ejecución, en este caso un SP
                cmd.CommandType = CommandType.StoredProcedure;

                //Se agrega parámetro que espera recibir el storedProcedure

                cmd.Parameters.Add(new SqlParameter("@user", user));
                cmd.Parameters.Add(new SqlParameter("@pass", pass));
                using (SqlDataReader reader = cmd.ExecuteReader())
                {

                    while (reader.Read())
                    {

                        int Id = int.Parse(reader["id"].ToString());
                        resultado = true;
                    }


                }

                conect.Close();



            }
            catch (Exception ex)
            {
                throw ex;
            }
            return resultado;
        }
    }
}



