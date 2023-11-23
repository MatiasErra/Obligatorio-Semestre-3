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
        public class pRepuesto
        {

            public List<Repuesto> Repuesto_ObtenerTodos()
            {
                List<Repuesto> resultado = new List<Repuesto>();
                try
                {
                    Repuesto repuesto;

                    //Se crea la conexion con la base de datos mediante la clase SQLConection propia del .net framework
                    //var conexionSQL = new SqlConnection(CadenadaDeConexion);
                    //conexionSQL.Open();
                    SqlConnection conect = Conexion.Conectar();

                    //Se debe identificar el storedprocedure que creamos en la base de datos Obtenerrepuestos
                    SqlCommand cmd = new SqlCommand("ObtRepuesto", conect);

                    //Se identifica el tipo de ejecución, en este caso un SP
                    cmd.CommandType = CommandType.StoredProcedure;

                    //Se ejecuta el Procedimiento almacenado que obtuvimos
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            ControladoraP p = ControladoraP.obtenerInstancia();
                            repuesto = new Repuesto();

                            repuesto.Id = int.Parse(reader["id"].ToString());
                            repuesto.Desc = reader["descripcion"].ToString();
                            repuesto.Costo = int.Parse(reader["costo"].ToString());
                            repuesto.Tipo = (reader["tipo"].ToString());
                        repuesto.Stock = reader["stock"].ToString();
                        repuesto.Nombre = reader["nombre"].ToString();


                        // usar un metodo para mostrar  dado el id 

                        resultado.Add(repuesto);
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


        public List<Repuesto> Repuesto_ORD()
        {
            List<Repuesto> resultado = new List<Repuesto>();
            try
            {
                Repuesto repuesto;

                //Se crea la conexion con la base de datos mediante la clase SQLConection propia del .net framework
                //var conexionSQL = new SqlConnection(CadenadaDeConexion);
                //conexionSQL.Open();
                SqlConnection conect = Conexion.Conectar();

                //Se debe identificar el storedprocedure que creamos en la base de datos Obtenerrepuestos
                SqlCommand cmd = new SqlCommand("ObtRepuestoORD", conect);

                //Se identifica el tipo de ejecución, en este caso un SP
                cmd.CommandType = CommandType.StoredProcedure;

                //Se ejecuta el Procedimiento almacenado que obtuvimos
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        ControladoraP p = ControladoraP.obtenerInstancia();
                        repuesto = new Repuesto();

                        repuesto.Id = int.Parse(reader["id"].ToString());
                        repuesto.Desc = reader["descripcion"].ToString();
                        repuesto.Costo = int.Parse(reader["costo"].ToString());
                        repuesto.Tipo = (reader["tipo"].ToString());
                        repuesto.Stock = reader["stock"].ToString();
                        repuesto.Nombre = reader["nombre"].ToString();


                        // usar un metodo para mostrar  dado el id 

                        resultado.Add(repuesto);
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


        public List<int> CantRepuesto()
        {
            List<int> Resultado = new List<int>();
            try
            {
           

                //Se crea la conexion con la base de datos mediante la clase SQLConection propia del .net framework
                //var conexionSQL = new SqlConnection(CadenadaDeConexion);
                //conexionSQL.Open();
                SqlConnection conect = Conexion.Conectar();

                //Se debe identificar el storedprocedure que creamos en la base de datos Obtenerrepuestos
                SqlCommand cmd = new SqlCommand("CantRepuesto", conect);

                //Se identifica el tipo de ejecución, en este caso un SP
                cmd.CommandType = CommandType.StoredProcedure;

                //Se ejecuta el Procedimiento almacenado que obtuvimos
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        ControladoraP p = ControladoraP.obtenerInstancia();
                        int Cant;

                      Cant = int.Parse(reader["Cant"].ToString());


                        // usar un metodo para mostrar  dado el id 

                        Resultado.Add(Cant);
                    }
                }

                conect.Close();
            }
            catch (Exception ex)
            {

                throw new Exception(ex.ToString());

            }


            return Resultado;

        }


        public bool Repuesto_Alta(Repuesto pRepuesto)
            {
                bool resultado = false;

                try
                {
                    //Se crea la conexion con la base de datos mediante la clase SQLConection propia del .net framework
                    SqlConnection conect = Conexion.Conectar();

                    //Se debe identificar el storedprocedure que creamos en la base de datos ObtenerClientes
                    SqlCommand cmd = new SqlCommand("AltaRepuesto", conect);

                    //Se identifica el tipo de ejecución, en este caso un SP
                    cmd.CommandType = CommandType.StoredProcedure;

                //Se agrega parámetro que espera recibir el storedProcedure
     
                cmd.Parameters.Add(new SqlParameter("@descripcion", pRepuesto.Desc));
                    cmd.Parameters.Add(new SqlParameter("@costo", pRepuesto.Costo));
                    cmd.Parameters.Add(new SqlParameter("@tipo", pRepuesto.Tipo));
                cmd.Parameters.Add(new SqlParameter("@stock", pRepuesto.Stock));
                cmd.Parameters.Add(new SqlParameter("@nombre", pRepuesto.Nombre));

                    //Se ejecuta el procedimiento y retorna un int (si es mayor a cero es que se ejecutó correctamente)
                int resBD = cmd.ExecuteNonQuery();
                resultado = true;
                //if (resBD > 0)
                //    {
                //        resultado = true;
                //    }
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

            public bool Repuesto_Baja(int id)
            {

                try
                {

                    //Se crea la conexion con la base de datos mediante la clase SQLConection propia del .net framework
                    SqlConnection conect = Conexion.Conectar();

                    //Se debe identificar el storedprocedure que creamos en la base de datos ObtenerClientes
                    SqlCommand cmd = new SqlCommand("EliminarRepuesto", conect);

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



            public bool Repuesto_Mod(Repuesto pRepuesto)
            {
                bool resultado = false;

                try
                {
                    //Se crea la conexion con la base de datos mediante la clase SQLConection propia del .net framework
                    SqlConnection conect = Conexion.Conectar();

                    //Se debe identificar el storedprocedure que creamos en la base de datos ObtenerClientes
                    SqlCommand cmd = new SqlCommand("ModRepuesto", conect);

                    //Se identifica el tipo de ejecución, en este caso un SP
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add(new SqlParameter("@id", pRepuesto.Id));
                cmd.Parameters.Add(new SqlParameter("@nombre", pRepuesto.Nombre));
                cmd.Parameters.Add(new SqlParameter("@descripcion", pRepuesto.Desc));
                    cmd.Parameters.Add(new SqlParameter("@tipo", pRepuesto.Tipo));
                    cmd.Parameters.Add(new SqlParameter("@costo", pRepuesto.Costo));
                cmd.Parameters.Add(new SqlParameter("@stock", pRepuesto.Stock));




                //Se ejecuta el procedimiento y retorna un int (si es mayor a cero es que se ejecutó correctamente)

                int resBD = cmd.ExecuteNonQuery();
                resultado = true;

                //if (resBD > 0)
                //{
                //    resultado = true;
                //}

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

        public Repuesto BuscarRepues(int id)
        {
            Repuesto repu = new Repuesto();

            try
            {

                //Se crea la conexion con la base de datos mediante la clase SQLConection propia del .net framework
                SqlConnection conect = Conexion.Conectar();

                //Se debe identificar el storedprocedure que creamos en la base de datos ObtenerClientes
                SqlCommand cmd = new SqlCommand("BuscarRepuesto", conect);

                //Se identifica el tipo de ejecución, en este caso un SP
                cmd.CommandType = CommandType.StoredProcedure;

                //Se agrega parámetro que espera recibir el storedProcedure

                cmd.Parameters.Add(new SqlParameter("@id", id));
                using (SqlDataReader reader = cmd.ExecuteReader())
                {

                    while (reader.Read())
                    {
                        ControladoraP p = ControladoraP.obtenerInstancia();

                        repu.Id = int.Parse(reader["id"].ToString());
                        repu.Desc = reader["descripcion"].ToString();
                        repu.Nombre = reader["nombre"].ToString();
                        repu.Tipo = reader["tipo"].ToString();
                        repu.Costo = int.Parse(reader["costo"].ToString());
                        repu.Stock = reader["stock"].ToString();


                    }


                }

                conect.Close();



            }
            catch (Exception ex)
            {
                throw ex;
            }
            return repu;
        }


    }
    }



