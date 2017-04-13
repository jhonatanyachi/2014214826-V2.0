using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2014214826
{
    public class LineaTelefonica
    {
        public int _Numerolinea { get; set; }
        public TipoLinea _Tipolinea;
        public LineaTelefonica()
        {
            _Tipolinea = new TipoLinea();
        }
        public LineaTelefonica(string detalle, int numero)
        {
            _Numerolinea = numero;
            _Tipolinea = new TipoLinea(detalle);
        }
    }
}
