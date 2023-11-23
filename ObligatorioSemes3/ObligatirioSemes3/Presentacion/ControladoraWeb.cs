using ObligatirioSemes3.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ControladorasOblig;


namespace ObligatirioSemes3.Presentacion
{
    public class ControladoraWeb
    {
        private static Automotriz _automotriz;
        private static ControladoraWeb _instancia;

        public Automotriz Automotriz { get => _automotriz; set => _automotriz = value; }

        public static ControladoraWeb obtenerInstancia()
        {
            if (_instancia == null)
            {

                _instancia = new ControladoraWeb();

                _automotriz = Automotriz.obtenerInstancia();
            }
            return _instancia;
        }
        #region AdminWeb

        public bool AltaAdmin(Admin Admin)
        {
            ControladoraPersona inst = ControladoraPersona.obtenerInstancia();

            if (inst.AltaAdmin(Admin))
            {
                return true;
            }
            else
                return false;
        }


        public bool BajaAdmin(int id)
        {
            ControladoraPersona inst = ControladoraPersona.obtenerInstancia();

            if (inst.BajaAdmin(id))
            {
                return true;
            }
            else
                return false;
        }



        public bool ModAdmin(Admin Admin)
        {
            ControladoraPersona inst = ControladoraPersona.obtenerInstancia();

            if (inst.ModAdmin(Admin))
            {
                return true;
            }
            else
                return false;
        }

        public Admin BuscarAdmin(int id)
        {
            ControladoraPersona inst = ControladoraPersona.obtenerInstancia();

            Admin lst = inst.BuscarAdmin(id);
            return lst;
        }



        public List<Admin> lstAdmin()
        {
            ControladoraPersona inst = ControladoraPersona.obtenerInstancia();

            List<Admin> lst = inst.lstAdmin();
            return lst;
        }

        public bool IniciarSesionSA(string user, string pass)
        {
            ControladoraPersona inst = ControladoraPersona.obtenerInstancia();

            bool lst = inst.IniciarSesionSA(user, pass);

            return lst;
        }


        #endregion

        #region Repuesto

        public bool AltaRepues(Repuesto repuesto)
        {
             Controladoraitem inst = Controladoraitem.ObtenerInstancia();

            if (inst.AltaRepues(repuesto))
            {
                return true;
            }
            else
                return false;
        }


        public bool BajaRepues(int id)
        {
            Controladoraitem inst = Controladoraitem.ObtenerInstancia();

            if (inst.BajaRepues(id))
            {
                return true;
            }
            else
                return false;
        }


        public bool ModRepues(Repuesto repuesto)
        {
            Controladoraitem inst = Controladoraitem.ObtenerInstancia();

            if (inst.ModRepues(repuesto))
            {
                return true;
            }
            else
                return false;
        }


        public List<Repuesto> lstRepues()
        {
            Controladoraitem inst = Controladoraitem.ObtenerInstancia();

            List<Repuesto> lst = inst.lstRepues();
            return lst;
        }

        public List<Repuesto> LstRepuesto_ORD()
        {
            Controladoraitem inst = Controladoraitem.ObtenerInstancia();

            List<Repuesto> lst = inst.LstRepuesto_ORD();
            return lst;
        }

        public List<int> CantRepuesto()
        {
            Controladoraitem inst = Controladoraitem.ObtenerInstancia();

            List<int> lst = inst.CantRepuesto();
            return lst;
        }

        public Repuesto BuscarRepues(int id)
        {
            Controladoraitem inst = Controladoraitem.ObtenerInstancia();

            Repuesto lst = inst.BuscarRepues(id);
            return lst;
        }



        #endregion

        #region Cliente

        public bool AltaCliente(Cliente cliente)
        {
            ControladoraPersona ins = ControladoraPersona.obtenerInstancia();
   
            if (ins.AltaCliente(cliente))
            {
                return true;
            }
            else 
                return false;
        }

        public bool BajaCliente(int id)
        {
            ControladoraPersona ins = ControladoraPersona.obtenerInstancia();

            if (ins.BajaCliente(id))
            {
                return true;
            }
            else
                return false;
        }



        public bool ModCliente(Cliente cliente)
        {
            ControladoraPersona ins = ControladoraPersona.obtenerInstancia();

            if (ins.ModCliente(cliente))
            {
                return true;
            }
            else
                return false;
        }


        public Cliente BuscarCli(int id)
        {
            ControladoraPersona inst = ControladoraPersona.obtenerInstancia();

            Cliente lst = inst.BuscarCli(id);
            return lst;
        }

        public bool CambiarPass(int id, string pass)
        {
            ControladoraPersona inst = ControladoraPersona.obtenerInstancia();

            if (inst.CambiarPass(id, pass))
            {
                return true;
            }
            else
                return false;
        }

        public List<Cliente> lstClientes()
        {
            ControladoraPersona inst = ControladoraPersona.obtenerInstancia();
     
            List<Cliente> lst = inst.LstClientes();
            return lst;
         
        }


        public int IniciarSesion(string user, string pass)
        {
            ControladoraPersona inst = ControladoraPersona.obtenerInstancia();

            int lst = inst.IniciarSesion(user, pass);

            return lst;
        }

        #endregion


        #region Vehiculos
        public List<Vehiculo> LstVehiculos()
        {
          Controladoraitem inst = Controladoraitem.ObtenerInstancia();
       
            List<Vehiculo> lst = inst.LstVehiculos();
            return lst;
        }


        public bool AltaVehiculos(Vehiculo vehiculo)
        {
            Controladoraitem inst = Controladoraitem.ObtenerInstancia();

            if (inst.AltaVehiculo(vehiculo))
            {
                return true;
            }
            else
                return false;
        }


        public Vehiculo BuscarVeh(int id)
        {
            Controladoraitem inst = Controladoraitem.ObtenerInstancia();

            Vehiculo lst = inst.BuscarVeh(id);
            return lst;
        }


        public List<Vehiculo> BuscarVehLst(int id)
        {
            Controladoraitem inst = Controladoraitem.ObtenerInstancia();

            List<Vehiculo> lst = inst.BuscarVehLst(id);
            return lst;
        }

        public List<Reparacion_Vehiculo> LstVehRepRepar(int id)
        {
            Controladoraitem inst = Controladoraitem.ObtenerInstancia();

            List<Reparacion_Vehiculo> lst = inst.LstVehRepRepar(id);
            return lst;
        }

        public bool ModVehiculo(Vehiculo vehiculo)
        {
            Controladoraitem inst = Controladoraitem.ObtenerInstancia();

            if (inst.ModVehiculo(vehiculo))
            {
                return true;
            }
            else
                return false;
        }

        public bool BajaVehiculo(int id)
        {
            Controladoraitem inst = Controladoraitem.ObtenerInstancia();

            if (inst.BajaVehiculo(id))
            {
                return true;
            }
            else
                return false;
        }
        #endregion

        #region Reparacion
        public Reparacion BuscarRepar(int id)
        {
            Controladoraitem inst = Controladoraitem.ObtenerInstancia();

            Reparacion lst = inst.BuscarRepar(id);
            return lst;
        }

        public Reparacion BuscarReparAgen(int id)
        {
            Controladoraitem inst = Controladoraitem.ObtenerInstancia();

            Reparacion lst = inst.BuscarReparAgen(id);
            return lst;
        }


        public List<Reparacion> LstReparReparadas()
        {
            Controladoraitem inst = Controladoraitem.ObtenerInstancia();

            List<Reparacion> lst = inst.LstReparReparadas();
            return lst;
        }

        public List<Reparacion> LstReparEnRep()
        {
            Controladoraitem inst = Controladoraitem.ObtenerInstancia();

            List<Reparacion> lst = inst.LstReparEnRep();
            return lst;
        }

        public List<Reparacion> LstReparRepDadoFch(string fchI, string fchaF)
        {
            Controladoraitem inst = Controladoraitem.ObtenerInstancia();

            List<Reparacion> lst = inst.LstReparRepDadoFch(fchI, fchaF);
            return lst;
        }


        public List<Reparacion> LstReparAgend()
        {
            Controladoraitem inst = Controladoraitem.ObtenerInstancia();

            List<Reparacion> lst = inst.LstReparAgend();
            return lst;
        }

        public bool UniqueVehRes(int id, string fchaRes)
        {

            Controladoraitem inst = Controladoraitem.ObtenerInstancia();
            if (inst.UniqueVehRes(id, fchaRes))
            {

                return true;
            }
            else
                return false;
        }


        public bool AltaReparEnRep(Reparacion reparacion)
        {
            Controladoraitem inst = Controladoraitem.ObtenerInstancia();

            if (inst.AltaReparEnRep(reparacion))
            {
                return true;
            }
            else
                return false;
        }

        public bool AltaRepar(Reparacion reparacion)
        {
            Controladoraitem inst = Controladoraitem.ObtenerInstancia();

            if (inst.AltaRepar(reparacion))
            {
                return true;
            }
            else
                return false;
        }

        public bool AltaReparCli(Reparacion reparacion)
        {
            Controladoraitem inst = Controladoraitem.ObtenerInstancia();

            if (inst.AltaReparCli(reparacion))
            {
                return true;
            }
            else
                return false;
        }

        public bool BajaRepar(int id)
        {
            Controladoraitem inst = Controladoraitem.ObtenerInstancia();

            if (inst.BajaRepar(id))
            {
                return true;
            }
            else
                return false;
        }

        public bool ModRepar(Reparacion repar)
        {
            Controladoraitem inst = Controladoraitem.ObtenerInstancia();

            if (inst.ModRepar(repar))
            {
                return true;
            }
            else
                return false;
        }

        #endregion

        #region
        public bool IniciarSesionA(string user, string pass)
        {
            ControladoraPersona ins = ControladoraPersona.obtenerInstancia();

            bool lst = ins.IniciarSesionA(user, pass);

            return lst;
        }




        #endregion


        #region Mecanico
       

        public List<Mecanico> LstMecanico()
        {
            ControladoraPersona inst = ControladoraPersona.obtenerInstancia();

            List<Mecanico> lst = inst.LstMecanico();
            return lst;
        }

        public Mecanico BuscarMec(int id)
        {
            ControladoraPersona inst = ControladoraPersona.obtenerInstancia();

            Mecanico lst = inst.BuscarMec(id);
            return lst;
        }


       

        public bool AltaMecanico(Mecanico mecanico)
        {
            ControladoraPersona inst = ControladoraPersona.obtenerInstancia();

            if (inst.AltaMecanico(mecanico))
            {
                return true;
            }
            else
                return false;
        }

        public bool ModMecanico (Mecanico mecanico)
        {
            ControladoraPersona inst = ControladoraPersona.obtenerInstancia();

            if (inst.ModMecanico(mecanico))
            {
                return true;
            }
            else
                return false;
        }

        public bool BajaMecanico(int id)
        {
            ControladoraPersona inst = ControladoraPersona.obtenerInstancia();

            if (inst.BajaMecanico(id))
            {
                return true;
            }
            else
                return false;
        }


        #endregion

        #region Reparacion_Repuesto

        public List<Reparacion_Repuesto> lstRepar_Repu(int id)
        {
            Controladoraitem inst = Controladoraitem.ObtenerInstancia();

            List<Reparacion_Repuesto> lst = inst.lstRepar_Repu(id);

            return lst;
        }

        public bool AltaRepar_Repu(Reparacion_Repuesto rep_rep)
        {
            Controladoraitem inst = Controladoraitem.ObtenerInstancia();

            if (inst.AltaRepar_Repu(rep_rep))
            {
                return true;
            }
            else
                return false;
        }

        public bool BajaRepar_Repu(int IdRepuesto, int idRepar)
        {
            Controladoraitem inst = Controladoraitem.ObtenerInstancia();

            if (inst.BajaRepar_Repu(IdRepuesto, idRepar))
            {
                return true;
            }
            else
                return false;
        }

        public bool Reparacion_Repuesto_Cant(string cant, int idRepar, int idRepuesto)
        {
            Controladoraitem inst = Controladoraitem.ObtenerInstancia();

            if (inst.Reparacion_Repuesto_Cant(cant, idRepar, idRepuesto))
            {
                return true;
            }
            else
                return false;
        }



        public bool UniqueRepar_Repar(int idRepar, int idRepuesto)
        {

            Controladoraitem inst = Controladoraitem.ObtenerInstancia();
            if (inst.UniqueRepar_Repar(idRepar, idRepuesto))
            {

                return true;
            }
            else
                return false;
        }



        #endregion




    }

}
