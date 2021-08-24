using System;

namespace CALCULADORA
{
    class Program
    {
        enum menu {soma=1, subt, mult, div, pot, raiz, sair}

        static void Main(string[] args)
        {
            bool saida = false;
            while (!saida)

            {
                Console.WriteLine("\n\t\t -------- CALCULADORA -------- \n\n\t\tDIGITE A OPÇÃO DESEJADA\n\n1 - Adição\n2 - Subtração\n3 - Multiplicação\n4 - Divisão\n5 - Potência\n6 - Raiz Quadrada\n7 - Sair");
                menu opcao = (menu)int.Parse(Console.ReadLine());

                switch (opcao)

                {
                    case menu.soma:
                    soma();
                    break;

                    case menu.subt:
                    subt();
                    break;

                    case menu.mult:
                    mult();
                    break;

                    case menu.div:
                    div();
                    break;

                    case menu.pot:
                    pot();
                    break;

                    case menu.raiz:
                    raiz();
                    break;
                
                    case menu.sair:
                    saida = true;
                    break;

                    default:
                    Console.Clear();
                    Console.WriteLine("\n\n\t\t ---------- SELECIONE UMA OPÇÃO VÁLIDA ----------\n\n");
                    break;
                }


            
            }
            
        }

            static void soma()
            {
                Console.Clear();
                Console.WriteLine("Digite o primeiro número que deseja somar:");
                float a = float.Parse(Console.ReadLine());
                Console.WriteLine("Digite o segundo número que deseja somar:");
                float b = float.Parse(Console.ReadLine());
                float resultado = (a+b);
                Console.WriteLine("\nO resultado da soma de " + a + "+" + b + " é igual a " + resultado);
                Console.WriteLine("\n\nAperte ENTER para voltar ao Menu");
                Console.ReadLine();
                Console.Clear();
            }

            static void subt()
            {
                Console.Clear();
                Console.WriteLine("Digite o primeiro número que deseja substrair:");
                float a = float.Parse(Console.ReadLine());
                Console.WriteLine("Digite o segundo número que deseja substrair:");
                float b = float.Parse(Console.ReadLine());
                float resultado = (a-b);
                Console.WriteLine("\nO resultado da substração de " + a + "-" + b + " é igual a " + resultado);
                Console.WriteLine("\n\nAperte ENTER para voltar ao Menu");
                Console.ReadLine();
                Console.Clear();
            }

            static void mult()
            {
                Console.Clear();
                Console.WriteLine("Digite o primeiro número que deseja multiplicar:");
                float a = float.Parse(Console.ReadLine());
                Console.WriteLine("Digite o segundo número que deseja multiplicar:");
                float b = float.Parse(Console.ReadLine());
                float resultado = (a*b);
                Console.WriteLine("\nO resultado da multiplicação de " + a + "*" + b + " é igual a " + resultado);
                Console.WriteLine("\n\nAperte ENTER para voltar ao Menu");
                Console.ReadLine();
                Console.Clear();
            }

            static void div()
            {
                Console.Clear();
                Console.WriteLine("Digite o primeiro número que deseja dividir:");
                float a = float.Parse(Console.ReadLine());
                Console.WriteLine("Digite o segundo número que deseja dividir:");
                float b = float.Parse(Console.ReadLine());
                float resultado = (a/b);
                Console.WriteLine("\nO resultado da divisão de " + a + "/" + b + " é igual a " + resultado);
                Console.WriteLine("\n\nAperte ENTER para voltar ao Menu");
                Console.ReadLine();
                Console.Clear();
            }

            static void pot()
            {
                Console.Clear();
                Console.WriteLine("Digite o número base:");
                float a = float.Parse(Console.ReadLine());
                Console.WriteLine("Digite o expoente:");
                float b = float.Parse(Console.ReadLine());
                double resultado = Math.Pow(a,b);
                Console.WriteLine("\nO resultado da potência de " + a + " por " + b + " é igual a " + resultado);
                Console.WriteLine("\n\nAperte ENTER para voltar ao Menu");
                Console.ReadLine();
                Console.Clear();
            }

            static void raiz()
            {
                Console.Clear();
                Console.WriteLine("Digite o número que deseja obter raiz quadrada:");
                float a = float.Parse(Console.ReadLine());
                double resultado = Math.Sqrt(a);
                Console.WriteLine("\nO resultado da raiz quadrada de " + a + " é igual a " + resultado);
                Console.WriteLine("\n\nAperte ENTER para voltar ao Menu");
                Console.ReadLine();
                Console.Clear();
            }

    }
}
