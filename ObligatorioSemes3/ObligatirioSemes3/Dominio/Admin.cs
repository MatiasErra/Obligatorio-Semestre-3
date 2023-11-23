using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ObligatirioSemes3.Dominio
{
    public class Admin:Usuario
    {
  

        public Admin(int id, string nombre, string apellido, string password, string user) : base(id, nombre, apellido, password, user)
    { }

        public override string ToString()
        {
            return this.User + " " + this.Nombre.ToString();
        }
     
    }
}