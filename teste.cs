using System;
class ProgramaDeTeste{
    static void Main(){
        string nome,sexo,end,tel; 
        double sal,custo,renda,renbru; 
        int idade,dep;

        Console.Write("Digite seu nome: ");nome=Console.ReadLine();
        Console.Write("Digite seu sexo: ");sexo=Console.ReadLine();
        Console.Write("Digite seu Endereço: ");end=Console.ReadLine();
        Console.Write("Digite seu telefone: ");tel=Console.ReadLine();
        Console.Write("Digite sua idade: ");idade=int.Parse(Console.ReadLine());
        Console.Write("Digite seu salário: ");sal=Convert.ToDouble(Console.ReadLine());
        Console.Write("Digite seu custo: ");custo=Convert.ToDouble(Console.ReadLine());
        Console.Write("Digite seu número de dependentes: ");dep=int.Parse(Console.ReadLine());
        
        renda = sal-custo; 
        renbru= sal/dep;
        
        Console.WriteLine("\nO seu nome é: {0}",nome);
        Console.WriteLine("O seu sexo é: {0}",sexo);
        Console.WriteLine("O seu endereço é: {0}",end);
        Console.WriteLine("O seu telefone é: {0}",tel);
        Console.WriteLine("A sua idade é: {0} anos",idade);
        Console.WriteLine("O seu salário é: {0:c}",sal);
        Console.WriteLine("O seu custo foi: {0:c}",custo);
        Console.WriteLine("A sua renda é: {0:c}",renda);
        Console.WriteLine("A sua renda bruta é: {0:c}",renbru);

    }
}