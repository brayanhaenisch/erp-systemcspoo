namespace Cadastro
{
    public class Menu
    {
        public static void MenuCadastro()
        {
            Console.WriteLine("\nEscolha uma das opções:\n1 - Produtos\n2 - Funcionários\n3 - Clientes\n4 - Voltar ao menu principal\n");
            var opcao_cadastro = Console.ReadLine();
            if (opcao_cadastro == "1")
            {
                Console.WriteLine("\nEscolha uma das opções:\n1 - Visualizar cadastro de produtos\n2 - Cadastrar um produto\n");
                var opcao_cadastro_produto = Console.ReadLine();
                if (opcao_cadastro_produto == "1")
                    Produto.MostrarProduto();

                else if (opcao_cadastro_produto == "2")
                    Produto.CadastrarProduto();
            }
            else if (opcao_cadastro == "2")
            {
                Console.WriteLine("\nEsta tela ainda não está disponível.\n");
                MenuCadastro();
            }

            else if (opcao_cadastro == "3")
            {
                Console.WriteLine("\nEsta tela ainda não está disponível.\n");
                MenuCadastro();
            }

            else if (opcao_cadastro == "4")
                Console.WriteLine("\nVoltando ao menu principal.\n");
            else
            {
                Console.WriteLine("Opção inválida");
                MenuCadastro();
            }
        }
    }
    public class Produto
    {
        public static string Nome { get; set; }  = string.Empty;

        public static List<string> produtos_cadastrados = new List<string>();
        public static void CadastrarProduto()
        {
            
            {
                Console.WriteLine("\nEscreva o nome do produto: \n");
                var Nome = Console.ReadLine();
                if (Nome != null)
                {
                    Console.WriteLine("\nProduto Cadastrado: " + Nome + "\n");
                    produtos_cadastrados.Add(Nome);
                }
                else
                {
                    Console.WriteLine("\nO nome do produto é inválido!\n");
                    CadastrarProduto();
                }

            }
        }

        public static void MostrarProduto()
        {
            if (produtos_cadastrados.Count != 0)
            {
                foreach (var p in produtos_cadastrados)
                {
                    Console.WriteLine("\n" + p + "\n");
                }
            }

            else
            {
                Console.WriteLine("\nNão existem produtos cadastrados.\n");
                Menu.MenuCadastro();
            }
        }
    }
}