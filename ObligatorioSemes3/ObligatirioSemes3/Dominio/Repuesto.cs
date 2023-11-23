using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ObligatirioSemes3.Dominio
{
    public class Repuesto
    {
        private int _id;
        private string _desc;
        private int _costo;
        private string _tipo;

        public int Id { get => _id; set => _id = value; }
        public string Desc { get => _desc; set => _desc = value; }
        public int Costo { get => _costo; set => _costo = value; }
        public string Tipo { get => _tipo; set => _tipo = value; }


        public Repuesto(int id, string desc, int costo, string tipo)
        {
            Id = id  ;
            Desc =  desc ;
            Costo = costo  ;
            Tipo = tipo  ;

        }

        public override string ToString()
        {
            return Id + " " + Costo + " " + Tipo.ToString();
        }
    }
}