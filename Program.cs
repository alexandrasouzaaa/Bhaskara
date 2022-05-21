﻿double a, b, c, delta, x1, x2;


Console.WriteLine();


Console.WriteLine("--Equação de Segundo Grau--");
Console.WriteLine("    ax^2 + bx + c = 0      ");

Console.WriteLine();


Console.Write("Insira o valor de a: ");
a = Convert.ToDouble(Console.ReadLine());

Console.Write("Insira o valor de b: ");
b = Convert.ToDouble(Console.ReadLine());

Console.Write("Insira o valor de c: ");
c = Convert.ToDouble(Console.ReadLine());

Console.WriteLine();

if (a == 0)
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.Beep();

    Console.WriteLine("Não é uma equação de segundo grau, pois a = 0.");
    Console.ResetColor();
}
else
{
    delta = Math.Pow(b, 2) - 4 * a * c;

    if (delta < 0)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.Beep();

        Console.WriteLine("Como o delta é negativo, essa equação não possui raízes reais.");
        Console.ResetColor();
    }
    else
    {
        x1 = (-b + Math.Sqrt(delta)) / (2 * a);
        x2 = (-b - Math.Sqrt(delta)) / (2 * a);

        Console.WriteLine($"x1 = {x1:N2}");
        Console.WriteLine($"x2 = {x2:N2}");
    }

}

Console.WriteLine();