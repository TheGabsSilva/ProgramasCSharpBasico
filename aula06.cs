using System;
class Aula06{ 
     static DateTime ThisDate = DateTime.Now;
    
    static void Main(){
       double valorCompra=5.50;
       double valorVenda;
       double Lucro=0.5;
       double LucroTotal;
       string produto="Pastel";

        valorVenda= valorCompra+(valorCompra*Lucro);
        LucroTotal= valorVenda-valorCompra;
        Console.WriteLine("Produto.........:{0,15}",produto);
        Console.WriteLine("Val.Compra......:{0,15:c}",valorCompra);
        Console.WriteLine("Lucro...........:{0,15:p}",Lucro);
        Console.WriteLine("Val.Venda.......:{0,15:c}",valorVenda);
        Console.WriteLine("Lucro Total.....:{0,15:c}",LucroTotal);
        Console.WriteLine("Data e Hora:....:{0,15:F}",ThisDate);
    }
}