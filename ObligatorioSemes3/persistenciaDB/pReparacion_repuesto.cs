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
    class pReparacion_repuesto
    {
        public List<Reparacion_Repuesto> Reparacion_RepTodos(int id)
        {
            List<Reparacion_Repuesto> resultado = new List<Reparacion_Repuesto>();

            try
            {
                Reparacion_Repuesto reparacion;


                //Se crea la conexion con la base de datos mediante la clase SQLConection propia del .net framework
                //var conexionSQL = new SqlConnection(CadenadaDeConexion);
                //conexionSQL.Open();
                SqlConnection conect = Conexion.Conectar();

                //Se debe identificar el storedprocedure que creamos en la base de datos ObtenerReparacions
                SqlCommand cmd = new SqlCommand("ObtReparacion_Rep", conect);

                //Se identifica el tipo de ejecución, en este caso un SP
                cmd.CommandType = CommandType.StoredProcedure;

                //Se ejecuta el Procedimiento almacenado que obtuvimos
                cmd.Parameters.Add(new SqlParameter("@id", id));
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                while (reader.Read())
                    {
                        ControladoraP p = ControladoraP.obtenerInstancia();
                        reparacion = new Reparacion_Repuesto();
                  
                        reparacion.Repuesto =p.BuscarRepues(int.Parse(reader["idRepuesto"].ToString()));
                        reparacion.Reparacion = p.BuscarRepar(int.Parse(reader["idRepar"].ToString()));
                      reparacion.Cant = (reader["cantidad"].ToString());




                        // usar un metodo para mostrar  dado el id 

                        resultado.Add(reparacion);
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



        public bool Reparacion_Repuesto_Alta(Reparacion_Repuesto Rep_Rep)
        {
            bool resultado = false;

            try
            {
                //Se crea la conexion con la base de datos mediante la clase SQLConection propia del .net framework
                SqlConnection conect = Conexion.Conectar();

                //Se debe identificar el storedprocedure que creamos en la base de datos ObtenerClientes
                SqlCommand cmd = new SqlCommand("AltaRepar_Repuesto", conect);

                //Se identifica el tipo de ejecución, en este caso un SP
                cmd.CommandType = CommandType.StoredProcedure;

                //Se agrega parámetro que espera recibir el storedProcedure


                cmd.Parameters.Add(new SqlParameter("@idRepar", Rep_Rep.Reparacion.Id));
                cmd.Parameters.Add(new SqlParameter("@idRepuesto", Rep_Rep.Repuesto.Id));
             cmd.Parameters.Add(new SqlParameter("@cantidad", Rep_Rep.Cant));
     

                //Se ejecuta el procedimiento y retorna un int (si es mayor a cero es que se ejecutó correctamente)
                int resBD = cmd.ExecuteNonQuery();

            
                    resultado = true;
              
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

        public bool Reparacion_Repuesto_Baja (int IdRepuesto, int idRepar)
        {
            try
            {

                //Se crea la conexion con la base de datos mediante la clase SQLConection propia del .net framework
                SqlConnection conect = Conexion.Conectar();

                //Se debe identificar el storedprocedure que creamos en la base de datos ObtenerClientes
                SqlCommand cmd = new SqlCommand("EliminarReparacion_Repuesto", conect);

                //Se identifica el tipo de ejecución, en este caso un SP
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@id", IdRepuesto));
                cmd.Parameters.Add(new SqlParameter("@idRepar", idRepar));

                using (SqlDataReader reader = cmd.ExecuteReader())
                    while (reader.Read())
                    {

                        cmd.Parameters.Add(new SqlParameter("@id", IdRepuesto));
                        cmd.Parameters.Add(new SqlParameter("@idRepar", idRepar));
                    }

                conect.Close();

                return true;

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public bool Reparacion_Repuesto_Cant(string cant, int idRepar,int idRepuesto)
        {
            try
            {

                //Se crea la conexion con la base de datos mediante la clase SQLConection propia del .net framework
                SqlConnection conect = Conexion.Conectar();

                //Se debe identificar el storedprocedure que creamos en la base de datos ObtenerClientes
                SqlCommand cmd = new SqlCommand("AgregarCant", conect);

                //Se identifica el tipo de ejecución, en este caso un SP
                cmd.CommandType = CommandType.StoredProcedure;
                
                
                cmd.Parameters.Add(new SqlParameter("@idRepar", idRepar));
                cmd.Parameters.Add(new SqlParameter("@idRepuesto", idRepuesto));
                cmd.Parameters.Add(new SqlParameter("@cant", cant));

              

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
