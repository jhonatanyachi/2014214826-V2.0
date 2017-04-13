using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2014214826
{
    public class CentroAtencion
    {
        public string _Centro { get; set; }
        public Direccion _Direccion { get; set; }
        public CentroAtencion()
        {
            _Direccion = new Direccion();
        }
        public CentroAtencion(string centro, int codigoubigeo, Departamento departamento, Provincia provincia, Distrito distrito, string direccion)
        {
            _Centro = centro;
            _Direccion = new Direccion(codigoubigeo, departamento, provincia, distrito, direccion);
        }
    }
}
