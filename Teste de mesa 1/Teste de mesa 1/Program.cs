using System;

class Exercicios
{
    static void Main()
    {
        int escolha;

        do
        {

            Console.WriteLine("================================================");
            Console.WriteLine("Escolha qual dos três exercício você quer que seja executado");
            Console.WriteLine("1 - Exercício 01");
            Console.WriteLine("2 - Exercício 02");
            Console.WriteLine("3 - Exercício 03");
            Console.WriteLine("0 - Sair");
            Console.WriteLine("================================================");

    
            escolha = int.Parse(Console.ReadLine());

            switch (escolha)
            {
                case 1:
                    Exercicio01();  
                    break;
                case 2:
                    Exercicio02();  
                    break;
                case 3:
                    Exercicio03();  
                    break;
                case 0:
                    Console.WriteLine("Saindo do programa.");
                    break;
                default:
                    Console.WriteLine("Opção inválida!");
                    break;
            }

        } while (escolha != 0);
    }

       
        static void Exercicio01()
        {
            int a = 10;
            int b = 20;
            int c = 0;
            int i = 0;
            int[] v = new int[4];

           
            c = (a + b) / 2;
            c = c - 40;

           
            Console.WriteLine($"O valor de a é: {a}");
            Console.WriteLine($"O valor de b é: {b}");
            Console.WriteLine($"O valor de c é: {c}");

        
            v[0] = a;
            v[1] = b;
            v[2] = c;
            v[3] = (a + b + c);

       
            Console.WriteLine("\nO vetor ficou assim:\n");
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine("| Índice | Valor |");
            Console.WriteLine("------------------------------------------------");

            for (i = 0; i < 4; i++)
            {
                Console.WriteLine($"|   {i, -5}    |  {v[i],-5}  |");
            }

            Console.WriteLine("------------------------------------------------");
        }

        
        static void Exercicio02()
        {
        int a = 2;
        int[] v  = new int[7];

        Console.WriteLine("\n------------------------------------------------");
        Console.WriteLine("| Índice | Valor |");
        Console.WriteLine("------------------------------------------------");


        while (a < 6)
        {
            v[a] = 10 * a;
            Console.WriteLine($"v[{a}] = {v[a]}");
            a++;

        }

        Console.WriteLine("------------------------------------------------");
    }


    static void Exercicio03()
    {

        int a = 7;
        int b = a - 6;
        int[] v = new int[10];

        do
        {
            v[b] = b + a;
            Console.WriteLine($"v[{b}] = {v[b]}");
            b = b + 2;
        }
        while (b < a);
        }
    }
