using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2014214826
{
    public class Evaluacion
    {
        public EstadoEvaluacion _Estadoevaluacion;
        public TipoEvaluacion _TipoEvaluacion;
        public Plan _Plan { get; set; }
        public LineaTelefonica _LineaTelefonica { get; set; }
        public Cliente _Cliente { set; get; }
        public CentroAtencion _Centro { get; set; }
        public Trabajador _Trabajador { get; set; }
        EquipoCelular _EquipoCelular;

        public Evaluacion()
        {
            _Estadoevaluacion = new EstadoEvaluacion();
            _TipoEvaluacion = new TipoEvaluacion();
            _EquipoCelular = new EquipoCelular();
        }

        public Evaluacion(string estado, string tipo, Plan plan, LineaTelefonica linea, Cliente cliente, CentroAtencion centro, Trabajador trabajador, string modelocelular, string marcacelular)
        {
            _Estadoevaluacion = new EstadoEvaluacion(estado);
            _TipoEvaluacion = new TipoEvaluacion(tipo);
            _Plan = plan;
            _LineaTelefonica = linea;
            _Cliente = cliente;
            _Centro = centro;
            _Trabajador = trabajador;
            _EquipoCelular = new EquipoCelular(modelocelular, marcacelular);
        }

    }
}
