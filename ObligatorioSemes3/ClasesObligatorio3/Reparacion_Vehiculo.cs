using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ObligatirioSemes3.Dominio
{
    public class Reparacion_Vehiculo
    {
        private string _fchaSalida;
        private string _matricula;
        private string _modelo;
        private int _costo;

        public string FchaSalida { get => _fchaSalida; set => _fchaSalida = value; }
        public string Matricula { get => _matricula; set => _matricula = value; }
        public string Modelo { get => _modelo; set => _modelo = value; }
        public int Costo { get => _costo; set => _costo = value; }

        public override string ToString()
        {
            return FchaSalida + " " + Matricula + " " + Modelo + " " + Costo.ToString();
        }

    }
}
