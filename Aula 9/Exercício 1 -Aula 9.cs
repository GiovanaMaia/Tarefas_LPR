using System;

public struct Produto{
   public string Nome;
   public string Codigo;
   public int Preco;
   public int Quantidade;
    
}

class HelloWorld {
  static void Main() {
      
    int total=0;
    
    Produto[] dados = new Produto[3];

    for(int i=0; i<3 ;i++){
    Console.WriteLine("Digite o nome do produto: ");
    dados[i].Nome = Console.ReadLine();
    Console.WriteLine("Digite o código do produto: ");
    dados[i].Codigo = Console.ReadLine();
    Console.WriteLine("Digite o preço do produto: ");
    dados[i].Preco = int.Parse(Console.ReadLine());
    Console.WriteLine("Digite a quantidade do produto: ");
    dados[i].Quantidade = int.Parse(Console.ReadLine());
    
    }
    total = dados[0].Preco* dados[0].Quantidade +  dados[1].Preco* dados[1].Quantidade+  dados[2].Preco* dados[2].Quantidade;
    
    Console.WriteLine("O valor total em estoque: " + total); 
    

    
  }
}