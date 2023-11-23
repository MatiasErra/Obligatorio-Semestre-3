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
    public class pVehiculo
    {

        public List<Vehiculo> Vehiculo_ObtenerTodos()
        {
            List<Vehiculo> resultado = new List<Vehiculo>();
            try
            {
                Vehiculo vehiculo;

                //Se crea la conexion con la base de datos mediante la clase SQLConection propia del .net framework
                //var conexionSQL = new SqlConnection(CadenadaDeConexion);
                //conexionSQL.Open();
                SqlConnection conect = Conexion.Conectar();

                //Se debe identificar el storedprocedure que creamos en la base de datos ObtenerVehiculos
                SqlCommand cmd = new SqlCommand("ObtVehiculo", conect);

                //Se identifica el tipo de ejecución, en este caso un SP
                cmd.CommandType = CommandType.StoredProcedure;

                //Se ejecuta el Procedimiento almacenado que obtuvimos
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        ControladoraP p = ControladoraP.obtenerInstancia();
                        vehiculo = new Vehiculo();
                        vehiculo.IdVehiculo = int.Parse(reader["id"].ToString());
                        vehiculo.Matricula = reader["matricula"].ToString();
                        vehiculo.Marca = reader["marca"].ToString();
                        vehiculo.Modelo = reader["modelo"].ToString();
                        vehiculo.Año = reader["anio"].ToString();
                        vehiculo.Color = reader["color"].ToString();
                        vehiculo.Cli = p.BuscarCli((int.Parse(reader["idCli"].ToString())));


                        // usar un metodo para mostrar el cliente dado el id 

                        resultado.Add(vehiculo);
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


        public bool Vehiculo_Alta(Vehiculo pvehiculo)
        {
            bool resultado = false;

            try
            {
                //Se crea la conexion con la base de datos mediante la clase SQLConection propia del .net framework
                SqlConnection conect = Conexion.Conectar();

                //Se debe identificar el storedprocedure que creamos en la base de datos ObtenerClientes
                SqlCommand cmd = new SqlCommand("AltaVehiculo", conect);

                //Se identifica el tipo de ejecución, en este caso un SP
                cmd.CommandType = CommandType.StoredProcedure;

                //Se agrega parámetro que espera recibir el storedProcedure

                cmd.Parameters.Add(new SqlParameter("@matricula", pvehiculo.Matricula));
                cmd.Parameters.Add(new SqlParameter("@marca", pvehiculo.Marca));
                cmd.Parameters.Add(new SqlParameter("@modelo", pvehiculo.Modelo));
                cmd.Parameters.Add(new SqlParameter("@anio", pvehiculo.Año));
                cmd.Parameters.Add(new SqlParameter("@color", pvehiculo.Color));
                cmd.Parameters.Add(new SqlParameter("@idCli", pvehiculo.Cli.Id));


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




        public Vehiculo BuscarVeh(int id)
        {
            Vehiculo vehiculo = new Vehiculo();

            try
            {

                //Se crea la conexion con la base de datos mediante la clase SQLConection propia del .net framework
                SqlConnection conect = Conexion.Conectar();

                //Se debe identificar el storedprocedure que creamos en la base de datos ObtenerClientes
                SqlCommand cmd = new SqlCommand("BuscarVehi", conect);

                //Se identifica el tipo de ejecución, en este caso un SP
                cmd.CommandType = CommandType.StoredProcedure;

                //Se agrega parámetro que espera recibir el storedProcedure

                cmd.Parameters.Add(new SqlParameter("@id", id));
                using (SqlDataReader reader = cmd.ExecuteReader())
                {

                    while (reader.Read())
                    {
                        ControladoraP p = ControladoraP.obtenerInstancia();
                        vehiculo = new Vehiculo();
                        vehiculo.IdVehiculo = int.Parse(reader["id"].ToString());
                        vehiculo.Matricula = reader["matricula"].ToString();
                        vehiculo.Marca = reader["marca"].ToString();
                        vehiculo.Modelo = reader["modelo"].ToString();
                        vehiculo.Año = reader["anio"].ToString();
                        vehiculo.Color = reader["color"].ToString();
                        vehiculo.Cli = p.BuscarCli((int.Parse(reader["idCli"].ToString())));

                    }


                }

                conect.Close();



            }
            catch (Exception ex)
            {
                throw ex;
            }
            return vehiculo;
        }


        public List<Vehiculo> BuscarlstVeh(int id)
        {
            Vehiculo vehiculo = new Vehiculo();
            List<Vehiculo> resultado = new List<Vehiculo>();

            try
            {

                //Se crea la conexion con la base de datos mediante la clase SQLConection propia del .net framework
                SqlConnection conect = Conexion.Conectar();

                //Se debe identificar el storedprocedure que creamos en la base de datos ObtenerClientes
                SqlCommand cmd = new SqlCommand("BuscarlstVeh", conect);

                //Se identifica el tipo de ejecución, en este caso un SP
                cmd.CommandType = CommandType.StoredProcedure;

                //Se agrega parámetro que espera recibir el storedProcedure

                cmd.Parameters.Add(new SqlParameter("@idCli", id));
                using (SqlDataReader reader = cmd.ExecuteReader())
                {

                    while (reader.Read())
                    {
                        ControladoraP p = ControladoraP.obtenerInstancia();
                        vehiculo = new Vehiculo();
                        vehiculo.IdVehiculo = int.Parse(reader["id"].ToString());
                        vehiculo.Matricula = reader["matricula"].ToString();
                        vehiculo.Marca = reader["marca"].ToString();
                        vehiculo.Modelo = reader["modelo"].ToString();
                        vehiculo.Año = reader["anio"].ToString();
                        vehiculo.Color = reader["color"].ToString();
                        vehiculo.Cli = p.BuscarCli((int.Parse(reader["idCli"].ToString())));
                        resultado.Add(vehiculo);
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

        public List<Reparacion_Vehiculo> LstVehRepRepar(int id)
        {
            Reparacion_Vehiculo Rep_Veh = new Reparacion_Vehiculo();
            List<Reparacion_Vehiculo> resultado = new List<Reparacion_Vehiculo>(); 

            try
            {

                //Se crea la conexion con la base de datos mediante la clase SQLConection propia del .net framework
                SqlConnection conect = Conexion.Conectar();

                //Se debe identificar el storedprocedure que creamos en la base de datos ObtenerClientes
                SqlCommand cmd = new SqlCommand("VehRepDeUnCli", conect);

                //Se identifica el tipo de ejecución, en este caso un SP
                cmd.CommandType = CommandType.StoredProcedure;

                //Se agrega parámetro que espera recibir el storedProcedure

                cmd.Parameters.Add(new SqlParameter("@idCli", id));
                using (SqlDataReader reader = cmd.ExecuteReader())
                {

                    while (reader.Read())
                    {
                        ControladoraP p = ControladoraP.obtenerInstancia();
                        Rep_Veh = new Reparacion_Vehiculo();
                        Rep_Veh.FchaSalida  = reader["fchaSalida"].ToString();
                        Rep_Veh.Matricula = reader["Matricula"].ToString();
                        Rep_Veh.Modelo = reader["Modelo"].ToString();
                        Rep_Veh.Costo = int.Parse(reader["Costo"].ToString());
                        resultado.Add(Rep_Veh);
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




        public bool Vehiculo_Mod(Vehiculo pvehiculo)
        {
            bool resultado = false;

            try
            {
                //Se crea la conexion con la base de datos mediante la clase SQLConection propia del .net framework
                SqlConnection conect = Conexion.Conectar();

                //Se debe identificar el storedprocedure que creamos en la base de datos ObtenerClientes
                SqlCommand cmd = new SqlCommand("ModVehi", conect);

                //Se identifica el tipo de ejecución, en este caso un SP
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add(new SqlParameter("@id", pvehiculo.IdVehiculo));
                cmd.Parameters.Add(new SqlParameter("@mat", pvehiculo.Matricula));
                cmd.Parameters.Add(new SqlParameter("@mar", pvehiculo.Marca));
                cmd.Parameters.Add(new SqlParameter("@modelo", pvehiculo.Modelo));
                cmd.Parameters.Add(new SqlParameter("@anio", pvehiculo.Año));
                cmd.Parameters.Add(new SqlParameter("@color", pvehiculo.Color));
                cmd.Parameters.Add(new SqlParameter("@idCli", pvehiculo.Cli.Id));


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

        public bool Vehiculo_Baja(int id)
        {

            try
            {

                //Se crea la conexion con la base de datos mediante la clase SQLConection propia del .net framework
                SqlConnection conect = Conexion.Conectar();

                //Se debe identificar el storedprocedure que creamos en la base de datos ObtenerClientes
                SqlCommand cmd = new SqlCommand("EliminarVehi", conect);

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

