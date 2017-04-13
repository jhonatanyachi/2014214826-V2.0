using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2014214826
{
    public class Departamento
    {
        public string _Detalle { get; set; }
        Provincia _Provincia;
        public Departamento()
        {
            _Provincia = new Provincia();
        }
        public Departamento(string detalle, string provincia, string distrito)
        {
            _Detalle = detalle;
            _Provincia = new Provincia(provincia, distrito);
        }
    }
}
