using System;
using System.Collections.Generic;
using System.Text;

namespace Dominio
{
    public class celular : producto
    {
        public string Descripcion { get; set; }
        public string Marca { get; set; }
        public int Memoria { get; set; }
        public string Sistema { get; set; }
    }
}
