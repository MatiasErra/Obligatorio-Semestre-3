using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ObligatirioSemes3.Dominio
{
    public class Controladoraitem
    {
        private static List<Repuesto> _lstrepuestos;
        private static Controladoraitem _instancia;

        public static Controladoraitem ObtenerInstancia()
        {
            if(_instancia ==null)
            {
                _instancia = new Controladoraitem();
                _lstrepuestos = new List<Repuesto>();
            }
            return _instancia;
        }


        public List<Repuesto> ListaRep()
        {
            return _lstrepuestos;
        }

        public Repuesto BuscarRepuesto(int pId)
        {

            foreach (Repuesto unrepuesto in _lstrepuestos)
            {

                if (unrepuesto.Id == pId)

                    return unrepuesto;



            }
            return null;

        }

 

        public bool AltaRepuesto(Repuesto pRepuesto)
        {
            Repuesto unRepuestos = BuscarRepuesto(pRepuesto.Id);
            if (unRepuestos == null)
            {

                _lstrepuestos.Add(pRepuesto);
                return true;

            }
            else
            {

                return false;

            }

        }


        public bool BajaRepuesto(int pId)
        {


            Repuesto unRepuestos = BuscarRepuesto(pId);
            if (unRepuestos != null)
            {

                _lstrepuestos.Remove(unRepuestos);
                return true;

            }

            return false;
        }

        public bool ModificarRepuesto(int pId, string pDescripcion, int pCosto, string pTipo)

        {
            Repuesto unRepuestos = BuscarRepuesto(pId);
            if (unRepuestos != null)
            {

                unRepuestos.Desc = pDescripcion;
                unRepuestos.Costo = pCosto;
                unRepuestos.Tipo = pTipo;


                return true;
            }
            else 
            return false;

        }

    }
}