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

        public Usuario(string nombre, string apellido, string password, string user) : base( nombre, apellido)
        {
            Password = password;
            User = user;
        }
        public Usuario()
        {

        }
        public Usuario(int Id, string nombre, string apellido, string password, string user) : base(Id, nombre, apellido)
        {
            Password = password;
            User = user;
        }

    }
}