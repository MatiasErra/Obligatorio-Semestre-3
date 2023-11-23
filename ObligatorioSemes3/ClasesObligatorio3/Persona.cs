using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ObligatirioSemes3.Dominio
{
    public abstract class Persona
    {
        private int _id;
        private string _nombre;
        private string _apellido;

    
 
        public int Id { get => _id; set => _id = value; }
        public string Nombre { get => _nombre; set => _nombre = value; }
        public string Apellido { get => _apellido; set => _apellido = value; }

        public Persona(string nombre, string apellido)
        {
          
            Nombre = nombre;
            Apellido = apellido;
        
        }
        public Persona()
        {

        }

        public Persona(int id, string nombre, string apellido)
        {
            Id = id;
            Nombre = nombre;
            Apellido = apellido;

        }
    }
}