using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ObligatirioSemes3.Dominio
{
    public class SuperAdmin:Usuario
    {

        public override string ToString()
        {
            return base.ToString();
        }


        public SuperAdmin(int id, string nombre, string apellido, string password, string user) : base(id, nombre, apellido, password, user)
        { }
    }
}