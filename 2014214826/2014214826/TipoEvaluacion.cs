﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2014214826
{
    public class TipoEvaluacion
    {
        public string _Detalle { get; set; }

        public TipoEvaluacion()
        {

        }
        public TipoEvaluacion(string detalle)
        {
            _Detalle = detalle;
        }
    }
}
