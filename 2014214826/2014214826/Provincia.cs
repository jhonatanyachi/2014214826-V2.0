using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2014214826
{
    public class Provincia
    {
        public string _Detalle { get; set; }
        Distrito _Distrito;
        public Provincia()
        {
            _Distrito = new Distrito();
        }
        public Provincia(string detalle, string distrito)
        {
            _Detalle = detalle;
            _Distrito = new Distrito(distrito);
        }
    }
}
