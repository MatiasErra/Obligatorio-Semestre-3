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
    internal class pMecanico
    {

        public List<Mecanico> Mecanico_ObtenerTodos()
        {
            List<Mecanico> resultado = new List<Mecanico>();
            try
            {
                Mecanico unMecanico;

                //Se crea la conexion con la base de datos mediante la clase SQLConection propia del .net framework
                //var conexionSQL = new SqlConnection(CadenadaDeConexion);
                //conexionSQL.Open();
                SqlConnection conect = Conexion.Conectar();

                //Se debe identificar el storedprocedure que creamos en la base de datos ObtenerMecanicos
                SqlCommand cmd = new SqlCommand("ObtMecanico", conect);

                //Se identifica el tipo de ejecución, en este caso un SP
                cmd.CommandType = CommandType.StoredProcedure;

                //Se ejecuta el Procedimiento almacenado que obtuvimos
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        unMecanico = new Mecanico();

                        unMecanico.Id = int.Parse(reader["id"].ToString());
                        unMecanico.Nombre = reader["nombre"].ToString();
                        unMecanico.Apellido = reader["apellido"].ToString();
                        unMecanico.Ci = reader["ci"].ToString();
                        unMecanico.Tel = reader["tel"].ToString();
                        unMecanico.FchaIngreso = reader["fchingreso"].ToString();
                        unMecanico.ValorHora = double.Parse(reader["valorHora"].ToString());
                  
                
                        resultado.Add(unMecanico);
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

        public bool Mecanico_Alta(Mecanico pMecanico)
        {
            bool resultado = false;

            try
            {
                //Se crea la conexion con la base de datos mediante la clase SQLConection propia del .net framework
                SqlConnection conect = Conexion.Conectar();

                //Se debe identificar el storedprocedure que creamos en la base de datos ObtenerMecanicos
                SqlCommand cmd = new SqlCommand("AltaMecanico", conect);

                //Se identifica el tipo de ejecución, en este caso un SP
                cmd.CommandType = CommandType.StoredProcedure;

                //Se agrega parámetro que espera recibir el storedProcedure

                // buscar la manera de sacar el id del sql por que es identity

                cmd.Parameters.Add(new SqlParameter("@Nombre", pMecanico.Nombre));
                cmd.Parameters.Add(new SqlParameter("@Apellido", pMecanico.Apellido));
                cmd.Parameters.Add(new SqlParameter("@Ci", pMecanico.Ci));
                cmd.Parameters.Add(new SqlParameter("@Tel", pMecanico.Tel));
                cmd.Parameters.Add(new SqlParameter("@FchaIngreso", pMecanico.FchaIngreso));
                cmd.Parameters.Add(new SqlParameter("@ValorHora", pMecanico.ValorHora));
             
              
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

        public Mecanico BuscarMec(int id)
        {
            Mecanico mecanico = new Mecanico();

            try
            {

                //Se crea la conexion con la base de datos mediante la clase SQLConection propia del .net framework
                SqlConnection conect = Conexion.Conectar();

                //Se debe identificar el storedprocedure que creamos en la base de datos ObtenerMecanicos
                SqlCommand cmd = new SqlCommand("BuscarMec", conect);

                //Se identifica el tipo de ejecución, en este caso un SP
                cmd.CommandType = CommandType.StoredProcedure;

                //Se agrega parámetro que espera recibir el storedProcedure

                cmd.Parameters.Add(new SqlParameter("@id", id));
                using (SqlDataReader reader = cmd.ExecuteReader())
                {

                    while (reader.Read())
                    {

                        mecanico.Id = int.Parse(reader["id"].ToString());
                        mecanico.Nombre = reader["nombre"].ToString();
                        mecanico.Apellido = reader["apellido"].ToString();
                        mecanico.Ci = reader["ci"].ToString();
                        mecanico.Tel = reader["tel"].ToString();
                        mecanico.FchaIngreso = reader["fchIngreso"].ToString();
                        mecanico.ValorHora = Convert.ToDouble(reader["valorHora"].ToString());
                     
                
                     
                    }


                }

                conect.Close();



            }
            catch (Exception ex)
            {
                throw ex;
            }
            return mecanico;

        }


        public bool Mecanico_Mod(Mecanico pMecanico)
        {
            bool resultado = false;

            try
            {
                //Se crea la conexion con la base de datos mediante la clase SQLConection propia del .net framework
                SqlConnection conect = Conexion.Conectar();

                //Se debe identificar el storedprocedure que creamos en la base de datos ObtenerClientes
                SqlCommand cmd = new SqlCommand("ModRep", conect);

                //Se identifica el tipo de ejecución, en este caso un SP
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@id", pMecanico.Id));
                cmd.Parameters.Add(new SqlParameter("@nombre", pMecanico.Nombre));
                cmd.Parameters.Add(new SqlParameter("@apellido", pMecanico.Apellido));
                cmd.Parameters.Add(new SqlParameter("@ci",pMecanico.Ci));
                cmd.Parameters.Add(new SqlParameter("@tel", pMecanico.Tel));
                cmd.Parameters.Add(new SqlParameter("@FchaIngreso", pMecanico.FchaIngreso));
                cmd.Parameters.Add(new SqlParameter("@valorHora",pMecanico.ValorHora));
            
              
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

        public bool Mecanico_Baja(int id)
        {

            try
            {

                //Se crea la conexion con la base de datos mediante la clase SQLConection propia del .net framework
                SqlConnection conect = Conexion.Conectar();

                //Se debe identificar el storedprocedure que creamos en la base de datos ObtenerClientes
                SqlCommand cmd = new SqlCommand("EliminarMecanico", conect);

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
    }
}


