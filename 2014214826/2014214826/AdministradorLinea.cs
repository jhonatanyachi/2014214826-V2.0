using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2014214826
{
    public class AdministradorLinea
    {
        LineaTelefonica _Linea;

        public AdministradorLinea()
        {
            _Linea = new LineaTelefonica();
        }
        public AdministradorLinea(string linea, int numerolinea)
        {
            _Linea = new LineaTelefonica(linea, numerolinea);
        }
    }
}
