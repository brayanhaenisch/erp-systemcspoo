using System;
using System.Collections.Generic;

public class Aplicativo
{
    private Menu _Menu;
    private Listas _listas;

    public Aplicativo()
    {
        _listas = new Listas(); // Instância única de listas
        _Menu = new Menu(_listas);
    }

    public void Executar()
    {
        _Menu.MenuModulo();
    }
}

public class Listas
{
    public List<int> ProdutosId = new();
    public List<string> ProdutosNome = new();
    public List<int> ProdutosPreco = new();
}

public class Menu
{
    private MenuCadastro _MenuCadastro;

    public Menu(Listas listas)
    {
        _MenuCadastro = new MenuCadastro(listas, this);
    }

    public void MenuModulo()
    {
        Console.WriteLine("\nEscolha um dos seguintes módulos:\n1 - Cadastros\n2 - Vendas");
        Console.Write("Digite sua opção: ");
        var escolha = Console.ReadLine();
        if (escolha == "1")
        {
            _MenuCadastro.MenuCad();
        }
        else if (escolha == "2")
        {
            Console.WriteLine("Esta tela ainda não está disponível!");
            MenuModulo();
        }
        else
        {
            Console.WriteLine("Opção inválida. Tente novamente.");
            MenuModulo();
        }
    }
}

public class MenuCadastro
{
    private MenuProduto _MenuProduto;

    public MenuCadastro(Listas listas, Menu menu)
    {
        _MenuProduto = new MenuProduto(listas, menu);
    }

    public void MenuCad()
    {
        Console.WriteLine("\nEscolha uma das seguintes opções:\n1 - Produtos\n2 - Clientes");
        Console.Write("Digite sua opção: ");
        var escolha = Console.ReadLine();
        if (escolha == "1")
        {
            _MenuProduto.MenuProd();
        }
        else if (escolha == "2")
        {
            Console.WriteLine("Esta tela ainda não está disponível!");
            MenuCad();
        }
        else
        {
            Console.WriteLine("Opção inválida. Tente novamente.");
            MenuCad();
        }
    }
}

public class MenuProduto
{
    private Produto _Produto;

    public MenuProduto(Listas listas, Menu menu)
    {
        _Produto = new Produto(listas, menu);
    }

    public void MenuProd()
    {
        Console.WriteLine("\nEscolha uma das seguintes opções:\n1 - Cadastrar Produto\n2 - Visualizar Produtos");
        Console.Write("Digite sua opção: ");
        var escolha = Console.ReadLine();
        if (escolha == "1")
        {
            _Produto.CadastrarProduto();
        }
        else if (escolha == "2")
        {
            _Produto.VisualizarProdutos();
            MenuProd(); // volta após visualizar
        }
        else
        {
            Console.WriteLine("Opção inválida. Tente novamente.");
            MenuProd();
        }
    }
}

public class Produto
{
    private Listas _Listas;
    private Menu _Menu;

    public Produto(Listas listas, Menu menu)
    {
        _Listas = listas;
        _Menu = menu;
    }

    int Id { get; set; }
    string Nome { get; set; } = string.Empty;
    int Preco { get; set; }

    public void CadastrarProduto()
    {
        Console.Write("\nEscreva o código do produto: ");
        if (!int.TryParse(Console.ReadLine(), out int idInput))
        {
            Console.WriteLine("Código inválido. Por favor, insira um número inteiro.");
            CadastrarProduto();
            return;
        }
        Id = idInput;

        Console.Write("\nEscreva o nome do produto: ");
        Nome = Console.ReadLine() ?? string.Empty;

        Console.Write("\nDigite o preço do produto: ");
        if (!int.TryParse(Console.ReadLine(), out int preco))
        {
            Console.WriteLine("Preço inválido. Por favor, insira um número inteiro.");
            CadastrarProduto();
            return;
        }
        Preco = preco;

        _Listas.ProdutosId.Add(Id);
        _Listas.ProdutosNome.Add(Nome);
        _Listas.ProdutosPreco.Add(Preco);

        Console.WriteLine("\nProduto cadastrado com sucesso!\n");

        _Menu.MenuModulo(); // Volta para o menu principal
    }

    public void VisualizarProdutos()
    {
        if (_Listas.ProdutosId.Count == 0)
        {
            Console.WriteLine("\nNenhum produto cadastrado.\n");
            return;
        }

        Console.WriteLine("\nLista de Produtos:\n");
        for (int i = 0; i < _Listas.ProdutosId.Count; i++)
        {
            Console.WriteLine("ID: " + _Listas.ProdutosId[i] +
                              " | Nome: " + _Listas.ProdutosNome[i] +
                              " | Preço: " + _Listas.ProdutosPreco[i]);
        }
        Console.WriteLine();
    }
}

public static class Program
{
    public static void Main(string[] args)
    {
        var app = new Aplicativo();
        app.Executar();
    }
}
