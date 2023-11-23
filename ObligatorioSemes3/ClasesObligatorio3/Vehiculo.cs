using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ObligatirioSemes3.Dominio
{
    public class Vehiculo
    {
        private int _idVehiculo;
        private string _matricula;
        private string _marca;
        private string _modelo;
        private string _año;
        private string _color;
        private Cliente _Cli;


        public int IdVehiculo { get => _idVehiculo; set => _idVehiculo = value; }
        public string Matricula { get => _matricula; set => _matricula = value; }
        public string Marca { get => _marca; set => _marca = value; }
        public string Modelo { get => _modelo; set => _modelo = value; }
        public string Año { get => _año; set => _año = value; }
        public string Color { get => _color; set => _color = value; }
        public Cliente Cli { get => _Cli; set => _Cli = value; }


        public Vehiculo()
        {
        }

        public override string ToString()
        {
            return IdVehiculo + " " + Matricula + " " + Año + " "  +  Cli.Nombre.ToString();
        }

    }
     
}