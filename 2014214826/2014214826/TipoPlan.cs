using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2014214826
{
    public class TipoPlan
    {
        //postpago,prepago
        public string _Detalle { get; set; }
        public TipoPlan()
        {

        }
        public TipoPlan(string detalle)
        {
            _Detalle = detalle;
        }
    }
}
