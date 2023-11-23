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
    public class pCliente
    {

        public List<Cliente> Cliente_ObtenerTodos()
        {
            List<Cliente> resultado = new List<Cliente>();
            try
            {
                Cliente cliente;

                //Se crea la conexion con la base de datos mediante la clase SQLConection propia del .net framework
                //var conexionSQL = new SqlConnection(CadenadaDeConexion);
                //conexionSQL.Open();
                SqlConnection conect = Conexion.Conectar();

                //Se debe identificar el storedprocedure que creamos en la base de datos ObtenerClientes
                SqlCommand cmd = new SqlCommand("ObtCliente", conect);

                //Se identifica el tipo de ejecución, en este caso un SP
                cmd.CommandType = CommandType.StoredProcedure;

                //Se ejecuta el Procedimiento almacenado que obtuvimos
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        cliente = new Cliente();
                        cliente.Id = int.Parse(reader["id"].ToString());
                        cliente.Nombre = reader["nombre"].ToString();
                        cliente.Apellido = reader["apellido"].ToString();
                        cliente.Password = reader["pass"].ToString();
                        cliente.User = reader["users"].ToString();
                        cliente.Ci = int.Parse(reader["ci"].ToString());
                        cliente.Tel = int.Parse(reader["tel"].ToString());
                        cliente.Dir = reader["dir"].ToString();
                        cliente.Mail = reader["mail"].ToString();
                        cliente.FchRegistro = reader["fchregistro"].ToString();
                        resultado.Add(cliente);
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

        public bool Cliente_Alta(Cliente pCliente)
        {
            bool resultado = false;

            try
            {
                //Se crea la conexion con la base de datos mediante la clase SQLConection propia del .net framework
                SqlConnection conect = Conexion.Conectar();

                //Se debe identificar el storedprocedure que creamos en la base de datos ObtenerClientes
                SqlCommand cmd = new SqlCommand("AltaCliente", conect);

                //Se identifica el tipo de ejecución, en este caso un SP
                cmd.CommandType = CommandType.StoredProcedure;

                //Se agrega parámetro que espera recibir el storedProcedure

                // buscar la manera de sacar el id del sql por que es identity

                cmd.Parameters.Add(new SqlParameter("@nombre", pCliente.Nombre));
                cmd.Parameters.Add(new SqlParameter("@apellido", pCliente.Apellido));
                cmd.Parameters.Add(new SqlParameter("@password", pCliente.Password));
                cmd.Parameters.Add(new SqlParameter("@user", pCliente.User));
                cmd.Parameters.Add(new SqlParameter("@ci", pCliente.Ci));
                cmd.Parameters.Add(new SqlParameter("@tel", pCliente.Tel));
                cmd.Parameters.Add(new SqlParameter("@dir", pCliente.Dir));
                cmd.Parameters.Add(new SqlParameter("@mail", pCliente.Mail));
        

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

        public Cliente BuscarCli(int id)
        {
            Cliente cliente = new Cliente();

            try
            {

                //Se crea la conexion con la base de datos mediante la clase SQLConection propia del .net framework
                SqlConnection conect = Conexion.Conectar();

                //Se debe identificar el storedprocedure que creamos en la base de datos ObtenerClientes
                SqlCommand cmd = new SqlCommand("BuscarCli", conect);

                //Se identifica el tipo de ejecución, en este caso un SP
                cmd.CommandType = CommandType.StoredProcedure;

                //Se agrega parámetro que espera recibir el storedProcedure

                cmd.Parameters.Add(new SqlParameter("@id", id));
                using (SqlDataReader reader = cmd.ExecuteReader())
                {

                    while (reader.Read())
                    {
                        int Id = int.Parse(reader["id"].ToString());
                        string Nombre = reader["nombre"].ToString();
                        string Apellido = reader["apellido"].ToString();
                        string Password = reader["pass"].ToString();
                        string User = reader["users"].ToString();
                        int Ci = int.Parse(reader["ci"].ToString());
                        int Tel = int.Parse(reader["tel"].ToString());
                        string Dir = reader["dir"].ToString();
                        string Mail = reader["mail"].ToString();
                        string FchRegistro = reader["fchregistro"].ToString();
                        Cliente resultado = new Cliente(Id, Nombre, Apellido, Password, User, Ci, Tel, Dir, Mail, FchRegistro);
                        cliente = resultado;
                    }


                }

                conect.Close();



            }
            catch (Exception ex)
            {
                throw ex;
            }
            return cliente;

        }

        public int InicioSesion(string user, string pass)
        {
            Cliente cliente = new Cliente();



            //Se crea la conexion con la base de datos mediante la clase SQLConection propia del .net framework
            SqlConnection conect = Conexion.Conectar();

            //Se debe identificar el storedprocedure que creamos en la base de datos ObtenerClientes
            SqlCommand cmd = new SqlCommand("IniciarSesion", conect);

            //Se identifica el tipo de ejecución, en este caso un SP
            cmd.CommandType = CommandType.StoredProcedure;

            //Se agrega parámetro que espera recibir el storedProcedure

            cmd.Parameters.Add(new SqlParameter("@user", user));
            cmd.Parameters.Add(new SqlParameter("@pass", pass));

            using (SqlDataReader reader = cmd.ExecuteReader())
            {

                while (reader.Read())
                {
                    cliente.Id = int.Parse(reader["id"].ToString());
                    return cliente.Id;

                }


            }

            conect.Close();





            cliente.Id = 0;



            return cliente.Id;
        }


        public bool CambiarPass(int id , string pass)
        {
            bool resultado = false;

            try
            {
                //Se crea la conexion con la base de datos mediante la clase SQLConection propia del .net framework
                SqlConnection conect = Conexion.Conectar();

                //Se debe identificar el storedprocedure que creamos en la base de datos ObtenerClientes
                SqlCommand cmd = new SqlCommand("CambiarPass2", conect);

                //Se identifica el tipo de ejecución, en este caso un SP
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add(new SqlParameter("@Id", id));
        
                cmd.Parameters.Add(new SqlParameter("@pass", pass));

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

        public bool Cliente_Baja(int id)
        {

            try
            {

                //Se crea la conexion con la base de datos mediante la clase SQLConection propia del .net framework
                SqlConnection conect = Conexion.Conectar();

                //Se debe identificar el storedprocedure que creamos en la base de datos ObtenerClientes
                SqlCommand cmd = new SqlCommand("EliminarCli", conect);

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

        public bool Cliente_Mod(Cliente pCliente)
        {
            bool resultado = false;

            try
            {
                //Se crea la conexion con la base de datos mediante la clase SQLConection propia del .net framework
                SqlConnection conect = Conexion.Conectar();

                //Se debe identificar el storedprocedure que creamos en la base de datos ObtenerClientes
                SqlCommand cmd = new SqlCommand("ModCli", conect);

                //Se identifica el tipo de ejecución, en este caso un SP
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@id", pCliente.Id));
                cmd.Parameters.Add(new SqlParameter("@nombre", pCliente.Nombre));
                cmd.Parameters.Add(new SqlParameter("@apellido", pCliente.Apellido));
                cmd.Parameters.Add(new SqlParameter("@pass", pCliente.Password));
                cmd.Parameters.Add(new SqlParameter("@user", pCliente.User));
                cmd.Parameters.Add(new SqlParameter("@ci", pCliente.Ci));
                cmd.Parameters.Add(new SqlParameter("@dir", pCliente.Dir));
                cmd.Parameters.Add(new SqlParameter("@tel", pCliente.Tel));
                cmd.Parameters.Add(new SqlParameter("@Mail", pCliente.Mail));
                cmd.Parameters.Add(new SqlParameter("@fchaRegistro", pCliente.FchRegistro));


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


    } 
}
