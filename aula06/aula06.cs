using System;

class Program {

    // static int n1,n2,n3;

   static double valorCompra = 5.50;
   static double valorVenda;

   static double lucro = 0.1;

   static string produto = "pastel";

   static  void Main()
    {
        // n1 = 10; 
        // n2 = 20;
        // n3 = 30;

        // Console.Write("n1={0},n2={1},n3={2}",n1,n2,n3);    passando valores por parametro

        valorVenda = valorCompra + (valorCompra * lucro);

        Console.WriteLine("Produto.........:{0,15}",produto);
        Console.WriteLine("ValCompra.......:{0,15:c}",valorCompra);
        Console.WriteLine("Lucro...........:{0,15:p}",lucro);
        Console.WriteLine("ValVenda........:{0,15:c}",valorVenda);



    }
}