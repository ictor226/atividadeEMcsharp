internal class Program
{
    private static void Main(string[] args)
    {
        int selecao;

        Console.WriteLine("Selecione o método desejavel:");
        Console.WriteLine("\t 1. Programa Notas \n\t 2. Programa equação de segundo grau \n\t 3. Programa menor de 3");
        selecao = int.Parse(Console.ReadLine());

        if (selecao == 1)
        {
            Metodo1();
        }
        else if (selecao == 2)
        {
            Metodo2();
        }
        else if (selecao == 3)
        {
            Metodo3();
        }
        else
        {
            Console.WriteLine("Nenhuma opção selecionada");
        }
    }

    static void Metodo1()
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Programa Notas");
        Console.ResetColor();
        Console.WriteLine();
        Console.Write("Digite a primeiranota: ");
        Console.ForegroundColor = ConsoleColor.Blue;
        double x = double.Parse(Console.ReadLine());
        Console.ResetColor();
        Console.Write("Digite a segundanota: ");
        Console.ForegroundColor = ConsoleColor.Blue;
        double y = double.Parse(Console.ReadLine());
        Console.ResetColor();
        //procesamento de dados
        double final = x + y;
        if (final < 60)
        {
            Console.Write("Sua nota final é");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(final.ToString("F2"));
            Console.WriteLine();
            Console.WriteLine("Você foi reprovado");
            Console.ResetColor();
        }
        else
        {
            Console.Write("Sua nota final é");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(final.ToString("F2"));
            Console.WriteLine();
            Console.WriteLine("Você foi aprovado");
            Console.ResetColor();
        }

    }

    static void Metodo2()
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Programa Equação de segundo grau");
        Console.ResetColor();
        Console.WriteLine();
        Console.Write("Digite o coefiente a:");
        Console.ForegroundColor = ConsoleColor.Blue;
        double a = double.Parse(Console.ReadLine());
        Console.ResetColor();
        Console.Write("Digite o coefiente b:");
        Console.ForegroundColor = ConsoleColor.Blue;
        double b = double.Parse(Console.ReadLine());
        Console.ResetColor();
        Console.Write("Digite o coefiente c:");
        Console.ForegroundColor = ConsoleColor.Blue;
        double c = double.Parse(Console.ReadLine());
        Console.ResetColor();
        //procesamento de dados
        double delta = ((b * b) - (4 * a * c));
        if (delta < 0)
        {
            Console.WriteLine("Esta equação não possui raízes reais");
        }
        else
        {
            double raizdelta = Math.Sqrt(delta);
            double x1 = ((-b) + raizdelta) / (2 * a);
            Console.WriteLine($"X1 = {x1!:F2}");
            double x2 = ((-b) - raizdelta) / (2 * a);
            Console.WriteLine($"X2 = {x2:F2}");
        }
    }

    static void Metodo3()
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Programa menor de três");    
        Console.ResetColor();
        Console.WriteLine();
        Console.Write("Primeiro valor: ");
        Console.ForegroundColor = ConsoleColor.Blue;
        double a = double.Parse(Console.ReadLine());
        Console.ResetColor();
        Console.Write("Segundo valor: ");
        Console.ForegroundColor = ConsoleColor.Blue;
        double b = double.Parse(Console.ReadLine());
        Console.ResetColor();
        Console.Write("Terceiro valor: ");
        Console.ForegroundColor = ConsoleColor.Blue;
        double c = double.Parse(Console.ReadLine());
        Console.ResetColor();
        Console.WriteLine();
        if (a <= b & a <= c)
        {
            Console.WriteLine("Menor = " + a);
        }
        else if (b < a & b <= c)
        {
            Console.WriteLine("Menor = " + b);
        }
        else if (c < a & c < b)
        {
            Console.WriteLine("Menor = " + c);
        }
    }

}