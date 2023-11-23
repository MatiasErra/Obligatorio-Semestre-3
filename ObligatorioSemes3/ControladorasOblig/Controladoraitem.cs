using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ObligatirioSemes3.Dominio;
using persistenciaDB;

namespace ControladorasOblig
{

    public class Controladoraitem
    {
     
        private static Controladoraitem _instancia;


        public static Controladoraitem ObtenerInstancia()
        {
            if(_instancia ==null)
            {
                _instancia = new Controladoraitem();
            
            }
            return _instancia;
        }

        #region Repuesto
        public bool AltaRepues(Repuesto repuesto)
        {
            ControladoraP inst = ControladoraP.obtenerInstancia();

            if (inst.AltaRepues(repuesto))
            {
                return true;
            }
            else
                return false;
        }


        public bool BajaRepues(int id)
        {
            ControladoraP inst = ControladoraP.obtenerInstancia();

            if (inst.BajaRepues(id))
            {
                return true;
            }
            else
                return false;
        }

        
        public bool ModRepues(Repuesto repuesto)
        {
            ControladoraP inst = ControladoraP.obtenerInstancia();
            if (inst.ModRepues(repuesto))
            {
                return true;
            }
            else
                return false;
        }


        public List<Repuesto> lstRepues()
        {
            ControladoraP inst = ControladoraP.obtenerInstancia();

            List<Repuesto> lst = inst.LstRepues();
            return lst;
        }

        public List<Repuesto> LstRepuesto_ORD()
        {
            ControladoraP inst = ControladoraP.obtenerInstancia();

            List<Repuesto> lst = inst.LstRepuesto_ORD();
            return lst;
        }
  

             public List<int> CantRepuesto()
        {
            ControladoraP inst = ControladoraP.obtenerInstancia();

            List<int> lst = inst.CantRepuesto();
            return lst;
        }
        public Repuesto BuscarRepues(int id)
        {
            ControladoraP inst = ControladoraP.obtenerInstancia();

            Repuesto lst = inst.BuscarRepues(id);
            return lst;
        }


        #endregion



        #region vehiculos
        public bool AltaVehiculo(Vehiculo vehiculo)
        {
            ControladoraP inst = ControladoraP.obtenerInstancia();

            if (inst.AltaVehiculo(vehiculo))
            {
                return true;
            }
            else
                return false;
        }

        public List<Vehiculo> LstVehiculos()
        {
            ControladoraP inst = ControladoraP.obtenerInstancia();

            List<Vehiculo> lst = inst.LstVehiculos();
            return lst;
        }


        public List<Vehiculo> BuscarVehLst(int id)
        {
            ControladoraP inst = ControladoraP.obtenerInstancia();

            List<Vehiculo> lst = inst.BuscarVehLst(id);
            return lst;
        }


             public List<Reparacion_Vehiculo> LstVehRepRepar(int id)
        {
            ControladoraP inst = ControladoraP.obtenerInstancia();

            List<Reparacion_Vehiculo> lst = inst.LstVehRepRepar(id);
            return lst;
        }


        public Vehiculo BuscarVeh(int id)
        {
            ControladoraP inst = ControladoraP.obtenerInstancia();

            Vehiculo lst = inst.BuscarVeh(id);
            return lst;
        }

        public bool ModVehiculo(Vehiculo vehiculo)
        {
            ControladoraP inst = ControladoraP.obtenerInstancia();

            if (inst.ModVehiculo(vehiculo))
            {
                return true;
            }
            else
                return false;
        }


        public bool BajaVehiculo(int id)
        {
            ControladoraP inst = ControladoraP.obtenerInstancia();

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
            ControladoraP inst = ControladoraP.obtenerInstancia();

            Reparacion lst = inst.BuscarRepar(id);
            return lst;
        }

        public Reparacion BuscarReparAgen(int id)
        {
            ControladoraP inst = ControladoraP.obtenerInstancia();

            Reparacion lst = inst.BuscarReparAgen(id);
            return lst;
        }

        public List<Reparacion> LstReparEnRep()
        {
            ControladoraP inst = ControladoraP.obtenerInstancia();

            List<Reparacion> lst = inst.LstReparEnRep();
            return lst;
        }

        public List<Reparacion> LstReparRepDadoFch(string fchI, string fchaF)
        {
            ControladoraP inst = ControladoraP.obtenerInstancia();

            List<Reparacion> lst = inst.LstReparRepDadoFch(fchI, fchaF);
            return lst;
        }

        

        public List<Reparacion> LstReparReparadas()
        {
            ControladoraP inst = ControladoraP.obtenerInstancia();

            List<Reparacion> lst = inst.LstReparReparadas();
            return lst;
        }


        public List<Reparacion> LstReparAgend()
        {
            ControladoraP inst = ControladoraP.obtenerInstancia();

            List<Reparacion> lst = inst.LstReparAgend();
            
          
            return lst;
        }



        public List<Reparacion> lstRepTod()
        {
            ControladoraP inst = ControladoraP.obtenerInstancia();

            List<Reparacion> lst = inst.LstReparTodas();


            return lst;
        }


        public bool UniqueVehRes(int id, string fchaRes )
        {

            List<Reparacion> lst = new List <Reparacion>(LstReparAgend());

         foreach (Reparacion rep in lst)
            {
                if(rep.Vehiculo.IdVehiculo == id && rep.FchaReservada == fchaRes )
                {
                    return false;
                }
              

            }


            return true;
        }



        public bool AltaRepar(Reparacion reparacion)
        {
            ControladoraP inst = ControladoraP.obtenerInstancia();

            if (inst.AltaRepar(reparacion))
            {
                return true;
            }
            else
                return false;
        }

        public bool AltaReparEnRep(Reparacion reparacion)
        {
            ControladoraP inst = ControladoraP.obtenerInstancia();

            if (inst.AltaReparEnRep(reparacion))
            {
                return true;
            }
            else
                return false;
        }

        public bool AltaReparCli(Reparacion reparacion)
        {
            ControladoraP inst = ControladoraP.obtenerInstancia();

            if (inst.AltaReparCli(reparacion))
            {
                return true;
            }
            else
                return false;
        }

        public bool BajaRepar(int id)
        {
            ControladoraP inst = ControladoraP.obtenerInstancia();

            if (inst.BajaRepar(id))
            {
                return true;
            }
            else
                return false;
        }

        public bool ModRepar(Reparacion repar)
        {
            ControladoraP inst = ControladoraP.obtenerInstancia();

            if (inst.ModRepar(repar))
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
            ControladoraP inst = ControladoraP.obtenerInstancia();

            List<Reparacion_Repuesto> lst = inst.lstRepar_Repu(id);

            return lst;
        }


        public bool UniqueRepar_Repar(int idRepar, int idRepuesto)
        {

            List<Reparacion_Repuesto> lst = new List<Reparacion_Repuesto> (lstRepar_Repu(idRepar));

            foreach (Reparacion_Repuesto rep in lst)
            {
                if (rep.Reparacion.Id == idRepar && rep.Repuesto.Id == idRepuesto)
                {
                    return false;
                }


            }


            return true;
        }


        public bool AltaRepar_Repu (Reparacion_Repuesto rep_rep)
        {
            ControladoraP inst = ControladoraP.obtenerInstancia();

            if (inst.AltaRepar_Repu(rep_rep))
            {
                return true;
            }
            else
                return false;
        }

        public bool BajaRepar_Repu(int IdRepuesto, int idRepar)
        {
            ControladoraP inst = ControladoraP.obtenerInstancia();

            if (inst.BajaRepar_Repu(IdRepuesto, idRepar))
            {
                return true;
            }
            else
                return false;
        }


        public bool Reparacion_Repuesto_Cant(string cant, int idRepar, int idRepuesto)
        {
            ControladoraP inst = ControladoraP.obtenerInstancia();

            if (inst.Reparacion_Repuesto_Cant(cant, idRepar , idRepuesto))
            {
                return true;
            }
            else
                return false;
        }





        #endregion



    }
}