
class Program{
    static void Main(string[] args){
        
        Exercicios1();
        Exercicios2();
    }
    
    static void Exercicios1(){        
        int idadeUsuario = 0;
        string nomeUsuario = "";

        Console.WriteLine("Digite seu nome:");
        nomeUsuario = Console.ReadLine();

        Console.WriteLine("Digite sua idade:");
        idadeUsuario = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine($"Seu nome é  {nomeUsuario},e você tem {idadeUsuario} anos.");
    }

    static void Exercicios2(){
        int numero1 = 0;
        int numero2 = 0;
        int resultado = 0;

        Console.WriteLine("Digite o primeiro número:");
        numero1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Digite o segundo número:");
        numero2 = Convert.ToInt32(Console.ReadLine());

        resultado = numero1 + numero2;

        Console.WriteLine($"A soma de {numero1} e {numero2} é {resultado}");
    }
}

