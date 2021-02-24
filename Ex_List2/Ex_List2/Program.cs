using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_List2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Pessoa> listaPessoa = new List<Pessoa>();
            string nome;
            int idade;
            Console.WriteLine("Capacidade:" + listaPessoa.Capacity);
            do
            {
                Console.WriteLine("Digite um nome para inserir na lista:");
                nome = Console.ReadLine();
                Console.WriteLine("Digite uma idade para inserir na lista:");
                idade = int.Parse(Console.ReadLine());
                if (nome!="")
                    listaPessoa.Add(new Pessoa { Nome = nome, Idade = idade });
            } while (nome != "");

            Console.WriteLine("A lista tem " + listaPessoa.Count + " elementos:");
            //Imprime cada item da lista
            listaPessoa.ForEach(i => Console.WriteLine(i.ToString()));

            //Ordenar
            Console.WriteLine("A lista ORDENADA DECRESCENTE:");
            //ASSIM NÃO FUNCIONA >>>>> listaPessoa.Sort();
            //objetos = objetos.OrderBy(o => o.Desc).ToList();
            listaPessoa = listaPessoa.OrderByDescending(lp => lp.Nome).ToList();
            listaPessoa.ForEach(i => Console.WriteLine(i.ToString()));

            Console.WriteLine("A lista ORDENADA POR IDADE:");
            listaPessoa = listaPessoa.OrderBy(lp => lp.Idade).ToList();
            listaPessoa.ForEach(i => Console.WriteLine(i.ToString()));

            Console.ReadKey();
        }
    }
}
