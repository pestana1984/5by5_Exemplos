using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PListaDinSimEnc
{
    class Program
    {
        static void Main(string[] args)
        {
            ListaContatos meus_contatos = new ListaContatos { Head = null, Tail = null };
            
            
            string v = "Julio";
            //meus_contatos.Pop(v);
            //Console.ReadKey();


            Pessoa p1 = new Pessoa
            {
                Nome = "João",
                telefone = new Telefone[] { new Telefone { DDD = 16, Numero = 9999999, Tipo = "Celular" }, new Telefone { DDD = 16, Numero = 3333333, Tipo = "Fixo" } } 
            };
            //Console.WriteLine(p1.ToString());
            meus_contatos.Push(p1);
            p1 = new Pessoa
            {
                Nome = "Maria",
                telefone = new Telefone[] { new Telefone { DDD = 16, Numero = 981112233, Tipo = "Celular" }, new Telefone { DDD = 16, Numero = 190, Tipo = "Fixo" }, new Telefone { DDD = 16, Numero = 911, Tipo = "Recado" } }
            };
            meus_contatos.Push(p1);
            p1 = new Pessoa
            {
                Nome = "Jacqueline",
                telefone = new Telefone[] { new Telefone { DDD = 16, Numero = 907654321, Tipo = "Celular" }}
            };
            meus_contatos.Push(p1);
          /*  p1 = new Pessoa
            {
                Nome = "Laura",
                telefone = new Telefone[] { new Telefone { DDD = 16, Numero = 9874455, Tipo = "Celular" } }
            };
            meus_contatos.Push(p1);
            p1 = new Pessoa
            {
                Nome = "Julio",
                telefone = new Telefone[] { new Telefone { DDD = 16, Numero = 9874455, Tipo = "Celular" } }
            };
            meus_contatos.Push(p1);
            
         */ meus_contatos.Print();
            Console.ReadKey();
           
            Console.Clear();
            v = "João";
            meus_contatos.Pop(v);

            Console.ReadKey();
            p1 = new Pessoa
            {
                Nome = "Zenaide",
                telefone = new Telefone[] { new Telefone { DDD = 16, Numero = 9874455, Tipo = "Celular" } }
            };
            meus_contatos.Push(p1);
            Console.ReadKey();

            v = "Maria";
            meus_contatos.Pop(v);
            Console.ReadKey();
            v = "Jacqueline";
            meus_contatos.Pop(v);
            Console.ReadKey();

            v = "Zenaide";
            meus_contatos.Pop(v);
            Console.ReadKey();

            Console.Clear();
            meus_contatos.Print();
            Console.ReadKey();
        }
    }
}
