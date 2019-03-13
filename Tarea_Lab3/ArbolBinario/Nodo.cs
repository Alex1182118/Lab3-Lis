using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tarea_Lab3.ArbolBinario
{
   
  public class Nodo <T>
    {
        //<T> Para recibir un Farmaco, Left and Right para ver a que lado se va el nodo, T Valor , para obtener los daros del FarmacoNodo
        public Nodo<T> Left { get; set; }
        public Nodo<T> Right { get; set; }
        public Nodo<T> HijoDer { get; set; }
        public Nodo<T> HijoIz{ get; set; }
        public T Info { get; set; }
        public int key { get; set; }
        public string name { get; set; }
        public Nodo()
        {
        }
    }
}
