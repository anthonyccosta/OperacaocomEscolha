using System.ComponentModel.Design;

double num1  = 0, num2 = 0, num3 = 0, num4 = 0;    //double para poder receber valores sejam int ou decimais;

    Console.WriteLine("Digite o valor 1:");
    num1 = Double.Parse(Console.ReadLine());
  
do //pedir que o numero 2 seja diferente de 0 em loop ate que se altere para outro valor
{
    Console.WriteLine("Digite o valor 2:");
    num2 = Double.Parse(Console.ReadLine());

    if (num2 == 0)
    {
        Console.WriteLine("**Numero 2 não pode ser 0 ");
    }
} while (num2 == 0);

do //pedir que o numero 3 seja diferente de 0 em loop ate que se altere para outro valor
{
    Console.WriteLine("Digite o valor 3:");
    num3 = Double.Parse(Console.ReadLine());
    if (num3 == 0)
    {
        Console.WriteLine("**Numero 3 não pode ser 0 ");
    }
} while (num3 == 0);

do //pedir que o numero 4 seja diferente de 0 em loop ate que se altere para outro valor
{
    Console.WriteLine("Digite o valor 4:");
    num4 = Double.Parse(Console.ReadLine());

    if (num4 == 0)
    {
        Console.WriteLine("**Numero 4 não pode ser 0");
    }
} while (num4 == 0);

// Menu de opções

Console.WriteLine("\nEscolha a operação:");
    Console.WriteLine("1 - Soma");
    Console.WriteLine("2 - Subtração");
    Console.WriteLine("3 - Multiplicação");
    Console.WriteLine("4 - Divisão");
    Console.Write("Digite sua opção: ");

    int opcao = int.Parse(Console.ReadLine()); //variavel opção receber valor int (1-4)

    while (true) //enquanto 1-4 for digitado
    {
        if (opcao == 1)
        {
            double soma = num1 + num2 + num3 + num4;
            Console.WriteLine("Soma:" + soma);
        }
        else if (opcao == 2)
        {
            double subtracao = num1 - num2 - num3 - num4;
            Console.WriteLine("Subtração: " + subtracao);
        }
        else if (opcao == 3)
        {
            double multiplicacao = num1 * num2 * num3 * num4;
            Console.WriteLine("Multiplicação: " + multiplicacao);
        }
        else if (opcao == 4)
        {
            if (num3 == 0 || num4 == 0)
            {
                Console.WriteLine("Impossível dividir por zero!");
            }
            else
            {
                double divisao = num1 / num2 / num3 / num4;
                Console.WriteLine("Divisão: " + divisao);
            }
        }
        else // se digitado acima de 4 ou menos que 1
        {
            Console.WriteLine("Opção inválida!");
        }

        // Perguntar se deseja realizar outra operação       
            Console.WriteLine("\nDeseja realizar outra operação? (s/n)");
            string resposta = Console.ReadLine();

        if (resposta == "s") // ele repete tudo novamente se dito 's'
        {
            //aqui estou pedindo para o user colocar nvmente os valores, e nao reutilizar os anteriores
            Console.WriteLine("Digite o valor 1:");
            num1 = Double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor 2:");
            num2 = Double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor 3:");
            num3 = Double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor 4:");
            num4 = Double.Parse(Console.ReadLine());

        // Reiniciar processo de escolha da operação
        Console.WriteLine("\nEscolha a operação:");
            Console.WriteLine("1 - Soma");
            Console.WriteLine("2 - Subtração");
            Console.WriteLine("3 - Multiplicação");
            Console.WriteLine("4 - Divisão");
            Console.Write("Digite sua opção: ");
            opcao = int.Parse(Console.ReadLine());
        }
        else if (resposta == "n") //e encerra se dito 'n'
        {            
            break;
        }
        else // e corrige se escrito outra coisa
        {
            Console.WriteLine("Resposta Inválida, digite s ou n");
        }        
    }
Console.ReadKey();