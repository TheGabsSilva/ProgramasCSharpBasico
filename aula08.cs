using System;
class Aula08{
    static void Main(){
        int v1,v2,v3,soma;
        string nome;
        double media;
        
        Console.Write("Digite seu nome: ");nome=Console.ReadLine();
        Console.Write("Digite o primeiro valor: ");v1=int.Parse(Console.ReadLine());
        Console.Write("Digite o segundo valor: ");v2=Convert.ToInt32(Console.ReadLine());
        Console.Write("Digite o terceiro valor: ");v3=int.Parse(Console.ReadLine());
       
        soma = v1+v2+v3; 
        media = soma/3;
       if(v1>v2){
            Console.Write("O número {0} é maior que o número {1}",v1,v2);
       } 
        if(v2>v3){
            Console.Write("\nO numero {0} é maior que o número {1}",v2,v3);
        }   
        Console.WriteLine("\nO seu nome é: {0}",nome);
        Console.WriteLine("A soma dos valores {0} + {1} + {2} foi: {3}",v1,v2,v3,soma);
        Console.WriteLine("A media foi: {0}", media.ToString("N2"));
    }
}