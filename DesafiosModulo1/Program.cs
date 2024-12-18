namespace DesafiosModulo1
{
    using System;
    using System.Text.RegularExpressions;

    class Program
    {
        //Exer1
        /*static void Main(string[] args)
        {
            Console.WriteLine("Por favor, digite seu nome:");
            string nome = Console.ReadLine();

            Console.WriteLine($"Olá, {nome}! Seja muito bem-vindo!");
            Console.ReadLine();//só para não fechar ao executar por completo
        }*/

        //Exer2
        /*static void Main(string[] args)
        {
            Console.WriteLine("Por favor, digite seu nome:");
            string nome = Console.ReadLine();

            Console.WriteLine("Por favor, digite seu sobrenome:");
            string sobrenome = Console.ReadLine();

            string nomeCompleto = nome + " " + sobrenome;

            Console.WriteLine($"Nome completo: {nomeCompleto}");
            Console.ReadLine();//só para não fechar ao executar por completo
        }*/

        //Exer3
        /*static void Main(string[] args)
        {
            // Declaração dos valores
            double numero1 = 12.5;
            double numero2 = 4.5;

            // Soma
            double soma = numero1 + numero2;

            // Subtração
            double subtracao = numero1 - numero2;

            // Multiplicação
            double multiplicacao = numero1 * numero2;

            // Divisão (com verificação de zero)
            double divisao = 0;
            if (numero2 != 0)
            {
                divisao = numero1 / numero2;
            }
            else
            {
                Console.WriteLine("Erro: Divisão por zero não é permitida!");
            }

            // Média
            double media = (numero1 + numero2) / 2;

            // Exibição dos resultados
            Console.WriteLine($"Números: {numero1} e {numero2}");
            Console.WriteLine($"Soma: {soma}");
            Console.WriteLine($"Subtração: {subtracao}");
            Console.WriteLine($"Multiplicação: {multiplicacao}");
            if (numero2 != 0)
            {
                Console.WriteLine($"Divisão: {divisao}");
            }
            Console.WriteLine($"Média: {media}");
            Console.ReadLine();//só para não fechar ao executar por completo
        }*/

        //Exer4
        /*static void Main(string[] args)
        {
            Console.WriteLine("Digite uma ou mais palavras (separadas por espaço):");
            string input = Console.ReadLine();

            // Dividindo a entrada em palavras
            string[] palavras = input.Split(' ');

            Console.WriteLine("\nQuantidade de caracteres em cada palavra:");
            foreach (string palavra in palavras)
            {
                Console.WriteLine($"Palavra: \"{palavra}\" - {palavra.Length} caracteres");
            }
            Console.ReadLine();//só para não fechar ao executar por completo
        }*/

        //Exer5
        /*static void Main(string[] args)
        {
            Console.WriteLine("Digite a placa do veículo:");
            string placa = Console.ReadLine()?.Trim();

            // Expressão regular para validar a placa
            string padraoPlaca = @"^[A-Za-z]{3}[0-9]{4}$";

            // Verificar se a placa é válida
            bool placaValida = Regex.IsMatch(placa, padraoPlaca);

            // Exibir o resultado
            Console.WriteLine(placaValida ? "Verdadeiro" : "Falso");

            Console.ReadLine();//só para não fechar ao executar por completo
        }*/

        //Exer6
        static void Main(string[] args)
        {
            // Obter a data e hora atual
            DateTime dataAtual = DateTime.Now;

            Console.WriteLine("Escolha um formato para exibir a data/hora:");
            Console.WriteLine("1 - Formato completo");
            Console.WriteLine("2 - Apenas a data no formato '01/03/2024'");
            Console.WriteLine("3 - Apenas a hora no formato de 24 horas");
            Console.WriteLine("4 - A data com o mês por extenso");

            string opcao = Console.ReadLine();

            switch (opcao)
            {
                case "1":
                    // Formato completo
                    Console.WriteLine($"Formato completo: {dataAtual:dddd, dd 'de' MMMM 'de' yyyy, HH:mm:ss}");
                    break;
                case "2":
                    // Apenas a data no formato "01/03/2024"
                    Console.WriteLine($"Data: {dataAtual:dd/MM/yyyy}");
                    break;
                case "3":
                    // Apenas a hora no formato de 24 horas
                    Console.WriteLine($"Hora: {dataAtual:HH:mm}");
                    break;
                case "4":
                    // A data com o mês por extenso
                    Console.WriteLine($"Data com mês por extenso: {dataAtual:dd 'de' MMMM 'de' yyyy}");
                    break;
                default:
                    Console.WriteLine("Opção inválida.");
                    break;
            }
            Console.ReadLine();//só para não fechar ao executar por completo
        }
    }
}
