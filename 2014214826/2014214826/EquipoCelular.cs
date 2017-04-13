using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2014214826
{
    public class EquipoCelular
    {
        public string Modelo { get; set; }
        public string Marca { get; set; }

        public EquipoCelular()
        {
        }
        public EquipoCelular(string modelo, string marca)
        {
            Modelo = modelo;
            Marca = marca;
        }
    }
}
