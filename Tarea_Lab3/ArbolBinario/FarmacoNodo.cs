using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tarea_Lab3.ArbolBinario
{
    public class FarmacoNodo
    {
        //Solo la Informacion que guarda el nodo sobre el farmaco
        public int IdNodo { get; set;  }
        public string NameNodo { get; set; }
        public int LineNodo { get; set; }
        public int ExistenciaNodo { get; set; }
        public FarmacoNodo()
        {
        }
    }
}
