using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControladorasOblig
{
    public class Cont
    {
        private static Cont _instancia;

        public static Cont ObtIns()
        {
            if(_instancia== null)
            {
                _instancia = new Cont();
            }
            return _instancia;
        }
    }
}
