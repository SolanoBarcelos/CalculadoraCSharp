    Menu();

    static void Menu()
{
    Console.Clear();

    Console.WriteLine("Qual operação deseja Fazer?");

    Console.WriteLine("1 - Soma");
    Console.WriteLine("2 - Subtração");
    Console.WriteLine("3 - Divisão");
    Console.WriteLine("4 - Multiplicação");
    Console.WriteLine("5 - Sair");

    Console.WriteLine("------------------------");

    Console.WriteLine("selecione uma opção:");

    int res = Convert.ToInt32(Console.ReadLine());

    switch(res)
    {
        case 1: Soma(); break;

        case 2: Subtacao(); break;

        case 3: Divisao(); break;

        case 4: Multiplicacao(); break;

        case 5: System.Environment.Exit(0); break;

        default: Menu(); break;
    }

}

    static void Soma()
{

Console.Clear();

Console.WriteLine("Primeiro Valor:");
double v1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Segundo Valor:");
double v2 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("");

double resultado = v1 + v2;
Console.WriteLine($"O resultado da soma é {resultado}."); 

Console.ReadKey();
Menu();

}

static void Subtacao()
{

Console.Clear();

Console.WriteLine("Primeiro Valor:");
double v1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Segundo Valor:");
double v2 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("");

double resultado = v1 - v2;
Console.WriteLine($"O resultado da subtração é {resultado}.");

Console.ReadKey();
Menu();

}

static void Divisao()
{

Console.Clear();

Console.WriteLine("Primeiro Valor:");
double v1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Segundo Valor:");
double v2 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("");

double resultado = v1 / v2;
Console.WriteLine($"O resultado da divisão é {resultado}.");

Console.ReadKey();
Menu();

}

static void Multiplicacao()
{

Console.Clear();

Console.WriteLine("Primeiro Valor:");
double v1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Segundo Valor:");
double v2 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("");

double resultado = v1 * v2;
Console.WriteLine($"O resultado da multiplicação é {resultado}.");

Console.ReadKey();
Menu();

}





