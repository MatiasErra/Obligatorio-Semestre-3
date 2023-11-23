using ObligatirioSemes3.Dominio;
using persistenciaDB;
using System.Collections.Generic;


namespace ControladorasOblig
{
    public class ControladoraPersona
    {
        private static List<Persona> _lstpersonas;
        private static ControladoraPersona _instancia;





        public static ControladoraPersona obtenerInstancia()
        {
            if (_instancia == null)
            {
                _instancia = new ControladoraPersona();
                _lstpersonas = new List<Persona>();

            }
            return _instancia;
        }



        #region Admin

        public bool AltaAdmin(Admin Admin)
        {
            ControladoraP inst = ControladoraP.obtenerInstancia();

            if (inst.AltaAdmin(Admin))
            {
                return true;
            }
            else
                return false;
        }


        public bool BajaAdmin(int id)
        {
            ControladoraP inst = ControladoraP.obtenerInstancia();

            if (inst.BajaAdmin(id))
            {
                return true;
            }
            else
                return false;
        }



        public bool ModAdmin(Admin Admin)
        {
            ControladoraP inst = ControladoraP.obtenerInstancia();

            if (inst.ModAdmin(Admin))
            {
                return true;
            }
            else
                return false;
        }

        public Admin BuscarAdmin(int id)
        {
            ControladoraP inst = ControladoraP.obtenerInstancia();

            Admin lst = inst.BuscarAdmin(id);
            return lst;
        }



        public List<Admin> lstAdmin()
        {
            ControladoraP inst = ControladoraP.obtenerInstancia();

            List<Admin> lst = inst.lstAdmin();
            return lst;
        }





        public bool IniciarSesionA(string user, string pass)
        {
            ControladoraP inst = ControladoraP.obtenerInstancia();

            bool lst = inst.IniciarSesionA(user, pass);

            return lst;
        }

        public bool IniciarSesionSA(string user, string pass)
        {
            ControladoraP inst = ControladoraP.obtenerInstancia();

            bool lst = inst.IniciarSesionSA(user, pass);

            return lst;
        }
        #endregion

        #region Cliente


        public bool AltaCliente(Cliente cliente)
        {
            ControladoraP inst = ControladoraP.obtenerInstancia();

            if (inst.AltaCliente(cliente))
            {
                return true;
            }
            else
                return false;
        }


        public bool BajaCliente(int id)
        {
            ControladoraP inst = ControladoraP.obtenerInstancia();

            if (inst.BajaCliente(id))
            {
                return true;
            }
            else
                return false;
        }



        public bool ModCliente(Cliente cliente)
        {
            ControladoraP inst = ControladoraP.obtenerInstancia();

            if (inst.ModCliente(cliente))
            {
                return true;
            }
            else
                return false;
        }

        public bool CambiarPass(int id, string pass)
        {
            ControladoraP inst = ControladoraP.obtenerInstancia();

            if (inst.CambiarPass(id, pass))
            {
                return true;
            }
            else
                return false;
        }

        public Cliente BuscarCli(int id)
        {
            ControladoraP inst = ControladoraP.obtenerInstancia();

            Cliente lst = inst.BuscarCli(id);
            return lst;
        }



        public List<Cliente> LstClientes()
        {
            ControladoraP inst = ControladoraP.obtenerInstancia();

            List<Cliente> lst = inst.LstClientes();
            return lst;
        }



        public int IniciarSesion(string user, string pass)
        {
            ControladoraP inst = ControladoraP.obtenerInstancia();

            int lst = inst.IniciarSesion(user, pass);

            return lst;
        }

        #endregion


      

        #region Mecanico

        public List<Mecanico> LstMecanico()
        {
            ControladoraP inst = ControladoraP.obtenerInstancia();

            List<Mecanico> lst = inst.lstMecanico();
            return lst;
        }


        public Mecanico BuscarMec(int id)
        {
            ControladoraP inst = ControladoraP.obtenerInstancia();

            Mecanico lst = inst.BuscarMec(id);
            return lst;
        }
        public bool AltaMecanico(Mecanico mecanico)
        {
            ControladoraP inst = ControladoraP.obtenerInstancia();

            if (inst.AltaMecanico(mecanico))
            {
                return true;
            }
            else
                return false;
        }

        public bool ModMecanico(Mecanico mecanico)
        {
            ControladoraP inst = ControladoraP.obtenerInstancia();

            if (inst.ModMecanico(mecanico))
            {
                return true;
            }
            else
                return false;
        }


        public bool BajaMecanico(int id)
        {
            ControladoraP inst = ControladoraP.obtenerInstancia();

            if (inst.BajaMecanico(id))
            {
                return true;
            }
            else
                return false;
        }



        #endregion



    }


}
