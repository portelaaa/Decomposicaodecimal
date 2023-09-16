Console.WriteLine("--- Decomposição Decimal ---");
int numerodigitado, centenas, dezenas, unidades;

Console.WriteLine("Digite um numero!");
numerodigitado = Convert.ToInt32(Console.ReadLine());

centenas = numerodigitado / 100;
dezenas = (numerodigitado % 100) / 10;
unidades = (numerodigitado % 100) % 10;

Console.WriteLine($"O numero {numerodigitado} possui:");

Console.WriteLine($"{unidades,10} unidades(s)");
Console.WriteLine($"{dezenas,10} dezenas(s)");
Console.WriteLine($"{centenas,10} centenas(s)");
