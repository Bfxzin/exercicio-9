using System;

namespace SalarioProfessores
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a quantidade de horas/aula e o valor por hora do Professor 1:");
            int horas1 = int.Parse(Console.ReadLine());
            double valor1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite a quantidade de horas/aula e o valor por hora do Professor 2:");
            int horas2 = int.Parse(Console.ReadLine());
            double valor2 = double.Parse(Console.ReadLine());

            double salario1 = horas1 * valor1;
            double salario2 = horas2 * valor2;

            Console.WriteLine("Salário do Professor 1: R$ " + salario1.ToString("F2"));
            Console.WriteLine("Salário do Professor 2: R$ " + salario2.ToString("F2"));

            if (salario1 > salario2)
            {
                Console.WriteLine("O Professor 1 tem salário total maior.");
            }
            else if (salario2 > salario1)
            {
                Console.WriteLine("O Professor 2 tem salário total maior.");
            }
            else
            {
                Console.WriteLine("Os dois professores têm salário total igual.");
            }
        }
    }
}
