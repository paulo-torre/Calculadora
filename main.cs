using System;

class Calculadora
{
    static void Main()
    {
        char op = '$';

        inicio:

        int aux = 1;

        int qtdFatores = 0;
        double res = 0;

        Console.Clear();

        Console.WriteLine("\n~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
        Console.WriteLine("\t\t\tCalculadora");
        Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~\n\n");

        if ( op == '#' )
        {
            Console.WriteLine("  Digite a operação que será usada:  [ INSIRA UMA OPERAÇÃO VÁLIDA ]\n");
        } else
        {
            Console.WriteLine("  Digite a operação que será usada:\n");
        }

        Console.WriteLine("  [ + ] - Adição\n  [ - ] - Subtração\n  [ * ] - Multiplicação\n  [ / ] - Divisão\n");
        Console.Write("  --> ");
        op = char.Parse(Console.ReadLine());

        switch (op)
        {
            case '+':
            case '-':
            case '*':
            case '/':
                break;
            default:
                op = '#';
                goto inicio;
        }

        while( qtdFatores < 2 )
        {
            Console.Clear();
            Console.WriteLine("\n~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine("\t\t\tCalculadora");
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~\n\n");
            Console.WriteLine("  Digite a operação que será usada:  {0}\n", op);

            if( qtdFatores == -1 )
            {
                Console.WriteLine("\n  [ INSIRA UM NÚMERO MAIOR QUE 1 ]");
                Console.Write("\n  Digite a quantidade de fatores:  ");
            } else
            {
                Console.Write("  Digite a quantidade de fatores:  ");
            }
            
            qtdFatores = Convert.ToInt32(Console.ReadLine());

            if( qtdFatores < 2 )
            {
                qtdFatores = -1;
                aux = 0;
            }

        }

        switch (op)
        {
            case '+':
                for( int i=1; i <= qtdFatores; i++ )
                {
                    Console.Clear();
                    Console.WriteLine("\n~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                    Console.WriteLine("\t\t\tCalculadora");
                    Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~\n\n");

                    if( aux == 0 )
                    {
                        Console.WriteLine("\n  [ INSIRA UM NÚMERO MAIOR QUE 1 ]");
                    }

                    Console.WriteLine("\n  Insira a quantidade de fatores:  {0}\n", qtdFatores);
                    Console.Write("\n  Digite o {0}º fator: ", i);
                    res += double.Parse(Console.ReadLine());
                }
                break;

            case '-':
                for( int i=1; i <= qtdFatores; i++ )
                {
                    Console.Clear();

                    Console.WriteLine("\n~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                    Console.WriteLine("\t\t\tCalculadora");
                    Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~\n\n");

                    if( aux == 0 )
                    {
                        Console.WriteLine("\n  [ INSIRA UM NÚMERO MAIOR QUE 1 ]");
                    }

                    Console.WriteLine("\n  Digite a quantidade de fatores:  {0}\n", qtdFatores);
                    Console.Write("\n  Digite o {0}º fator: ", i);

                    if( i==1 )
                    {
                        res = double.Parse(Console.ReadLine());
                    } else
                    {
                        res -= double.Parse(Console.ReadLine());
                    }
                }
                break;

            case '*':
                for( int i=1; i <= qtdFatores; i++ )
                {
                    Console.Clear();

                    Console.WriteLine("\n~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                    Console.WriteLine("\t\t\tCalculadora");
                    Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~\n\n");

                    if( aux == 0 )
                    {
                        Console.WriteLine("\n  [ INSIRA UM NÚMERO MAIOR QUE 1 ]");
                    }

                    Console.WriteLine("\n  Digite a quantidade de fatores:  {0}\n", qtdFatores);
                    Console.Write("\n  Digite o {0}º fator: ", i);

                    if( i==1 )
                    {
                        res = double.Parse(Console.ReadLine());
                    } else
                    {
                        res *= double.Parse(Console.ReadLine());
                    }
                }
                break;

            case '/':
                for( int i=1; i <= qtdFatores; i++ )
                {
                    Console.Clear();

                    Console.WriteLine("\n~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                    Console.WriteLine("\t\t\tCalculadora");
                    Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~\n\n");

                    if( aux == 0 )
                    {
                        Console.WriteLine("\n  [ INSIRA UM NÚMERO MAIOR QUE 1 ]");
                    }

                    Console.WriteLine("\n  Digite a quantidade de fatores:  {0}\n", qtdFatores);
                    Console.Write("\n  Digite o {0}º fator: ", i);

                    if( i==1 )
                    {
                        res = double.Parse(Console.ReadLine());
                    } else
                    {
                        res /= double.Parse(Console.ReadLine());
                    }
                }
                break;
        }

        Console.WriteLine("\n  = " + res);
        Console.Write("\n  Usar a calculadora novamente? [S/N] \n\n  --> ");
        op = char.Parse(Console.ReadLine());

        switch(op)
        {
            case 's':
            case 'S':
                goto inicio;
            default:
                break;
        }
    }
}