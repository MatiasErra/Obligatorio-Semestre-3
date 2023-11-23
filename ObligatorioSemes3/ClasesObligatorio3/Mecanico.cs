using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ObligatirioSemes3.Dominio
{
    public class Mecanico:Persona
    {
        private string _ci;
        private string _tel;
        private string _fchaIngreso;
        private double _valorHora;


        public string Ci { get => _ci; set => _ci = value; }
        public string Tel { get => _tel; set => _tel = value; }
        public string FchaIngreso { get => _fchaIngreso; set => _fchaIngreso = value; }
        public double ValorHora { get => _valorHora; set => _valorHora = value; }
   


    public override string ToString()
    {
        return Id + " " + Nombre + " " + Apellido.ToString();
    }


    public Mecanico( string nombre, string apellido, string ci, string tel, string fchaIngreso, double valorHora) : base(nombre, apellido)
    {

            Ci = ci;
            Tel = tel;
            FchaIngreso = fchaIngreso;
            ValorHora = valorHora;
     
        
    }

        public Mecanico()
        {
        }
    }
}