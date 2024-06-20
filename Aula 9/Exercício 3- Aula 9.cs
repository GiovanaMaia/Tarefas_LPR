using System;

class HelloWorld {

    public struct Produto{
      public string Nome;
      public string Poder;
      public int Pontuacao;
}
        
    static Produto[] dados = new Produto[5];     
        
    static void cadastrarHeroi(int num){
        
    string nome;
    string poder;
    int pontuacao;
    
    Console.WriteLine("Digite o nome do heroí " + num);
    nome = Console.ReadLine();
    Console.WriteLine("Digite o poder do heroí:");
    poder = Console.ReadLine();
    Console.WriteLine("Digite a pontuação do heroí:");
    pontuacao  = int.Parse(Console.ReadLine());
    
    dados[num] = new Produto { Nome = nome, Poder = poder, Pontuacao = pontuacao };
     
}

    static string selecionarEquipe(){
        
    string membro1 = " ";
    string membro2 = " ";
    string membro3 = " ";
    int pontuacao1 = 0;
    int pontuacao2 = 0;
    int pontuacao3 = 0;
    string erro = " ";
    
    Console.WriteLine("Herois cadastrados:");
    Console.WriteLine("1-" + dados[0].Nome);
    Console.WriteLine("2-" + dados[1].Nome);
    Console.WriteLine("3-" + dados[2].Nome);
    Console.WriteLine("4-" + dados[3].Nome);
    Console.WriteLine("5-" + dados[4].Nome);
        
    
        
        Console.WriteLine("Digite o numero dos herois que deseja incluir em sua equipe: ");
     int escolha1 = int.Parse(Console.ReadLine());
     int escolha2 = int.Parse(Console.ReadLine());
     int escolha3 = int.Parse(Console.ReadLine());
     

     if (dados[1].Nome == " " &&  dados[2].Nome == " " )
    {
        erro += "Cadastre mais dois heróis para selecioná-los..\n";
        return erro;
    }
    else if (  dados[2].Nome == " ")
    {
        erro += "Cadastre mais um herói para selecioná-los..\n";
        return erro;
        
    }
    
    switch(escolha1){
            case 1:
            membro1 = dados[0].Nome;
            pontuacao1 = dados[0].Pontuacao;
           
            break;
            case 2:
            membro1 = dados[1].Nome;
            pontuacao1 = dados[1].Pontuacao;
            
            break;
            case 3:
            membro1 = dados[2].Nome;
            pontuacao1 = dados[2].Pontuacao;
            break;
            
            case 4:
            membro1 = dados[3].Nome;
            pontuacao1 = dados[3].Pontuacao;
            break;
            
            case 5:
            membro1 = dados[4].Nome;
            pontuacao1 = dados[4].Pontuacao;
            break;
        }
        
        switch(escolha2){
            case 1:
            membro2 = dados[0].Nome;
            pontuacao2 = dados[0].Pontuacao;
           
            break;
            case 2:
            membro2 = dados[1].Nome;
            pontuacao2 = dados[1].Pontuacao;
            
            break;
            case 3:
            membro2 = dados[2].Nome;
            pontuacao2 = dados[2].Pontuacao;
            break;
            
            case 4:
            membro2 = dados[3].Nome;
            pontuacao2 = dados[3].Pontuacao;
            break;
            
            case 5:
            membro2 = dados[4].Nome;
            pontuacao2 = dados[4].Pontuacao;
            break;
        }
        
        switch(escolha3){
            case 1:
            membro3 = dados[0].Nome;
            pontuacao3 = dados[0].Pontuacao;
           
            break;
            case 2:
            membro3 = dados[1].Nome;
            pontuacao3 = dados[1].Pontuacao;
            
            break;
            case 3:
            membro3 = dados[2].Nome;
            pontuacao3 = dados[2].Pontuacao;
            break;
            
            case 4:
            membro3 = dados[3].Nome;
            pontuacao3 = dados[3].Pontuacao;
            break;
            
            case 5:
            membro3 = dados[4].Nome;
            pontuacao3 = dados[4].Pontuacao;
            break;
        }
     
            
        Console.WriteLine("Heróis selecionados!");
        calcularPontuacaoTotal(pontuacao1,pontuacao2,pontuacao3);
        
        string equipe = membro1 + "\n" + membro2 + "\n"+ membro3;
        return equipe;
     
    }
        
  static int calcularPontuacaoTotal(int pontuacao1 = 0 , int pontuacao2 = 0, int pontuacao3 = 0){
      
    int total = pontuacao1 + pontuacao2 + pontuacao3; 
    
    return total;
    
}
    
    static string exibirEquipe( string Equipe){
    
    string aEquipe = "Sua equipe: " + "\n" + Equipe;
    return aEquipe;
    
}
    
    static void menuPrincipal( )
{
    int escolha, cadastro=0; 
    bool condicao = true;

      
   while (condicao){

    Console.WriteLine("Menu:");
    Console.WriteLine("1.Cadastrar herói");
    Console.WriteLine("2.Selecionar equipe");
    Console.WriteLine("3.Exibição da equipe");
    Console.WriteLine("4.Sair do programa");
    escolha = int.Parse(Console.ReadLine());
    
    
    switch(escolha){
        
        case 1:
         cadastro= cadastro + 1;
        
        if (cadastro == 1){
            
              cadastrarHeroi(0);
             Console.WriteLine("Heroi 1 cadastrado com sucesso");
        }
        else if (cadastro == 2){
            
             cadastrarHeroi(1);
             Console.WriteLine("Heroi 2 cadastrado com sucesso");
             
        }
        else if (cadastro == 3){
            
             cadastrarHeroi(2);
             Console.WriteLine("Heroi 3 cadastrado com sucesso");
           
        }
       else if (cadastro == 4){
            
             cadastrarHeroi(3);
             Console.WriteLine("Heroi 4 cadastrado com sucesso");
           
        }
        else if (cadastro == 5){
            
            cadastrarHeroi(4);
             Console.WriteLine("Heroi 5 cadastrado com sucesso");
          
        }
        else if (cadastro >5){
            
            Console.WriteLine("Não é possível cadastrar mais de 5 heróis");
           
        }
        break;
        
        case 2:
        selecionarEquipe();
        break;
        
        case 3:
        string exibir = selecionarEquipe();
        int pontuacao = calcularPontuacaoTotal();
        Console.WriteLine("Sua equipe: \n"+ exibir);
        Console.WriteLine("Sua equipe: \n"+ pontuacao);
        break;
        
        case 4:
        Console.WriteLine("Até a próxima!!"); 
        condicao=false;
        
        break;
    }   
   }
}
   
   
     static void Main() {

    menuPrincipal( );
  }
 
}   