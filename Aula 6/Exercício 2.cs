//exercicio2
using System;

class HelloWorld {
  static void Main() {
       
       Random numAleatorio = new Random();
       int valorInteiro = numAleatorio.Next(1,100);
       int tentativas=0;
       int meu_numero;
    
    
    /*Console.WriteLine("Tente adivinhar o número sorteado:");
    meu_numero = int.Parse(Console.ReadLine());*/
    
        do{
           
    Console.WriteLine("Tente adivinhar o número sorteado:");
    meu_numero = int.Parse(Console.ReadLine());
    
        if (meu_numero<valorInteiro) 
    { 
        Console.WriteLine("Chutou baixo");
    }
     else if (meu_numero>valorInteiro) 
    { 
        Console.WriteLine("Chutou alto");
    }
     
    tentativas++;
     } while(meu_numero!=valorInteiro);
     
     Console.WriteLine("Parabéns, você acertou, o número sorteado foi o "+ valorInteiro);
     Console.WriteLine("Foram usadas " + tentativas);
     

  }
}