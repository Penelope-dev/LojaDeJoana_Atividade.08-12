using Atividade_08_de_dez;


List<Produto> produtos = new List<Produto>();
int opcao = -1;


bool nula = true;
foreach (var _ in produtos)
{
    nula = false;
    break;
}


while (opcao != 0)
{
    Console.WriteLine("MENU: 1. Cadastrar item | 2. Exibir produto | 3. Verificar quantidade em estoque | 4. Exibir valor total | 0. Sair");
    opcao = int.Parse(Console.ReadLine());


    switch (opcao)
    {
        case 1:
            Produto produto = new Produto();

            Console.WriteLine("digite o nome do produto: ");
            produto.Nome = Console.ReadLine();

            Console.WriteLine("digite a quantidade que deseja: ");
            produto.Quantidade = int.Parse(Console.ReadLine());

            Console.WriteLine("digite o preço: ");
            produto.Preco = double.Parse(Console.ReadLine());

            produtos.Add(produto);
            break;


        case 2:
            if (nula)
            {
                Console.WriteLine("Produto ainda não cadastrado!");
            }
            else
            {
                foreach (var item in produtos)
                {
                    Console.WriteLine($"Nome: {item.Nome} | Quantidade: {item.Quantidade} | Preço: {item.Preco}");
                }
            }
            break;


        case 3:
            int qntdTotal = 0;

            foreach (var item in produtos)
            {
                qntdTotal += item.Quantidade;
            }
            Console.WriteLine($"Quantidade total ainda no estoque: {qntdTotal}");
            break;


        case 4:
            if (nula)
            {
                Console.WriteLine("Produto ainda não cadastrado!");
            }
            else
            {
                foreach (var item in produtos)
                {
                    Console.WriteLine($"{item.Nome} -> R$ {item.ValorTotal()}");
                }
            }
            break;


        case 0:
        default:
            Console.WriteLine("Encerrando sistema . . . Obrigada por comprar aqui! ");
            break;
    }
}


