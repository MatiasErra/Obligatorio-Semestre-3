using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ObligatirioSemes3.Dominio
{
    public class Usuario : Persona
    {
        private string _user;
        private string _password;

 
        public string Password { get => _password; set => _password = value; }
        public string User { get => _user; set => _user = value; }  

        public Usuario(int id, string nombre, string apellido, string password, string user) : base(id, nombre, apellido)
        {
            Password = password;
            User = user;
        }

    }
}