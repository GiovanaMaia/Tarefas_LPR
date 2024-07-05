//ex3
using System; 
using System.Collections.Generic;
using System.Linq;

class HelloWorld {
    
  static void Main() {
      
    int qntd, idade, soma=0;
    float media=0;
    string nome, pessoaMaisNova= " ", pessoaMaisVelha=" ";  
    Dictionary<string, int> nomesIdades = new Dictionary<string, int>();
  
    Console.WriteLine("Digite quantos nomes serão inseridos: ");
    qntd = int.Parse(Console.ReadLine());
    
    for (int i = 0; i<qntd ; i++){
        
        Console.WriteLine("Digite o nome: ");
        nome = Console.ReadLine();
        Console.WriteLine("Digite a idade: ");
        idade = int.Parse(Console.ReadLine());
        
        nomesIdades.Add(nome, idade);
    }
    
    foreach (var pessoa in nomesIdades)
    {
        soma+=pessoa.Value;
}

    media = soma/qntd;
    
    Console.WriteLine( "Pessoas com nome acima da média");
    foreach (var pessoa in nomesIdades)
   {
     if(pessoa.Value>media)   {
         Console.WriteLine( pessoa.Key);
     }  
  }
  
   int menorIdade = nomesIdades.Values.Min();
   int maiorIdade = nomesIdades.Values.Max();
   
   foreach (var pessoa in nomesIdades)
   {
     if(pessoa.Value == menorIdade)   {
          pessoaMaisNova = pessoa.Key ;
     } 
     else if(pessoa.Value == maiorIdade)   {
          pessoaMaisVelha = pessoa.Key ;
     }  
  }
    Console.WriteLine( "Pessoa mais nova = " + pessoaMaisNova);
    Console.WriteLine( "Pessoa mais velha = " + pessoaMaisVelha);
    
    Console.WriteLine( "Digite a idade que vc quer remover da lista: " );
    int idade_excluir= int.Parse(Console.ReadLine());
    
    
   var idades_remover = nomesIdades.Where(kvp => kvp.Value == idade_excluir).Select(kvp => kvp.Key).ToList();//pesquisa (nao consigo remover direto)
        foreach (var chave in idades_remover) {
            nomesIdades.Remove(chave);
        }
   
   Console.WriteLine( "Dicionário atualizado: ");
   foreach (var pessoa in nomesIdades)
   {
     Console.WriteLine($" {pessoa.Key},  {pessoa.Value} anos");
     
}

}
    
}



  