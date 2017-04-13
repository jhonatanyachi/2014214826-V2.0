using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2014214826
{
    public class Venta
    {
        public Evaluacion _Evaluacion;
        public LineaTelefonica _LineaTelefonica;
        public Cliente _Cliente { set; get; }
        public TipoPago _Tipopago;
        public Contrato _Contrato;
        public CentroAtencion _Centro { get; set; }

        public Venta()
        {
            _Evaluacion = new Evaluacion();
            _LineaTelefonica = new LineaTelefonica();
            _Tipopago = new TipoPago();
            _Contrato = new Contrato();
        }

        public Venta(Cliente cliente, string estado, string tipoevaluacion, Plan plan, string _linea, int numerolinea, string tipopago, string contrato, CentroAtencion centro, Trabajador trabajador, string modelo, string marca)
        {
            _Evaluacion = new Evaluacion(estado, tipoevaluacion, plan, _LineaTelefonica, cliente, centro, trabajador, modelo, marca);
            _LineaTelefonica = new LineaTelefonica(_linea, numerolinea);
            _Tipopago = new TipoPago(tipopago);
            _Contrato = new Contrato(contrato);
            _Centro = centro;
            _Cliente = cliente;
        }
    }
}
