using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2014214826
{
    public class Trabajador
    {
        public string Nombre { get; set; }
        public int Codigo { get; set; }
        public TipoTrabajador Tipotrabajador { get; set; }

        public Trabajador()
        {
            Tipotrabajador = new TipoTrabajador();
        }
        public Trabajador(int codigo, string nombre, string descripcion)
        {
            Codigo = codigo;
            Nombre = nombre;
            Tipotrabajador = new TipoTrabajador(descripcion);
        }
    }
}
