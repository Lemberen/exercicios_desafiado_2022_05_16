Console.WriteLine("Digite a primeira nota: ");
float nota1 = float.Parse(Console.ReadLine());
Console.WriteLine("Digite a segunda nota: ");
float nota2 = float.Parse(Console.ReadLine());
Console.WriteLine("Digite a terceira nota: ");
float nota3 = float.Parse(Console.ReadLine());
Console.WriteLine("Digite a quarta nota: ");
float nota4 = float.Parse(Console.ReadLine());

float mediaNotas = (nota1 + nota2 + nota3 + nota4) / 4f;

Console.WriteLine($"A média das notas é: {mediaNotas}");

Console.WriteLine(mediaNotas > 7 ? "Aprovado" : "Reprovado");