using System;
using System.Collections.Generic;
using System.Text;

namespace Dominio
{
    public class producto
    {
        public string Tipo { get; set; }
        public float LargoBulto { get; set; }
        public float AnchoBulto { get; set; }
        public int Rack { get; set; }
        public int Compartimiento { get; set; }
        public bool Lado { get; set; }
    }
}
