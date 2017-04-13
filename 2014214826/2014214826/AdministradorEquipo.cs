using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2014214826
{
    public class AdministradorEquipo
    {
        EquipoCelular EquipoCelular;
        public AdministradorEquipo()
        {
            EquipoCelular = new EquipoCelular();
        }
        public AdministradorEquipo(string marca, string modelo)
        {
            EquipoCelular = new EquipoCelular(modelo, marca);
        }
    }
}
