Console.WriteLine("Digite o valor A: ");
float a = float.Parse(Console.ReadLine());
Console.WriteLine("Digite o valor B: ");
float b = float.Parse(Console.ReadLine());

if (b != 0)
{
    float totalDivisao = a / b;
    float totalModulo = a % b;

    Console.WriteLine($"O valor da divisão de A e B é: {totalDivisao}");
    Console.WriteLine($"O valor do módulo de A e B é: {totalModulo}");

}
else
{
    Console.WriteLine("Divisor inválido!");
}