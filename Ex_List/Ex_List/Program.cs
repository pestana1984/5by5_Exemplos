using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_List
{
    class Program
    {    
        static void Main(string[] args)
        {
            List<string> listaString = new List<string>();
            string nome;
            Console.WriteLine("Capacidade:"+listaString.Capacity);
            do
            {
                Console.WriteLine("Digite um nome para inserir na lista:");
                nome = Console.ReadLine();
                listaString.Add(nome);
            } while (nome != "");

            Console.WriteLine("A lista tem " + listaString.Count + " elementos:");
            //Imprime cada item da lista
            listaString.ForEach(i => Console.WriteLine(i));

            //Ordenar
            Console.WriteLine("A lista ORDENADA:");
            listaString.Sort();
            listaString.ForEach(i => Console.WriteLine(i));

            //Acessando uma posição especifica
            listaString[3] = "John Doe";

            //Adicionar (Semelhante ao Add) em uma posição especifica, porém com posição definida
            listaString.Insert(1, "Tiririca");

            Console.WriteLine("A lista MODIFICADA:");
            listaString.ForEach(i => Console.WriteLine(i));
            Console.WriteLine("Capacidade:" + listaString.Capacity);

            if (listaString.Remove("Vitor"))
                Console.WriteLine("Elemento Removido com sucesso");
            else
                Console.WriteLine("Elemento não Localizado!");

            Console.WriteLine("A lista MODIFICADA:");
            listaString.ForEach(i => Console.WriteLine(i));

            Console.ReadKey();

            //Referências
            //remove()
            //removeAt(posição)
            //http://www.linhadecodigo.com.br/artigo/3676/listt-trabalhando-com-listas-genericas-em-csharp.aspx#ixzz6nJOXhelV
            //https://www.alura.com.br/artigos/listas-em-csharp?gclid=Cj0KCQiA7NKBBhDBARIsAHbXCB46cB3ZHr1HydVeEe04lFZ3zj6u8ne_0tJnHJkanTjbXV1FHZ_nSZgaAqj4EALw_wcB
            //https://www.caelum.com.br/apostila-csharp-orientacao-objetos/trabalhando-com-listas#exercicios
            //https://docs.microsoft.com/pt-br/dotnet/api/system.collections.generic.list-1?view=net-5.0
        }
    }
}
