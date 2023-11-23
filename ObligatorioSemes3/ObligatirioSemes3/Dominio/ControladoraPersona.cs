using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ObligatirioSemes3.Dominio
{
    public class ControladoraPersona
    {
        private static List<Persona> _lstpersonas;
        private static ControladoraPersona _instancia;


        

        public static ControladoraPersona obtenerInstancia()
        {
            if(_instancia == null)
            {
                _instancia = new ControladoraPersona();
                _lstpersonas = new List<Persona>();
            }
            return _instancia;
        }


        public  List<Persona> ListaPersonas()
        {
            List<Persona> Adm = new List<Persona>();
            foreach (Persona unaPersona in _lstpersonas)
            {
                if (unaPersona.GetType() == typeof(Admin))
                {
                    Adm.Add(unaPersona);
                    
                }
            }
            return Adm;
                  
          
             
        }
        #region abmAdmin
        public Admin BuscarAdmin(int pId)
        {
            foreach (Admin unAdmin in _lstpersonas)
            {
                if (unAdmin.Id == pId)
                    return unAdmin;
            }
            return null;
        }

        public bool AltaAdmin(Admin pAdmin)
        {
            Admin admin = BuscarAdmin(pAdmin.Id);
            if(admin==null)
            {
                _lstpersonas.Add(pAdmin);
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool BajaAdmin(int pId)
        {
            Admin admin = BuscarAdmin(pId);
            if(admin != null)
            {
                _lstpersonas.Remove(admin);
                return true;
            }
            return false;
        }

        public bool ModificarAdmin(int pId, string pNombre, string pApellido, string pPassword, string pUser)
        {

            Admin unAdmin = this.BuscarAdmin(pId);
            if (unAdmin != null) { 
            
                unAdmin.Nombre = pNombre;
                unAdmin.Apellido = pApellido;
                unAdmin.Password = pPassword;
                unAdmin.User = pUser;

                return true;
            }

            return false;

        }



        #endregion









    }
}