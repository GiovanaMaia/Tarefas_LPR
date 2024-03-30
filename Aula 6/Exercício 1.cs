//exercicio 1
using System;
class HelloWorld {
  static void Main() {
      
    int contador=0;
    double soma=0;
    int quantidade_num;
    int num_analisado;
    int quantidade_par=0;
    double media;
    
    Console.WriteLine("Coloque a quantidade de números que serão digitados:");
    quantidade_num = int.Parse(Console.ReadLine());
    
    while(contador<quantidade_num){
        
    Console.WriteLine("Digite um número:");
    num_analisado = int.Parse(Console.ReadLine());
       if (num_analisado%2==0){
           
           soma += num_analisado;
           quantidade_par++;
       }
       contador++;

    }
        media = soma/quantidade_par;
        Console.WriteLine("A media é:"+ media);
    
  }
}