using System;

class HelloWorld {
  
static int calcularPontuacaoTotal(int pontuacao1 = 0 , int pontuacao2 = 0, int pontuacao3 = 0){
      
    int total = pontuacao1 + pontuacao2 + pontuacao3; 
    
    return total;
    
}
static string cadastrarHeroi(string num = "1"){
    string nome;
    string poder;
    string pontuacao;
    Console.WriteLine("Digite o nome do heroí "+ num);
    nome = Console.ReadLine();
    Console.WriteLine("Digite o poder do heroí:");
    poder = Console.ReadLine();
    Console.WriteLine("Digite a pontuação do heroí:");
    pontuacao  = Console.ReadLine();
    
    string cadastro = nome + "\n" + poder + "\n" + pontuacao;
    
    //menuPrincipal(pontuacao);
     return cadastro;
}

static string selecionarEquipe(string A = " ", string B = " ", string C = " ", string D = " ", string E = " ",string pontA=" ", string pontB=" ", string pontC=" ",string pontD=" ",string pontE=" "){
    string membro1 = " ";
    string membro2 = " ";
    string membro3 = " ";
    int pontuacao1 = 0;
    int pontuacao2 = 0;
    int pontuacao3 = 0;
    string erro = " ";
    
    Console.WriteLine("Herois cadastrados:");
    Console.WriteLine("1-" + A);
    Console.WriteLine("2-" + B);
    Console.WriteLine("3-" + C);
    Console.WriteLine("4-" + D);
    Console.WriteLine("5-" + E);
    
    if (B == " " &&  C == " " )
    {
        erro += "Cadastre mais dois heróis para selecioná-los..\n";
        return erro;
    }
    else if (  C == " ")
    {
        erro += "Cadastre mais um herói para selecioná-los..\n";
        return erro;
        
    }
    else {
    Console.WriteLine("Digite o numero dos herois que deseja incluir em sua equipe: ");
     int escolha1 = int.Parse(Console.ReadLine());
     int escolha2 = int.Parse(Console.ReadLine());
     int escolha3 = int.Parse(Console.ReadLine());
     
     
       if (escolha1==escolha2 || escolha1==escolha3 || escolha2==escolha3 ){
           erro += "Não é possível escolher o mesmo heroi mais de uma vez.Tente Novamente.\n";
            return erro;
            }
     
        switch(escolha1){
            case 1:
            membro1 = A;
            int.TryParse(pontA, out  pontuacao1 );
           
            break;
            case 2:
            membro1 = B;
            int.TryParse(pontB, out pontuacao1 );
            
            break;
            case 3:
            membro1 = C;
            int.TryParse(pontC, out pontuacao1 );
            
            break;
            case 4:
            membro1 = D;
            int.TryParse(pontD, out pontuacao1 );
            break;
            case 5:
            membro1 = E;
            int.TryParse(pontE, out pontuacao1 );
            break;
        }
        switch(escolha2){
            case 1:
            membro2 = A;
            int.TryParse(pontA, out pontuacao2 );
            break;
            case 2:
            membro2 = B;
            int.TryParse(pontB, out pontuacao2 );
            break;
            case 3:
            membro2 = C;
             int.TryParse(pontC, out pontuacao2 );
            break;
            case 4:
            membro2 = D;
             int.TryParse(pontD, out pontuacao2 );
            break;
            case 5:
            membro2 = E;
             int.TryParse(pontE, out pontuacao2 );
            break;
        }
        switch(escolha3){
            case 1:
            membro3 = A;
            int.TryParse(pontA, out pontuacao3 );
            break;
            case 2:
            membro3 = B;
             int.TryParse(pontB, out pontuacao3 );
            break;
            case 3:
            membro3 = C;
            int.TryParse(pontC, out pontuacao3 );
            break;
            case 4:
            membro3 = D;
             int.TryParse(pontD, out pontuacao3 );
            break;
            case 5:
            membro3 = E;
            int.TryParse(pontE, out pontuacao3);

            break;
            
        }
        Console.WriteLine("Herois selecionados!!");
        
       calcularPontuacaoTotal(pontuacao1,pontuacao2,pontuacao3);
        
        string equipe = membro1 + "\n" + membro2 + "\n"+ membro3;
        return equipe;
        
        
    
    }
}


static string exibirEquipe( string Equipe){
    
    string aEquipe = "Sua equipe: " + "\n" + Equipe;
    return aEquipe;
    
}


static void menuPrincipal( string pontuacao = " ")
{
    int escolha, cadastro=0; 
    bool condicao = true;
      string heroi1 = " ";
      string heroi2 = " ";
      string heroi3 = " ";
      string heroi4 = " ";
      string heroi5 = " ";

      string minhaEquipe = " ";
      string mostraEquipe = " ";
      
   while ( condicao){

    Console.WriteLine("Menu:");
    Console.WriteLine("1.Cadastrar herói");
    Console.WriteLine("2.Selecionar equipe");
    Console.WriteLine("3.Pontuação Total da Equipe:");
    Console.WriteLine("4.Exibição da equipe");
    Console.WriteLine("5.Sair do programa");
    escolha = int.Parse(Console.ReadLine());
    
    
    switch(escolha){
        
        case 1:
         cadastro= cadastro + 1;
        
        if (cadastro == 1){
            
             heroi1 = cadastrarHeroi();
             Console.WriteLine("Heroi 1 cadastrado com sucesso");
        }
        else if (cadastro == 2){
            
             heroi2 = cadastrarHeroi();
             Console.WriteLine("Heroi 2 cadastrado com sucesso");
             
        }
        else if (cadastro == 3){
            
            heroi3 = cadastrarHeroi();
             Console.WriteLine("Heroi 3 cadastrado com sucesso");
           
        }
       else if (cadastro == 4){
            
             heroi4 = cadastrarHeroi();
             Console.WriteLine("Heroi 4 cadastrado com sucesso");
           
        }
        else if (cadastro == 5){
            
             heroi5 = cadastrarHeroi();
             Console.WriteLine("Heroi 5 cadastrado com sucesso");
          
        }
        else if (cadastro >5){
            
            Console.WriteLine("Não é possível cadastrar mais de 5 heróis");
           
        }
        break;
        
        case 2:
        
         if (heroi1 == " " || heroi2 == " " || heroi3 == " " ) {
        Console.WriteLine("Cadastre heróis no mínimo 3 herois antes de selecionar a equipe.");}
        else{
        minhaEquipe =  selecionarEquipe(heroi1, heroi2, heroi3, heroi4, heroi5);
        }
        break;
        
        case 3:
        
        int pontos = calcularPontuacaoTotal();
         Console.WriteLine("A pontuação total da sua equipe é " + pontos);
       
        
        break;
       
       case 4:
         mostraEquipe = exibirEquipe(minhaEquipe);
         Console.WriteLine(mostraEquipe); 
       break;
       
       case 5:
             Console.WriteLine("Até a próxima!!"); 

        condicao=false;
        break;
    }
    
    
 
   }   
    
}

static void Main (){
    
    menuPrincipal();
}

}