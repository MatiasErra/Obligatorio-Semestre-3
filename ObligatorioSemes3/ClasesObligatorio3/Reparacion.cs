using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ObligatirioSemes3.Dominio
{
    public class Reparacion

    {
        private int _idReparacion;
        private string _fchaEntrada;
        private string _fchaSalida;
        private string _fchaReservada;
        private string _fchaAgendada;
        private int _horas;
        private int _costo;
        private string _descripcion;
        private Vehiculo _vehiculo;
        private Mecanico  _mecanico;
     
        private string _tipo;
      

        public int Id{ get => _idReparacion; set => _idReparacion = value; }
        public string FchaEntrada { get => _fchaEntrada; set => _fchaEntrada = value; }
        public string FchaSalida { get => _fchaSalida; set => _fchaSalida = value; }
        public Vehiculo Vehiculo { get => _vehiculo; set => _vehiculo = value; }
        public string FchaReservada { get => _fchaReservada; set => _fchaReservada = value; }
        public string FchaAgendada { get => _fchaAgendada; set => _fchaAgendada = value; }
        public string Descripcion { get => _descripcion; set => _descripcion = value; }
        public string Tipo { get => _tipo; set => _tipo = value; }
        public Mecanico Mecanico { get => _mecanico; set => _mecanico = value; }
        public int Horas { get => _horas; set => _horas = value; }
        public int Costo { get => _costo; set => _costo = value; }

        public Reparacion()
        {
        

        }
        public override string ToString()
        {
            return Id + " " + FchaEntrada + " " + FchaSalida + " " +  Vehiculo.Cli.Nombre + " " + Vehiculo.Matricula + " $" + Costo +  " " + Tipo.ToString();
        }
    }
}