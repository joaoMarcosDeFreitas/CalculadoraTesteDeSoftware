namespace CalculadoraTeste
{
    public class Aplicacao
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Bem-vindo à Calculadora!");
            Console.WriteLine("Escolha a operação: \n\n1 - Somar\n2 - Subtrair\n3 - Multiplicar\n4 - Dividir");

            String resposta = Console.ReadLine().Trim();

            Double resultado = 0;

            if (resposta != "1" && resposta != "2" && resposta != "3" && resposta != "4")
            {
                Console.WriteLine("Opção inválida. Reinicie o sistema e escolha uma opção válida.");
                return;
            }

            Console.WriteLine("Digite o primeiro numero: ");
            Double numero1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite o segundo número: ");
            Double numero2 = Convert.ToDouble(Console.ReadLine());

            switch (resposta)
            {
                default:
                    Console.WriteLine("Opção inválida. Reinicie o sistema e escolha uma opção válida.");
                    break;

                case "1":
                    resultado = Calculadora.Somar(numero1, numero2);
                    Console.WriteLine("Resultado da soma: " + resultado.ToString());
                    break;

                case "2":
                    resultado = Calculadora.Subtrair(numero1, numero2);
                    Console.WriteLine("Resultado da subtração: " + resultado.ToString());
                    break;

                case "3":
                    resultado = Calculadora.Multiplicar(numero1, numero2);
                    Console.WriteLine("Resultado da multiplicação: " + resultado.ToString());
                    break;

                case "4":
                    try
                    {
                        resultado = Calculadora.Dividir(numero1, numero2);
                        Console.WriteLine("Resultado da divisão: " + resultado.ToString());
                    }
                    catch (DivideByZeroException ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    break;
            }
        }
    }

    public class Calculadora
    {
        public static Double Somar(Double parcela, Double parcela1)
        {
            return parcela + parcela1;
        }

        public static Double Subtrair(Double minuendo, Double subtraendo)
        {
            return minuendo - subtraendo;
        }

        public static Double Multiplicar(Double fator1, Double fator2)
        {
            return fator1 * fator2;
        }

        public static Double Dividir(Double dividendo, Double divisor)
        {
            if (divisor == 0)
            {
                throw new DivideByZeroException("O divisor não pode ser zero.");
            }
            return dividendo / divisor;
        }
    }
}
