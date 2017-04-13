using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2014214826
{
    public class EstadoEvaluacion
    {
        public string _Detalle { get; set; }

        public EstadoEvaluacion()
        {

        }
        public EstadoEvaluacion(string detalle)
        {
            _Detalle = detalle;
        }
    }
}
