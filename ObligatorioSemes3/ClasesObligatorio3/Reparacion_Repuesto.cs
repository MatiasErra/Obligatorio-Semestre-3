using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObligatirioSemes3.Dominio
{
   public class Reparacion_Repuesto
    {
        private Reparacion _reparacion;
        private Repuesto _repuesto;
        private string _cant;

        public Reparacion Reparacion { get => _reparacion; set => _reparacion = value; }
        public Repuesto Repuesto { get => _repuesto; set => _repuesto = value; }
        public string Cant { get => _cant; set => _cant = value; }

        public override string ToString()
        {
           return Repuesto.Id + " " + Repuesto.Nombre + " " + Cant.ToString();
        }
    }
}
