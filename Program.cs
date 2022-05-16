using System;
using MySql.Data.MySqlClient;
using System.Data;

namespace Wine_House
{
  class Program
    {
        static void Main(string[] args)
        {
            //MySql Conexao
             MySqlConnection conexao;
                conexao = new MySqlConnection("server=localhost;database=wine;uid=root;password=");
                try
                {

                } catch (Exception x)
                {
                    Console.WriteLine(x + "Sem conexão ao banco de dados!");

                }
                conexao.Open();
                Console.WriteLine("Conectado");
            /*// exemplo, aqui e comando para inserir algo no BD.
            string nome = Console.ReadLine();
            string sql = "insert into bebida values('" + nome + "')";
            Console.WriteLine (sql);            
            //Fim Mysql Conexao*/


            Console.WriteLine("Wine House");
            Console.WriteLine("");
            Menu MenuPrincipal = new Menu();
            Menu MenuBebidas = new Menu();
            string escolhaCategoria = MenuPrincipal.menuPrincipal();
            
            do {
                switch (escolhaCategoria)
                {
                    case "1":

                        Console.Clear();
                        
                        string cadastroBebida = MenuBebidas.menuCadastro();

                        switch (cadastroBebida)
                        {
                            
                            
                            case "1":


                                //cadastro utilizando array

                                Bebida bebida = new Bebida();

                                Console.WriteLine("Digite o Nome:");
                                bebida.Nome = Console.ReadLine();
                                Console.WriteLine("Bebida: {0}", bebida.Nome);
                                Console.WriteLine("Digite o Id:");
                                bebida.Id = Console.ReadLine();
                                Console.WriteLine("Id: {0}", bebida.Id);
                                string sqlinsert = "insert into bebida values(@nome,@id)";
                                MySqlCommand cmdinsert = new MySqlCommand(sqlinsert, conexao);
                                cmdinsert.Parameters.AddWithValue("@nome", bebida.Nome);
                                cmdinsert.Parameters.AddWithValue("@id", bebida.Id);
                                cmdinsert.ExecuteNonQuery();
                                Console.ReadKey();

                                break;
                   
                                
                        
                    case "V":

                        Console.Clear();
                        Console.WriteLine("Wine House");
                        Console.WriteLine("");
                        escolhaCategoria = MenuPrincipal.menuPrincipal();

                        break;
                        }
                        break;



                    case "2":

                        //select * from
                        Console.Clear();
                        Console.WriteLine("Lista de Bebidas");
                        Console.WriteLine("");
                        string sqlselect = "select * from bebida";
                        MySqlCommand cmdselect = new MySqlCommand(sqlselect, conexao);
                        cmdselect.CommandText = sqlselect;
                        MySqlDataReader select = cmdselect.ExecuteReader();

                        while (select.Read())
                        {
                            Console.WriteLine("Nome:" + select["nome"]);
                            Console.WriteLine("Id:" + select["id"]);
                        }
                        Console.ReadKey();

                        Console.Clear();
                        Console.WriteLine("Wine House");
                        Console.WriteLine("");
                        escolhaCategoria = MenuPrincipal.menuPrincipal();

                        break;
                    

                    case "3":

                    break;

                    case "4":
                        break;


                    case "5":

                        Console.Clear();
                        Console.WriteLine("Desenvolvedor");
                        Console.WriteLine("");
                        Console.WriteLine("Lucas Menchon(github.com/lucasmenchon - site: https://tilucas.com");
                        Console.WriteLine("");
                        Console.ReadKey();

                        Console.Clear();
                        Console.WriteLine("Wine House");
                        Console.WriteLine("");
                        escolhaCategoria = MenuPrincipal.menuPrincipal();

                        break;

                    case "E":

                        Console.Clear();
                        Console.WriteLine("Programa encerrado!");
                        Environment.Exit(0);
                        break;


                    default:
                        Console.WriteLine("Opção inválida!");
                        Console.WriteLine("Tecle para voltar ao menu.");
                        Console.ReadKey();
                        Console.Clear();
                        Console.WriteLine("Wine House");
                        Console.WriteLine("");
                        escolhaCategoria = MenuPrincipal.menuPrincipal();
                        break;

                }//switch escolhaCategoria menu principal

            } while (true);
            
        }
    }
}
