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
    public class pReparacion
    {

        public List<Reparacion> Reparacion_ReparTodos()
        {
            List<Reparacion> resultado = new List<Reparacion>();
            try
            {
                Reparacion reparacion;

                //Se crea la conexion con la base de datos mediante la clase SQLConection propia del .net framework
                //var conexionSQL = new SqlConnection(CadenadaDeConexion);
                //conexionSQL.Open();
                SqlConnection conect = Conexion.Conectar();

                //Se debe identificar el storedprocedure que creamos en la base de datos ObtenerReparacions
                SqlCommand cmd = new SqlCommand("ObtReparacion", conect);

                //Se identifica el tipo de ejecución, en este caso un SP
                cmd.CommandType = CommandType.StoredProcedure;

                //Se ejecuta el Procedimiento almacenado que obtuvimos
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        ControladoraP p = ControladoraP.obtenerInstancia();
                        reparacion = new Reparacion();

                        reparacion.Id = int.Parse(reader["id"].ToString());
                        reparacion.FchaEntrada = reader["fchaEntrada"].ToString();
                        reparacion.FchaSalida = reader["fchaSalida"].ToString();
                        reparacion.Horas = int.Parse(reader["Horas"].ToString());
                        reparacion.FchaReservada = reader["fchaReservada"].ToString();
                        reparacion.FchaAgendada = reader["fchaAgendada"].ToString();
                        reparacion.Descripcion = reader["descripcion"].ToString();
                        reparacion.Vehiculo = p.BuscarVeh((int.Parse(reader["idvehiculo"].ToString())));
                        reparacion.Mecanico = p.BuscarMec((int.Parse(reader["idMecanico"].ToString())));
                        reparacion.Costo = int.Parse(reader["costo"].ToString());
                        reparacion.Tipo = reader["Tipo"].ToString();



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
        public List<Reparacion> Reparacion_Repar()
        {
            List<Reparacion> resultado = new List<Reparacion>();
            try
            {
                Reparacion reparacion;

                //Se crea la conexion con la base de datos mediante la clase SQLConection propia del .net framework
                //var conexionSQL = new SqlConnection(CadenadaDeConexion);
                //conexionSQL.Open();
                SqlConnection conect = Conexion.Conectar();

                //Se debe identificar el storedprocedure que creamos en la base de datos ObtenerReparacions
                SqlCommand cmd = new SqlCommand("ObtReparacionRepar", conect);

                //Se identifica el tipo de ejecución, en este caso un SP
                cmd.CommandType = CommandType.StoredProcedure;

                //Se ejecuta el Procedimiento almacenado que obtuvimos
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        ControladoraP p = ControladoraP.obtenerInstancia();
                        reparacion = new Reparacion();
                        
                        reparacion.Id = int.Parse(reader["id"].ToString());
                        reparacion.FchaEntrada = reader["fchaEntrada"].ToString();
                        reparacion.FchaSalida = reader["fchaSalida"].ToString();
                        reparacion.Horas = int.Parse(reader["Horas"].ToString());
                        reparacion.FchaReservada = reader["fchaReservada"].ToString();
                        reparacion.FchaAgendada = reader["fchaAgendada"].ToString();
                        reparacion.Descripcion = reader["descripcion"].ToString();
                        reparacion.Vehiculo = p.BuscarVeh((int.Parse(reader["idvehiculo"].ToString())));
                        reparacion.Mecanico = p.BuscarMec((int.Parse(reader["idMecanico"].ToString())));
                        reparacion.Costo = int.Parse(reader["costo"].ToString());
                        reparacion.Tipo = reader["Tipo"].ToString();



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


        public List<Reparacion> Reparacion_ReparDadaFcha(string fchaI, string fchaF)
        {
            List<Reparacion> resultado = new List<Reparacion>();
            try
            {
                Reparacion reparacion;

                //Se crea la conexion con la base de datos mediante la clase SQLConection propia del .net framework
                //var conexionSQL = new SqlConnection(CadenadaDeConexion);
                //conexionSQL.Open();
                SqlConnection conect = Conexion.Conectar();

                //Se debe identificar el storedprocedure que creamos en la base de datos ObtenerReparacions
                SqlCommand cmd = new SqlCommand("ObtReparacionReparFch", conect);

                //Se identifica el tipo de ejecución, en este caso un SP
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add(new SqlParameter("@fchaI", fchaI));
                cmd.Parameters.Add(new SqlParameter("@fchaF", fchaF));

                //Se ejecuta el Procedimiento almacenado que obtuvimos
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        ControladoraP p = ControladoraP.obtenerInstancia();
                        reparacion = new Reparacion();

                        reparacion.Id = int.Parse(reader["id"].ToString());
                        reparacion.FchaEntrada = reader["fchaEntrada"].ToString();
                        reparacion.FchaSalida = reader["fchaSalida"].ToString();
                        reparacion.Horas = int.Parse(reader["Horas"].ToString());
                        reparacion.FchaReservada = reader["fchaReservada"].ToString();
                        reparacion.FchaAgendada = reader["fchaAgendada"].ToString();
                        reparacion.Descripcion = reader["descripcion"].ToString();
                        reparacion.Vehiculo = p.BuscarVeh((int.Parse(reader["idvehiculo"].ToString())));
                        reparacion.Mecanico = p.BuscarMec((int.Parse(reader["idMecanico"].ToString())));
                        reparacion.Costo = int.Parse(reader["costo"].ToString());
                        reparacion.Tipo = reader["Tipo"].ToString();



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

        public List<Reparacion> Reparacion_ReparEnRep()
        {
            List<Reparacion> resultado = new List<Reparacion>();
            try
            {
                Reparacion reparacion;

                //Se crea la conexion con la base de datos mediante la clase SQLConection propia del .net framework
                //var conexionSQL = new SqlConnection(CadenadaDeConexion);
                //conexionSQL.Open();
                SqlConnection conect = Conexion.Conectar();

                //Se debe identificar el storedprocedure que creamos en la base de datos ObtenerReparacions
                SqlCommand cmd = new SqlCommand("ObtReparacionReparEnRep", conect);

                //Se identifica el tipo de ejecución, en este caso un SP
                cmd.CommandType = CommandType.StoredProcedure;

                //Se ejecuta el Procedimiento almacenado que obtuvimos
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        ControladoraP p = ControladoraP.obtenerInstancia();
                        reparacion = new Reparacion();

                        reparacion.Id = int.Parse(reader["id"].ToString());
                        reparacion.FchaEntrada = reader["fchaEntrada"].ToString();
                        reparacion.FchaReservada = reader["fchaReservada"].ToString();
                        reparacion.FchaAgendada = reader["fchaAgendada"].ToString();
                        reparacion.Descripcion = reader["descripcion"].ToString();
                        reparacion.Vehiculo = p.BuscarVeh((int.Parse(reader["idvehiculo"].ToString())));
                        reparacion.Mecanico = p.BuscarMec((int.Parse(reader["idMecanico"].ToString())));
            
                        reparacion.Tipo = reader["Tipo"].ToString();



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

        public List<Reparacion> Reparacion_Agendado()
        {
            List<Reparacion> resultado = new List<Reparacion>();
            try
            {
                Reparacion reparacion;

                //Se crea la conexion con la base de datos mediante la clase SQLConection propia del .net framework
                //var conexionSQL = new SqlConnection(CadenadaDeConexion);
                //conexionSQL.Open();
                SqlConnection conect = Conexion.Conectar();

                //Se debe identificar el storedprocedure que creamos en la base de datos ObtenerReparacions
                SqlCommand cmd = new SqlCommand("ObtReparacionAgend", conect);

                //Se identifica el tipo de ejecución, en este caso un SP
                cmd.CommandType = CommandType.StoredProcedure;

                //Se ejecuta el Procedimiento almacenado que obtuvimos
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        ControladoraP p = ControladoraP.obtenerInstancia();
                        reparacion = new Reparacion();

                        reparacion.Id = int.Parse(reader["id"].ToString());
                 
                        reparacion.FchaReservada = reader["fchaReservada"].ToString();
                        reparacion.FchaAgendada = reader["fchaAgendada"].ToString();
                        reparacion.Vehiculo = p.BuscarVeh((int.Parse(reader["idvehiculo"].ToString())));
                        reparacion.Tipo = reader["Tipo"].ToString();



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


        public bool Reparacion_AltaCli(Reparacion preparacion)
        {
            bool resultado = false;

            try
            {
                //Se crea la conexion con la base de datos mediante la clase SQLConection propia del .net framework
                SqlConnection conect = Conexion.Conectar();

                //Se debe identificar el storedprocedure que creamos en la base de datos ObtenerClientes
                SqlCommand cmd = new SqlCommand("AltaReparacionCli", conect);

                //Se identifica el tipo de ejecución, en este caso un SP
                cmd.CommandType = CommandType.StoredProcedure;

                //Se agrega parámetro que espera recibir el storedProcedure


            
                cmd.Parameters.Add(new SqlParameter("@fchaReservada", preparacion.FchaReservada));
    
                cmd.Parameters.Add(new SqlParameter("@idVehiculo", preparacion.Vehiculo.IdVehiculo));
           


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


        public bool Reparacion_Alta(Reparacion reparacion)
        {
            bool resultado = false;

            try
            {
                //Se crea la conexion con la base de datos mediante la clase SQLConection propia del .net framework
                SqlConnection conect = Conexion.Conectar();

                //Se debe identificar el storedprocedure que creamos en la base de datos ObtenerClientes
                SqlCommand cmd = new SqlCommand("AltaReparacion", conect);

                //Se identifica el tipo de ejecución, en este caso un SP
                cmd.CommandType = CommandType.StoredProcedure;

                //Se agrega parámetro que espera recibir el storedProcedure

              
                cmd.Parameters.Add(new SqlParameter("@fchaEntrada", reparacion.FchaEntrada));
                cmd.Parameters.Add(new SqlParameter("@fchaSalida", reparacion.FchaSalida));
                cmd.Parameters.Add(new SqlParameter("@Horas", reparacion.Horas));
                cmd.Parameters.Add(new SqlParameter("@fchaReservada", reparacion.FchaReservada));
                cmd.Parameters.Add(new SqlParameter("@descripcion", reparacion.Descripcion));
                cmd.Parameters.Add(new SqlParameter("@idVehiculo", reparacion.Vehiculo.IdVehiculo));
                cmd.Parameters.Add(new SqlParameter("@idMecanico", reparacion.Mecanico.Id));
  


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

        public bool ReparacionEnRep_Alta(Reparacion preparacion)
        {
            bool resultado = false;

            try
            {
                //Se crea la conexion con la base de datos mediante la clase SQLConection propia del .net framework
                SqlConnection conect = Conexion.Conectar();

                //Se debe identificar el storedprocedure que creamos en la base de datos ObtenerClientes
                SqlCommand cmd = new SqlCommand("AltaEnReparacion", conect);

                //Se identifica el tipo de ejecución, en este caso un SP
                cmd.CommandType = CommandType.StoredProcedure;

                //Se agrega parámetro que espera recibir el storedProcedure


                cmd.Parameters.Add(new SqlParameter("@fchaEntrada", preparacion.FchaEntrada));
                cmd.Parameters.Add(new SqlParameter("@fchaReservada", preparacion.FchaReservada));
                cmd.Parameters.Add(new SqlParameter("@descripcion", preparacion.Descripcion));
                cmd.Parameters.Add(new SqlParameter("@idVehiculo", preparacion.Vehiculo.IdVehiculo));
                cmd.Parameters.Add(new SqlParameter("@idMecanico", preparacion.Mecanico.Id));



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



        public bool Reparacion_Baja(int id)
        {

            try
            {

                //Se crea la conexion con la base de datos mediante la clase SQLConection propia del .net framework
                SqlConnection conect = Conexion.Conectar();

                //Se debe identificar el storedprocedure que creamos en la base de datos ObtenerClientes
                SqlCommand cmd = new SqlCommand("EliminarRepar", conect);

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


        public Reparacion BuscarReparacion(int id)
        {
            Reparacion reparacion = new Reparacion();

            try
            {

                //Se crea la conexion con la base de datos mediante la clase SQLConection propia del .net framework
                SqlConnection conect = Conexion.Conectar();

                //Se debe identificar el storedprocedure que creamos en la base de datos ObtenerClientes
                SqlCommand cmd = new SqlCommand("BuscarReparacion", conect);

                //Se identifica el tipo de ejecución, en este caso un SP
                cmd.CommandType = CommandType.StoredProcedure;

                //Se agrega parámetro que espera recibir el storedProcedure

                cmd.Parameters.Add(new SqlParameter("@id", id));
                using (SqlDataReader reader = cmd.ExecuteReader())
                {

                     while (reader.Read())
                    {
                        ControladoraP p = ControladoraP.obtenerInstancia();
                        reparacion = new Reparacion();
                        reparacion.Id = int.Parse(reader["id"].ToString());
                        reparacion.FchaEntrada = reader["fchaEntrada"].ToString();
                        reparacion.FchaSalida = reader["fchaSalida"].ToString();
                        reparacion.Horas = int.Parse(reader["horas"].ToString());
                        reparacion.FchaReservada = reader["fchaReservada"].ToString();
                        reparacion.Descripcion = reader["descripcion"].ToString();
                        reparacion.Vehiculo = p.BuscarVeh((int.Parse(reader["idvehiculo"].ToString())));
                        reparacion.Mecanico = p.BuscarMec((int.Parse(reader["idMecanico"].ToString())));
                        reparacion.Costo = int.Parse(reader["costo"].ToString());
                        reparacion.Tipo = reader["Tipo"].ToString();




                    }


                }

                conect.Close();



            }
            catch (Exception ex)
            {
                throw ex;
            }
            return reparacion;
        }

        public Reparacion BuscarReparacionAgend(int id)
        {
            Reparacion reparacion = new Reparacion();

            try
            {

                //Se crea la conexion con la base de datos mediante la clase SQLConection propia del .net framework
                SqlConnection conect = Conexion.Conectar();

                //Se debe identificar el storedprocedure que creamos en la base de datos ObtenerClientes
                SqlCommand cmd = new SqlCommand("BuscarReparacion", conect);

                //Se identifica el tipo de ejecución, en este caso un SP
                cmd.CommandType = CommandType.StoredProcedure;

                //Se agrega parámetro que espera recibir el storedProcedure

                cmd.Parameters.Add(new SqlParameter("@id", id));
                using (SqlDataReader reader = cmd.ExecuteReader())
                {

                    while (reader.Read())
                    {
                        ControladoraP p = ControladoraP.obtenerInstancia();
                        reparacion = new Reparacion();
                        reparacion.Id = int.Parse(reader["id"].ToString());
    
                        reparacion.FchaReservada = reader["fchaReservada"].ToString();
        
                        reparacion.Vehiculo = p.BuscarVeh((int.Parse(reader["idvehiculo"].ToString())));

                        reparacion.Tipo = reader["Tipo"].ToString();




                    }


                }

                conect.Close();



            }
            catch (Exception ex)
            {
                throw ex;
            }
            return reparacion;
        }



        public bool Reparacion_Mod(Reparacion pReparacion)
        {
            bool resultado = false;

            try
            {
                //Se crea la conexion con la base de datos mediante la clase SQLConection propia del .net framework
                SqlConnection conect = Conexion.Conectar();

                //Se debe identificar el storedprocedure que creamos en la base de datos ObtenerClientes
                SqlCommand cmd = new SqlCommand("ModRepar", conect);

                //Se identifica el tipo de ejecución, en este caso un SP
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add(new SqlParameter("@id", pReparacion.Id));
                cmd.Parameters.Add(new SqlParameter("@FechaEntrada", pReparacion.FchaEntrada));
                cmd.Parameters.Add(new SqlParameter("@FechaSalida", pReparacion.FchaSalida));
                cmd.Parameters.Add(new SqlParameter("@Horas", pReparacion.Horas));
                cmd.Parameters.Add(new SqlParameter("@fchaReservada", pReparacion.FchaReservada));
                cmd.Parameters.Add(new SqlParameter("@descripcion", pReparacion.Descripcion));
                cmd.Parameters.Add(new SqlParameter("@IdVehiculo", pReparacion.Vehiculo.IdVehiculo));
                cmd.Parameters.Add(new SqlParameter("@IdMecanico", pReparacion.Mecanico.Id));
    




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

        public bool Repar_Costo(int id)
        {
            bool resultado = false;

            try
            {
                //Se crea la conexion con la base de datos mediante la clase SQLConection propia del .net framework
                SqlConnection conect = Conexion.Conectar();

                //Se debe identificar el storedprocedure que creamos en la base de datos ObtenerClientes
                SqlCommand cmd = new SqlCommand("CostoDeRepar", conect);

                //Se identifica el tipo de ejecución, en este caso un SP
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add(new SqlParameter("@id", id));
     




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


