using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tarea_Lab3.ArbolBinario
{
    public class Farmaco
    {
        //Todos los datos del farmaco (Los que aparecen en el archivo .csv)
       public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Merch { get; set; }
        public double Price { get; set; }
        public int Existence { get; set; }
        public Farmaco()
        {
        }
    }
}
