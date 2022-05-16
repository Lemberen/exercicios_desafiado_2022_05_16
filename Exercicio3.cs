Console.WriteLine("Insira quanto o vendedor vendeu no mês de Maio: ");
float quantidadeVenda = float.Parse(Console.ReadLine());
float comissao = 0.05f;

Console.WriteLine($"A comissão do vendedor para o mês de Maio foi: {quantidadeVenda * comissao}");