using System;

class HelloWorld {
  static void Main() {
    
     int condicao = 1, distancia =0;
     int [,]matriz = { { 0, 524, 521, 882 },{ 524, 0, 434, 586 }, { 521, 434, 0, 429 },{ 882, 586, 429, 0 } };
 
    while(condicao==1) {
        
    Console.WriteLine("Digite a cidade de origem");
    string origem = Console.ReadLine();
    Console.WriteLine("Digite a cidade de destino");
    string destino = Console.ReadLine();
    
     if (origem == "Vitória" && destino == "Belo Horizonte" || origem == "Belo Horizonte" && destino == "Vitória"){
        distancia = matriz[0,1];
        Console.WriteLine("Distância = "+ distancia);
    }
     else if (origem == "Vitória" && destino == "Rio de Janeiro" || origem == "Rio de Janeiro" && destino == "Vitória"){
        distancia = matriz[0,2];
        Console.WriteLine("Distância = "+ distancia);
    }
     else if (origem == "Vitória" && destino == "São Paulo" || origem == "São Paulo" && destino == "Vitória"){
        distancia = matriz[0,3];
        Console.WriteLine("Distância = "+ distancia);
    }
    else if (origem == "Belo Horizonte" && destino == "Rio de Janeiro" || origem == "Rio de Janeiro" && destino == "Belo Horizonte"){
        distancia = matriz[1,2];
        Console.WriteLine("Distância = "+ distancia);
    }
    else if (origem == "Belo Horizonte" && destino == "São Paulo" || origem == "São Paulo" && destino == "Belo Horizonte"){
        distancia = matriz[1,3];
        Console.WriteLine("Distância = "+ distancia);
    }
    else if (origem == "Rio de Janeiro" && destino == "São Paulo" || origem == "São Paulo" && destino == "Rio de Janeiro"){
        distancia = matriz[2,3];
        Console.WriteLine("Distância = "+ distancia);
    }

      else if(origem == destino) {
        
        condicao = 0;
    }   
    }
  
  }
}