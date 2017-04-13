using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2014214826
{
    public class Direccion
    {
        public string _Direccion { get; set; }
        Ubigeo _Ubigeo;
        public Direccion()
        {
            _Ubigeo = new Ubigeo();
        }
        public Direccion(int codigo, Departamento departamento, Provincia provincia, Distrito distrito, string direccion)
        {
            _Ubigeo = new Ubigeo(codigo, departamento, distrito, provincia);
            _Direccion = direccion;
        }
    }
}
