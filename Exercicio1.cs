Console.WriteLine("Insira a idade mínima: ");
int idadeMinima = int.Parse(Console.ReadLine());
Console.WriteLine("Insira a idade maxima: ");
int idadeMaxima = int.Parse(Console.ReadLine());

Console.WriteLine($"A média das idades é: {(idadeMinima + idadeMaxima) / 2.0}");