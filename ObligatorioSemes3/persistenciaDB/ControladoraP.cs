using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ObligatirioSemes3.Dominio;
 
namespace persistenciaDB
{
    public class ControladoraP
    {

        private static ControladoraP _instancia;

        public static ControladoraP obtenerInstancia()
        {
            if (_instancia == null)
            {
                _instancia = new ControladoraP();


            }
            return _instancia;

        }
        public bool AltaCliente(Cliente Cliente)
        {
            return new pCliente().Cliente_Alta(Cliente);
        }


        public bool ModCliente(Cliente cliente)
        {
            return new pCliente().Cliente_Mod(cliente);
        }

        public bool BajaCliente(int id)
        {
            return new pCliente().Cliente_Baja(id);
        }


        public List<Cliente> LstClientes()
        {
            return new pCliente().Cliente_ObtenerTodos();
        }
        public Cliente BuscarCli(int id)
        {
            return new pCliente().BuscarCli(id);
        }

        public int IniciarSesion(string user, string pass)
        {
            return new pCliente().InicioSesion(user, pass);
        }

        public bool CambiarPass(int id, string pass)
        {
            return new pCliente().CambiarPass(id, pass);
        }


        public bool AltaVehiculo(Vehiculo vehiculo)
        {
            return new pVehiculo().Vehiculo_Alta(vehiculo);
        }


        public bool IniciarSesionA(string user, string pass)
        {
            return new pAdmin().IniciarSesionA(user, pass);
        }

        public bool IniciarSesionSA(string user, string pass)
        {
            return new pAdmin().IniciarSesionSA(user, pass);
        }

        public List<Reparacion_Vehiculo> LstVehRepRepar (int id)
        {
            return new pVehiculo().LstVehRepRepar(id);
        }

        public List<Vehiculo> LstVehiculos()
        {
            return new pVehiculo().Vehiculo_ObtenerTodos();
        }

        public Vehiculo BuscarVeh(int id)
        {
            return new pVehiculo().BuscarVeh(id);
        }

        public List<Vehiculo> BuscarVehLst(int id)
        {
            return new pVehiculo().BuscarlstVeh(id);
        }

        public bool ModVehiculo(Vehiculo vehiculo)
        {
            return new pVehiculo().Vehiculo_Mod(vehiculo);
        }

        public bool BajaVehiculo(int id)
        {
            return new pVehiculo().Vehiculo_Baja(id);
        }

        public Reparacion BuscarRepar(int id)
        {
            return new pReparacion().BuscarReparacion(id);
        }

       

        public Reparacion BuscarReparAgen(int id)
        {
            return new pReparacion().BuscarReparacionAgend(id);
        }

        public List<Reparacion> LstReparRepDadoFch(string fchI , string fchF)
        {
            return new pReparacion().Reparacion_ReparDadaFcha(fchI, fchF);
        }

        public List<Reparacion> LstReparReparadas()
        {
            return new pReparacion().Reparacion_Repar();
        }
        public List<Reparacion> LstReparTodas()
        {
            return new pReparacion().Reparacion_ReparTodos();
        }

        public List<Reparacion> LstReparAgend()
        {
            return new pReparacion().Reparacion_Agendado();
        }

        public List<Reparacion> LstReparEnRep()
        {
            return new pReparacion().Reparacion_ReparEnRep();
        }


        public bool AltaRepar(Reparacion repar)
        {
            return new pReparacion().Reparacion_Alta(repar);
        }


        public bool AltaReparEnRep(Reparacion repar)
        {
            return new pReparacion().ReparacionEnRep_Alta(repar);
        }

        public bool AltaReparCli(Reparacion repar)
        {
            return new pReparacion().Reparacion_AltaCli(repar);
        }


        public bool BajaRepar(int id)
        {
            return new pReparacion().Reparacion_Baja(id);
        }

        public bool ModRepar(Reparacion repar)
        {
            return new pReparacion().Reparacion_Mod(repar);
        }


        public List<Repuesto> LstRepues()
        {
            return new pRepuesto().Repuesto_ObtenerTodos();
        }

       

             public List<Repuesto> LstRepuesto_ORD()
        {
            return new pRepuesto().Repuesto_ORD();
        }

        public List<int> CantRepuesto()
        {
            return new pRepuesto().CantRepuesto();
        }

        public bool AltaRepues(Repuesto repu)
        {
            return new pRepuesto().Repuesto_Alta(repu);
        }

        public bool BajaRepues(int Id)
        {
            return new pRepuesto().Repuesto_Baja(Id);
        }

        public bool ModRepues(Repuesto repu)
        {
            return new pRepuesto().Repuesto_Mod(repu);
        }

        public Repuesto BuscarRepues(int id)
        {
            return new pRepuesto().BuscarRepues(id);
        }


        public List<Mecanico> lstMecanico()
        {
            return new pMecanico().Mecanico_ObtenerTodos();

        }

        public bool AltaMecanico(Mecanico mecanico)
        {
            return new pMecanico().Mecanico_Alta(mecanico);
        }

        public Mecanico BuscarMec(int id)
        {
            return new pMecanico().BuscarMec(id);

        }

        public bool ModMecanico(Mecanico mecanico)
        {


            return new pMecanico().Mecanico_Mod(mecanico);
        }

        public bool BajaMecanico(int id)
        {
            return new pMecanico().Mecanico_Baja(id);
        }


        public List<Reparacion_Repuesto> lstRepar_Repu(int id)
        {
            return new pReparacion_repuesto().Reparacion_RepTodos(id);

        }
        public bool AltaRepar_Repu(Reparacion_Repuesto Rep_Rep)
        {
            return new pReparacion_repuesto().Reparacion_Repuesto_Alta(Rep_Rep);
        }

        public bool BajaRepar_Repu(int IdRepuesto, int idRepar)
        {
            return new pReparacion_repuesto().Reparacion_Repuesto_Baja(IdRepuesto, idRepar);
        }
        public bool Reparacion_Repuesto_Cant(string cant, int idRepar, int idRepuesto)
        {
            return new pReparacion_repuesto().Reparacion_Repuesto_Cant(cant, idRepar, idRepuesto);
        }

        public List<Admin> lstAdmin()
        {
            return new pAdmin().Admin_ObtenerTodos();
        }
         
        public bool AltaAdmin(Admin admin)
        {
            return new pAdmin().AdminAlta(admin);
        }

        public bool BajaAdmin(int Id)
        {
            return new pAdmin().AdminBaja(Id);
        }

        public bool ModAdmin(Admin admin)
        {
            return new pAdmin().Admin_Mod(admin);
        }

        public Admin BuscarAdmin(int id)
        {
            return new pAdmin().BuscarAdmin(id);

        }


    }

   

}
