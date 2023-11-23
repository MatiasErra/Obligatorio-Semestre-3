using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ObligatirioSemes3.Dominio
{
    public class Admin:Usuario
    {
  

        public Admin( string nombre, string apellido, string password, string user) : base( nombre, apellido, password, user)
    { }

        public override string ToString()
        {
            return this.Id + " " +  this.User + " " + this.Nombre.ToString();
        }
     


        public Admin()
        { }
    }
}