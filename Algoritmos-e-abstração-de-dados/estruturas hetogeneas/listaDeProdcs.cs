/*
Faça um programa com: um menu de opções que possa cadastrar o nome, o preço unitário, a quantidade em estoque e a data de validade (mês e ano) de 30 produtos. 
Depois dos dados serem informados, o programa deve conter uma opção que, por meio de uma função, possa listar os produtos acima de um determinado valor fornecido pelo usuário.
Repita o programa anterior, agora considerando que a data de validade é de um tipo estruturado e formado pelos campos mês e ano.

*/


using System;
using System.Collections.Generic;
struct Produto
{

    public string nome;
    public double preco;
    public int qtd;
    public DateTime dataVal;

    public Produto(string nome, double preco, int qtd, DateTime dataVal)
    {
        this.nome = nome;
        this.preco = preco;
        this.qtd = qtd;
        this.dataVal = dataVal;
    }

}

class listaDeProcs
{

    static void Main()
    {
        int opcoes;
        List<Produto> produtos = new List<Produto>();

        produtos.Add(new Produto("Maçã", 2.50, 10, new DateTime(2023, 12, 31)));
        produtos.Add(new Produto("Leite", 3.50, 5, new DateTime(2023, 11, 30)));
        produtos.Add(new Produto("Pão", 1.20, 8, new DateTime(2023, 11, 25)));
        produtos.Add(new Produto("Queijo", 5.75, 3, new DateTime(2023, 12, 10)));
        produtos.Add(new Produto("Tomate", 1.80, 12, new DateTime(2023, 11, 28)));
        produtos.Add(new Produto("Arroz", 4.25, 15, new DateTime(2023, 12, 15)));
        produtos.Add(new Produto("Feijão", 3.75, 10, new DateTime(2023, 12, 20)));
        produtos.Add(new Produto("Carne", 7.50, 5, new DateTime(2023, 11, 27)));
        produtos.Add(new Produto("Laranja", 2.00, 8, new DateTime(2023, 11, 29)));
        produtos.Add(new Produto("Cenoura", 1.50, 10, new DateTime(2023, 12, 5)));
        produtos.Add(new Produto("Peixe", 6.50, 3, new DateTime(2023, 11, 25)));
        produtos.Add(new Produto("Iogurte", 2.80, 6, new DateTime(2023, 12, 8)));
        produtos.Add(new Produto("Ovos", 1.75, 12, new DateTime(2023, 12, 12)));
        produtos.Add(new Produto("Cebola", 1.20, 7, new DateTime(2023, 12, 3)));
        produtos.Add(new Produto("Macarrão", 2.00, 10, new DateTime(2023, 12, 18)));

        do
        {
            Console.WriteLine("digite:\n \t1 - cadastrar um produto\n\t2 - consultar um produto\n\t0 - para sair");
            Console.Write("-> ");
            opcoes = int.Parse(Console.ReadLine());

            switch (opcoes)
            {
                case 1:
                    cadastrarPoduto(produtos);
                    break;
                case 2:
                    consultarProduto(produtos);
                    break;
                case 0:
                    Console.WriteLine("Pressione Enter para sair...");
                    break;
                default:
                    Console.WriteLine("valor invalido");
                    break;

            }
        } while (opcoes != 0);

        Console.ReadLine();
    }

    static void cadastrarPoduto(List<Produto> produtos)
    {
        Console.Clear();

        Console.Write("Digite o nome do produto: ");
        string nome = Console.ReadLine();
        Console.Write("Digite o preço: ");
        double preco = double.Parse(Console.ReadLine());
        Console.Write("Digite a quantidade: ");
        int qtd = int.Parse(Console.ReadLine());

        int mes = 0, ano = 0;
        while (mes < 1 || mes > 12)
        {
            Console.Write("Digite o mês de validade (1 a 12): ");
            mes = int.Parse(Console.ReadLine());
        }
        while (ano < DateTime.MinValue.Year || ano > DateTime.MaxValue.Year)
        {
            Console.Write("Digite o ano de validade: ");
            ano = int.Parse(Console.ReadLine());
        }

        DateTime dataVal = new DateTime(ano, mes, 1);

        Produto novoProduto = new Produto(nome, preco, qtd, dataVal);

        produtos.Add(novoProduto);
        Console.WriteLine("Produto cadastrado com sucesso!");
    }
    static void consultarProduto(List<Produto> produtos)
    {
        int opcoes;
        Console.Clear();

        Console.WriteLine("Como deseja consultar?");
        Console.WriteLine("\t1 - Todo o estoque");
        Console.WriteLine("\t2 - por nome");
        Console.WriteLine("\t3 - por Valor");
        Console.WriteLine("\t0 - para voltar");
        Console.Write("-> ");

        opcoes = int.Parse(Console.ReadLine());
        switch (opcoes)
        {
            case 1:
                todoEstoque(produtos);
                break;
            case 2:
                porNome(produtos);
                break;
            case 3:
                Console.WriteLine("função nao implementada!");
                break;
            case 0:
                break;
            default:
                Console.WriteLine("opção invalida!");
                break;
        }
    }

    static void todoEstoque(List<Produto> produtos)
    {
        Console.Clear();
        foreach (Produto produto in produtos)
        {
            Console.WriteLine("\n\t{0}:\n\t\tPreço: {1}\n\t\tQuantidDe: {2}\n\t\tValidade: {3}\n", produto.nome, produto.preco, produto.qtd, produto.dataVal);
        }
    }
    static void porNome(List<Produto> produtos)
    {
        Console.Clear();
        Console.Write("digite o produto: ");
        string item = Console.ReadLine();
        bool encontrado = false;
        foreach (Produto produto in produtos)
        {
            if (item == produto.nome)
            {
                Console.WriteLine("\n\t{0}:\n\t\tPreço: {1}\n\t\tQuantidDe: {2}\n\t\tValidade: {3}\n", produto.nome, produto.preco, produto.qtd, produto.dataVal);
                encontrado = true;
                break;
            }
        }
        if (!encontrado)
        {
            Console.WriteLine("Produto não encontrado");
        }
    }

}