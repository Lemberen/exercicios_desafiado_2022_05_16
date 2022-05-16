Console.WriteLine("Digite a temperatura em Celsius: ");
float celsius = float.Parse(Console.ReadLine());

Console.WriteLine($"A temperatura em Fahrenheit é: {(9 * celsius + 160) / 5}");