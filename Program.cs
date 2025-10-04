double nota1, nota2, nota3, media;

Console.WriteLine("Média Aritmética de 3 numeros\n");

Console.Write("Digite o primeiro numero: ");
nota1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Digite o segundo numero: ");
nota2 = Convert.ToDouble(Console.ReadLine());

Console.Write("Digite o terceiro numero: ");
nota3 = Convert.ToDouble(Console.ReadLine());

media = (nota1 + nota2 + nota3) / 3;

Console.WriteLine($"\nMédia: {media:N1}");