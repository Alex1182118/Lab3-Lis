using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Tarea_Lab3.ArbolBinario;
using System.Resources;
using System.Web;
using System.Web.Mvc;
using System.IO;

//AGREGAR AL ARBOL LOS RECORRIDOS, INORDER, POSTORDER, PREORDER.
//Buscar farmaco
//Eliminar nodo
//Serializar y deserializar el MOCK DATA
//Crear una lista que reciba los datos del deserializado y los meta al arbol

namespace Tarea_Lab3.Controllers
{
    public class ArbolBinarioRepository     {

        string path = @"C:\Desktop\MOCK_DATA.csv";
        BinaryTree<FarmacoNodo> arbolBinario;

        public ArbolBinarioRepository()
        {
            arbolBinario = new BinaryTree<FarmacoNodo>();
        }

        public void LoadFile()
        {
            System.IO.StreamReader str = new System.IO.StreamReader(path);
            while (!str.EndOfStream)
            {
                string linea = str.ReadLine();
                string[] valores = linea.Split(",");
                FarmacoNodo newnodo = new FarmacoNodo();
                newnodo.IdNodo = Convert.ToInt32(valores[0]);
                newnodo.NameNodo = valores[1];
                newnodo.ExistenciaNodo = Convert.ToInt32(valores[5]);
                arbolBinario.CreateTree(newnodo.NameNodo, newnodo);
            }
            str.Close();
        }

       

        public List<Farmaco> BuscarFarmacos(string valor, int numeroDePagina, int noElementos)
        {
            List<FarmacoNodo> listaIndices = arbolBinario.Buscar(valor).Skip(numeroDePagina - 1 * noElementos).Take(noElementos).ToList();
            List<Farmaco> farmaco = new List<Farmaco>();
            foreach (var item in listaIndices)
            {
                farmaco.Add(ObtenerFarmaco(item.LineNodo));
            }
            return farmaco;
        }
        public Farmaco ObtenerFarmaco(int linea)
        {
            Farmaco farmaco = new Farmaco();
            string line = File.ReadLines(path).Skip(linea + 1).Take(1).First();
            return farmaco;

        }


    }
}
/*
Serializar
Movie movie = new Movie
{
    Name = "Bad Boys",
    Year = 1995
};

// serialize JSON to a string and then write string to a file
File.WriteAllText(@"c:\movie.json", JsonConvert.SerializeObject(movie));

// serialize JSON directly to a file
using (StreamWriter file = File.CreateText(@"c:\movie.json"))
{
    JsonSerializer serializer = new JsonSerializer();
    serializer.Serialize(file, movie);
}


 Deserealizar  
Movie movie1 = JsonConvert.DeserializeObject<Movie>(File.ReadAllText(@"c:\movie.json"));


    */
