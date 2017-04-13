using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2014214826
{
    public class TipoTrabajador
    {
        public string _Descripcion { get; set; }

        public TipoTrabajador()
        {
        }
        public TipoTrabajador(string descripcion)
        {
            _Descripcion = descripcion;
        }
    }
}
