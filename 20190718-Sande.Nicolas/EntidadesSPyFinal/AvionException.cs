﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesSPyFinal
{
    public class AvionException : Exception
    {
        public AvionException(string mensaje) : base(mensaje)
        { }
    }
}
