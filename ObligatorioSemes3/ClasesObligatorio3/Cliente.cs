using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ObligatirioSemes3.Dominio
{
    public class Cliente:Usuario
    {

        private int _ci;
        private int _tel;
        private string _dir;
        private string _mail;
        private string _fchRegistro;

        public Cliente(string nombre, string apellido, string password, string user, int ci, int tel, string dir, string mail, string fchRegistro) : base(nombre, apellido, password, user)
        {
            Ci = ci;
            Tel = tel;
            Dir = dir;
            Mail = mail;
            FchRegistro = fchRegistro;

        }

        public Cliente()
        {

        }

        public Cliente(int Id, string nombre, string apellido, string password, string user, int ci, int tel, string dir, string mail, string fchRegistro) : base(Id, nombre, apellido, password, user)
        {
            Ci = ci;
            Tel = tel;
            Dir = dir;
            Mail = mail;
            FchRegistro = fchRegistro;

        }
        public int Ci { get => _ci; set => _ci = value; }
        public int Tel { get => _tel; set => _tel = value; }
        public string Dir { get => _dir; set => _dir = value; }
        public string Mail { get => _mail; set => _mail = value; }
        public string FchRegistro { get => _fchRegistro; set => _fchRegistro = value; }
       

        public override string ToString()
        {
            return this.Id + " " + this.User + " " + this.Nombre.ToString();
        }
    }
}