Console.WriteLine("Digite a temperatura em Fahrenheit: ");
float fahrenheit = float.Parse(Console.ReadLine());

Console.WriteLine($"A temperatura em Celsius é: {(fahrenheit - 32) * 5 / 9 }");