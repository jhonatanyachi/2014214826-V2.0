using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2014214826
{
    public class Ubigeo
    {
        public int _Codigo { get; set; }
        public Departamento Departamento { get; set; }
        public Provincia Provincia { get; set; }
        public Distrito Distrito { get; set; }
        public Ubigeo()
        {
        }
        public Ubigeo(int codigo, Departamento departamento, Distrito distrito, Provincia provincia)
        {
            _Codigo = codigo;
            Departamento = departamento;
            Provincia = provincia;
            Distrito = distrito;
        }
    }
}
