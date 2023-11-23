using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ObligatirioSemes3.Dominio;
using ControladorasOblig;

namespace ControladorasOblig
{

    public class Automotriz
    {
        private static Automotriz _instancia;
        private static ControladoraPersona _controladoraPersona;
        private static Controladoraitem _controladoraitem;

        public static Controladoraitem Controladoraitem { get => _controladoraitem; set => _controladoraitem = value; }
        public ControladoraPersona ControladoraPersona { get => _controladoraPersona; set => _controladoraPersona = value; }

        public static Automotriz obtenerInstancia()
        {
            if (_instancia == null)
            {
                _instancia = new Automotriz();
                _controladoraPersona = ControladoraPersona.obtenerInstancia();
                _controladoraitem = Controladoraitem.ObtenerInstancia();

            }
            return _instancia;
        }

        //Cont c = new Cont.ObtIns();
    }
}