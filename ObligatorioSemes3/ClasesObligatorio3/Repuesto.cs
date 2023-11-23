using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ObligatirioSemes3.Dominio
{
    public class Repuesto
    {
        private int _id;
        private string _nombre;
        private string _desc;
        private int _costo;
        private string _stock;
        private string _tipo;

        public int Id { get => _id; set => _id = value; }
        public string Desc { get => _desc; set => _desc = value; }
        public int Costo { get => _costo; set => _costo = value; }
        public string Tipo { get => _tipo; set => _tipo = value; }
        public string Nombre { get => _nombre; set => _nombre = value; }
        public string Stock { get => _stock; set => _stock = value; }

        public Repuesto()
        {

        }

        public override string ToString()
        {
            return Id + " "+ Nombre + " " + Costo + " " + Stock.ToString();
        }
    }
}