using System;
class Aula09{
    static void Main(){
        int num,num1,bitwise;
        
        
        Console.Write("Digite o primeiro número: ");num=int.Parse(Console.ReadLine());
        Console.Write("Digite o segundo número: ");num1=int.Parse(Console.ReadLine());
        Console.Write("Digite o número de vezes que deseja dobrar e cortar pela a metade os números: ");bitwise=int.Parse(Console.ReadLine());
        
        num=num<<bitwise;
        num1=num1>>bitwise;

        Console.WriteLine("Número Dobrado: {0}",num);
        Console.WriteLine("Número Pela Metade: {0}",num1);
    }
}