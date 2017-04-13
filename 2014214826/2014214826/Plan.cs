using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2014214826
{
    public class Plan
    {
        public double Costo { set; get; }
        public TipoPlan Tipoplan;

        public Plan()
        {
            Tipoplan = new TipoPlan();
        }
        public Plan(double costo, string detalle)
        {
            Tipoplan = new TipoPlan(detalle);
            Costo = costo;
        }
    }
}
