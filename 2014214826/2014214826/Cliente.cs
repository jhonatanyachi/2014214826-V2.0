using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2014214826
{
    public class Cliente
    {
        public string _Nombre { get; set; }
        public int _Dni { get; set; }

        public Cliente()
        {
        }

        public Cliente(string nombre, int dni)
        {
            _Nombre = nombre;
            _Dni = dni;
        }
    }
}
