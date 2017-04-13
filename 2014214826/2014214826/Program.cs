using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace _2014214826
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Cliente> _Cliente = new List<Cliente>();
            _Cliente.Add(new Cliente("Jhonatan", 74526516));
            _Cliente.Add(new Cliente("Rocio", 7463956));
            _Cliente.Add(new Cliente("Maria Claudia", 56325684));
            _Cliente.Add(new Cliente("Miriam", 15236598));
            _Cliente.Add(new Cliente("Javier", 58695213));
            _Cliente.Add(new Cliente("Rodrigo", 58695326));

            List<Plan> _Plan = new List<Plan>();
            _Plan.Add(new Plan(60, "prepago"));
            _Plan.Add(new Plan(45, "postpago"));
            _Plan.Add(new Plan(120, "postpago"));

            List<Distrito> _Distrito = new List<Distrito>();
            _Distrito.Add(new Distrito("La Molina"));
            _Distrito.Add(new Distrito("Luana"));

            List<Provincia> _Provincia = new List<Provincia>();
            _Provincia.Add(new Provincia("Lima", "La Molina"));
            _Provincia.Add(new Provincia("Marcabal", "Luana"));

            List<Departamento> _Departamento = new List<Departamento>();
            _Departamento.Add(new Departamento("Lima", "Lima", "La Molina"));
            _Departamento.Add(new Departamento("Cajamarca", "Marcabal", "Luana"));



            List<CentroAtencion> _Centro = new List<CentroAtencion>();
            _Centro.Add(new CentroAtencion("Huayay", 1231, _Departamento[0], _Provincia[0], _Distrito[0], "Av.Los Halcones"));
            _Centro.Add(new CentroAtencion("Minka", 4526, _Departamento[1], _Provincia[1], _Distrito[1], "Av.Los Halcones"));

            Trabajador _Trabajador = new Trabajador();
            _Trabajador.Codigo = 1099;
            _Trabajador.Nombre = "Bruno";
            _Trabajador.Tipotrabajador._Descripcion = "full time";

            List<Venta> venta = new List<Venta>(6);
            venta.Add(new Venta(_Cliente[0], "Aprobado", "Renovacion de contrato", _Plan[0], "TRIO", 968550187, "credito", "Mensual", _Centro[1], _Trabajador, "y700", "Samsung"));
            venta.Add(new Venta(_Cliente[1], "Desaprobado", "Portabilidad", _Plan[1], "TRIO", 996523652, "efectivo", "Mensual", _Centro[1], _Trabajador, "r30", "Nokia"));
            venta.Add(new Venta(_Cliente[2], "Aprobado", "Linea Nueva", _Plan[1], "DUO", 948569326, "credito", "Mensual", _Centro[1], _Trabajador, "Note3", "Samsung"));
            venta.Add(new Venta(_Cliente[3], "Aprobado", "Portabilidad", _Plan[1], "TRIO", 987654321, "credito", "Mensual", _Centro[0], _Trabajador, "Note4", "Samsung"));
            venta.Add(new Venta(_Cliente[4], "Desaprobado", "Renovacion de Contrato", _Plan[1], "TRIO", 936251478, "efectivo", "Mensual", _Centro[0], _Trabajador, "CZ10", "LG"));
            venta.Add(new Venta(_Cliente[5], "Desaprobado", "Linea Nueva", _Plan[1], "DUO", 999968549, "credito", "Mensual", _Centro[1], _Trabajador, "Power30", "Motorola"));

            Venta _Venta = null;
            char ev=' ';
            do
            {

                Console.WriteLine("\n****Ingresar Digito***** \n\nMostrar Reporte Total: 1 \nEvaluar Numero de linea: 2");
                char digito = char.Parse(Console.ReadLine());
                if (digito == '1')
                {
                    Console.WriteLine("\nNombre de cliente: {0} ", venta[0]._Cliente._Nombre);
                    Console.WriteLine("Dni:{0} \nPlan:{1} \nTipo de plan:{2}", venta[0]._Cliente._Dni, venta[0]._Evaluacion._Plan.Costo, venta[0]._Evaluacion._Plan.Tipoplan._Detalle);
                    Console.WriteLine("Linea:{0} \nNumero de Linea:{1} \nTipo de Pago:{2}", venta[0]._LineaTelefonica._Tipolinea._Detalle, venta[0]._LineaTelefonica._Numerolinea, venta[0]._Tipopago._Detalle);
                    Console.WriteLine("Contrato:{0} \nCentro de Atencion:{1} \nAtendido por:{2}", venta[0]._Contrato._Detalle, venta[0]._Centro._Centro, venta[0]._Evaluacion._Trabajador.Nombre);

                    Console.WriteLine("\nNombre de cliente: {0} ", venta[1]._Cliente._Nombre);
                    Console.WriteLine("Dni:{0} \nPlan:{1} \nTipo de plan:{2}", venta[1]._Cliente._Dni, venta[1]._Evaluacion._Plan.Costo, venta[1]._Evaluacion._Plan.Tipoplan._Detalle);
                    Console.WriteLine("Linea:{0} \nNumero de Linea:{1} \nTipo de Pago:{2}", venta[1]._LineaTelefonica._Tipolinea._Detalle, venta[1]._LineaTelefonica._Numerolinea, venta[1]._Tipopago._Detalle);
                    Console.WriteLine("Contrato:{0} \nCentro de Atencion:{1} \nAtendido por:{2}", venta[1]._Contrato._Detalle, venta[1]._Centro._Centro, venta[1]._Evaluacion._Trabajador.Nombre);

                    Console.WriteLine("\nNombre de cliente: {0} ", venta[2]._Cliente._Nombre);
                    Console.WriteLine("Dni:{0} \nPlan:{1} \nTipo de plan:{2}", venta[2]._Cliente._Dni, venta[2]._Evaluacion._Plan.Costo, venta[2]._Evaluacion._Plan.Tipoplan._Detalle);
                    Console.WriteLine("Linea:{0} \nNumero de Linea:{1} \nTipo de Pago:{2}", venta[2]._LineaTelefonica._Tipolinea._Detalle, venta[2]._LineaTelefonica._Numerolinea, venta[2]._Tipopago._Detalle);
                    Console.WriteLine("Contrato:{0} \nCentro de Atencion:{1} \nAtendido por:{2}", venta[2]._Contrato._Detalle, venta[2]._Centro._Centro, venta[2]._Evaluacion._Trabajador.Nombre);

                    Console.WriteLine("\nNombre de cliente: {0} ", venta[3]._Cliente._Nombre);
                    Console.WriteLine("Dni:{0} \nPlan:{1} \nTipo de plan:{2}", venta[3]._Cliente._Dni, venta[3]._Evaluacion._Plan.Costo, venta[3]._Evaluacion._Plan.Tipoplan._Detalle);
                    Console.WriteLine("Linea:{0} \nNumero de Linea:{1} \nTipo de Pago:{2}", venta[3]._LineaTelefonica._Tipolinea._Detalle, venta[3]._LineaTelefonica._Numerolinea, venta[0]._Tipopago._Detalle);
                    Console.WriteLine("Contrato:{0} \nCentro de Atencion:{1} \nAtendido por:{2}", venta[3]._Contrato._Detalle, venta[3]._Centro._Centro, venta[3]._Evaluacion._Trabajador.Nombre);

                    Console.WriteLine("\nNombre de cliente: {0} ", venta[4]._Cliente._Nombre);
                    Console.WriteLine("Dni:{0} \nPlan:{1} \nTipo de plan:{2}", venta[4]._Cliente._Dni, venta[4]._Evaluacion._Plan.Costo, venta[4]._Evaluacion._Plan.Tipoplan._Detalle);
                    Console.WriteLine("Linea:{0} \nNumero de Linea:{1} \nTipo de Pago:{2}", venta[4]._LineaTelefonica._Tipolinea._Detalle, venta[4]._LineaTelefonica._Numerolinea, venta[4]._Tipopago._Detalle);
                    Console.WriteLine("Contrato:{0} \nCentro de Atencion:{1} \nAtendido por:{2}", venta[4]._Contrato._Detalle, venta[4]._Centro._Centro, venta[4]._Evaluacion._Trabajador.Nombre);

                    Console.WriteLine("\nNombre de cliente: {0} ", venta[5]._Cliente._Nombre);
                    Console.WriteLine("Dni:{0} \nPlan:{1} \nTipo de plan:{2}", venta[5]._Cliente._Dni, venta[5]._Evaluacion._Plan.Costo, venta[5]._Evaluacion._Plan.Tipoplan._Detalle);
                    Console.WriteLine("Linea:{0} \nNumero de Linea:{1} \nTipo de Pago:{2}", venta[5]._LineaTelefonica._Tipolinea._Detalle, venta[5]._LineaTelefonica._Numerolinea, venta[0]._Tipopago._Detalle);
                    Console.WriteLine("Contrato:{0} \nCentro de Atencion:{1} \nAtendido por:{2}", venta[5]._Contrato._Detalle, venta[5]._Centro._Centro, venta[5]._Evaluacion._Trabajador.Nombre);

                    Console.ReadKey();
                }
                else if (digito == '2')
                {
                    Console.WriteLine("\nIngrese el numero de linea:");
                    //Venta _Venta = venta.Find(t => t._LineaTelefonica._Numerolinea == int.Parse(Console.ReadLine()));
                    int numerolinea = int.Parse(Console.ReadLine());

                    foreach (Venta v in venta)
                    {
                        if (v._LineaTelefonica._Numerolinea == numerolinea)
                            _Venta = v;
                    }

                    if (_Venta == null)
                    {
                        Console.WriteLine("No se encuentra registrado");
                    }
                    else
                    {
                        Console.WriteLine("\nNombre de cliente: {0} ", _Venta._Cliente._Nombre);
                        Console.WriteLine("Dni:{0} \nPlan:{1} \nTipo de plan:{2}", _Venta._Cliente._Dni, _Venta._Evaluacion._Plan.Costo, _Venta._Evaluacion._Plan.Tipoplan._Detalle);
                        Console.WriteLine("Linea:{0} \nNumero de Linea:{1} \nTipo de Pago:{2}", _Venta._LineaTelefonica._Tipolinea._Detalle, _Venta._LineaTelefonica._Numerolinea, _Venta._Tipopago._Detalle);
                        Console.WriteLine("Contrato:{0} \nCentro de Atencion:{1} \nAtendido por:{2}", _Venta._Contrato._Detalle, _Venta._Centro._Centro, _Venta._Evaluacion._Trabajador.Nombre);

                        Console.WriteLine("¿Desea una Evaluacion? Y= si, N= no");

                        ev = char.Parse(Console.ReadLine());
                        if (ev == 'Y' || ev=='y')
                        {
                            Console.WriteLine("\nEvaluando....");
                            Thread.Sleep(2000);
                            if (_Venta._Evaluacion._Plan.Tipoplan._Detalle == "prepago")
                            {
                                Console.WriteLine("Los planes prepago no entran en evaluacion..!!");
                            }
                            else if (_Venta._Evaluacion._Plan.Tipoplan._Detalle == "postpago")
                            {
                                Console.WriteLine("\nEvaluación:{0} \nTipo de Evaluacion:{1}", _Venta._Evaluacion._Estadoevaluacion._Detalle, _Venta._Evaluacion._TipoEvaluacion._Detalle);
                                Console.ReadKey();
                            }
                        }else if(ev == 'N' || ev == 'n')
                        {
                            Console.WriteLine("\n...HASTA PRONTO!!");
                            Thread.Sleep(1000);
                        }

                    }
                }

            } while (_Venta._Evaluacion._Plan.Tipoplan._Detalle == "prepago" && ev != 'N');
        }
    }
}
