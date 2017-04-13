using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2014214826
{
    public class TipoPago
    {
        public string _Detalle { get; set; }
        public TipoPago()
        {

        }
        public TipoPago(string detalle)
        {
            _Detalle = detalle;
        }
    }
}
