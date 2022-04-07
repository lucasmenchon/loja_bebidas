using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wine_House
{
    class Menu
    {
        //menu principal
        public string menuPrincipal()
        {
            string escolhaCategoria;

            Console.WriteLine("(1) - Cadastro de Bebidas");
            Console.WriteLine("(2) - Lista de Bebidas");
            Console.WriteLine("(3) - Renomear Bebida");
            Console.WriteLine("(4) - Deletar Bebida");
            Console.WriteLine("(5) - Desenvolvedores");
            Console.WriteLine("(E) - Sair");

            escolhaCategoria = Console.ReadLine();
            return escolhaCategoria.ToUpper();
        }

        //menu 
        public string menuCadastro()
        {
            string escolha;

            Console.WriteLine("(1) - Cadastrar Bebida");
            Console.WriteLine("(V) - Voltar");

            escolha = Console.ReadLine();
            return escolha.ToUpper();
        }

        public string menuLista()
        {
            string escolha;

            Console.WriteLine("(1) - Lista de Bebidas");
            Console.WriteLine("(V) - Voltar");

            escolha = Console.ReadLine();
            return escolha.ToUpper();
        }


    }
}

