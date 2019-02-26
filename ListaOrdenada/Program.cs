using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaOrdenada
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Nombre> listaOrdenada = new List<Nombre>();
            listaOrdenada.Add(new Nombre() { lista = "Alberto" });
            listaOrdenada.Add(new Nombre() { lista = "Juana" });
            listaOrdenada.Add(new Nombre() { lista = "Eliana" });
            listaOrdenada.Add(new Nombre() { lista = "Pedro" });
            listaOrdenada.Add(new Nombre() { lista = "Ezequiel" });
            listaOrdenada.Add(new Nombre() { lista = "Ruben" });
            listaOrdenada.Add(new Nombre() { lista = "Mario" });
            listaOrdenada.Add(new Nombre() { lista = "Alejandro" });
            listaOrdenada.Add(new Nombre() { lista = "Priscila" });
            listaOrdenada.Add(new Nombre() { lista = "Eugenio" });
            listaOrdenada.Add(new Nombre() { lista = "Leandro" });
            listaOrdenada.Add(new Nombre() { lista = "Mario" });
            listaOrdenada.Add(new Nombre() { lista = "Sebastian" });
            listaOrdenada.Add(new Nombre() { lista = "Bruno" });

            //1) Separar en 2 listas diferentes, aquellos que empiezan con una vocal y en la segunda aquellos
            //    que empiezan con una consonante.Mostrar ambas listas
            // Lista empieza con vocal

            Console.WriteLine("********************");
            Console.WriteLine("**Lista empiezan con vocal**");
            Console.WriteLine("********************");

            foreach (var item in listaOrdenada)
            {
                if (item.lista.ToUpper().StartsWith("A") ||
                    item.lista.ToUpper().StartsWith("E") ||
                    item.lista.ToUpper().StartsWith("I") ||
                    item.lista.ToUpper().StartsWith("O") ||
                    item.lista.ToUpper().StartsWith("U"))
                {
                    Console.WriteLine(item.lista);
                }
            }

            Console.WriteLine("********************");
            Console.WriteLine("**Lista empiezan con consonante**");
            Console.WriteLine("********************");

            foreach (var item in listaOrdenada)
            {
                if (!item.lista.ToUpper().StartsWith("A") &&
                    !item.lista.ToUpper().StartsWith("E") &&
                    !item.lista.ToUpper().StartsWith("I") &&
                    !item.lista.ToUpper().StartsWith("O") &&
                    !item.lista.ToUpper().StartsWith("U"))
                {
                    Console.WriteLine(item.lista);
                }
            }

            //2) Tomar ambas lista y ordenaras alfabeticamente, primero en orden ascendente y luego descendente. Mostrarlas
            // Lista Ordenada en  forma Acendente

            Console.WriteLine("********************");
            Console.WriteLine("**Lista en Acendente**");
            Console.WriteLine("********************");

            listaOrdenada = listaOrdenada.OrderBy(x => x.lista).ToList();
            foreach (var Nombre in listaOrdenada)
            {
                Console.WriteLine(Nombre.lista);
            }
            // Lista Ordenada en Forma Desendente

            Console.WriteLine("********************");
            Console.WriteLine("**Lista en Desendente**");
            Console.WriteLine("********************");

            listaOrdenada = listaOrdenada.OrderByDescending(x => x.lista).ToList();
            foreach (var Nombre in listaOrdenada)
            {
                Console.WriteLine("" + Nombre.lista);
            }

            //3) Tomar ambas listas e invertir todos sus textos, por ejemplo Pricila -> alicirP
            //Mostrar ambas listas invertidas
            Console.WriteLine("********************");
            Console.WriteLine("**Lista nombres invertida**");
            Console.WriteLine("********************");


            foreach (var Nombre in listaOrdenada.OrderBy(x => x.lista))
            {
                var nombreAux = "";
                for (int x = Nombre.lista.Length - 1; x >= 0; x--)
                {
                    nombreAux += Nombre.lista[x];
                }
                Console.WriteLine("" + nombreAux);
            }

        }
    }
}

