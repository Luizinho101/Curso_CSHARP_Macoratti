using System;

namespace ProjetoCSharp
{
    class Program
    {
        static void Main(string[] args)
        {

            //Exercicio1();
            //Exercicio2();
            Exercicio3();
        }

        static void Exercicio1()
        {
            double valorEntrada = 0;
            Console.WriteLine("------------------Exercício 1-------------");
            Console.WriteLine("Digite um número decimal(double): ");
            valorEntrada = Convert.ToDouble(Console.ReadLine());
            int numero = Convert.ToInt32(valorEntrada);
            Console.WriteLine($"Número convertido para string: {numero}");
    
        }
        static void Exercicio2()
        {
            double valorEntrada = 0;
            Console.WriteLine("------------------Exercício 2-------------");
            Console.WriteLine("Digite um número: ");
            valorEntrada = Convert.ToDouble(Console.ReadLine());
            string numeroComoString = Convert.ToString(valorEntrada);
            Console.WriteLine($"Número convertido: {numeroComoString}");
    
        }
        static void Exercicio3()
        {
        
            Console.WriteLine("------------------Exercício 3-------------");
            Console.WriteLine("Digite um número: ");
            double valorEntrada = Convert.ToDouble(Console.ReadLine());

            if(valorEntrada == 0) 
            {
                bool valorBooleano = Convert.ToBoolean(valorEntrada); // false
                Console.WriteLine($"Valor booleano: {valorBooleano}");
            
            } 
            else
            {
                bool valorBooleano = Convert.ToBoolean(valorEntrada); // true
                Console.WriteLine($"Valor booleano: {valorBooleano}");
            
            }

        }
    }
}
