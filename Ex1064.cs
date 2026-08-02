using System;

class Ex1064{
    
    static void Main()
    {
        double numeros, soma = 0.0 , media;
        int quantpo = 0, i;
        //Console.WriteLine("Digite 6 valores: ");
        for(i=1; i<=6; i++)
        {
          numeros = double.Parse(Console.ReadLine());
          if(numeros > 0)
            {
                quantpo++;
                soma += numeros;   
            }  
        }
        media = soma/quantpo;

        Console.WriteLine(quantpo + " valores positivos");
        Console.WriteLine($"{media:F1}");
    }
}