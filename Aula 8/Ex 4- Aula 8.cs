using System;
class HelloWorld {
  static void Main() {
    int a=0, b=0,c=0, d=0, e=0, f=0, g=0, h=0, I=0;
    int acumuladorA=0,acumuladorB=0,acumuladorC=0,acumuladorD=0,acumuladorE=0,acumuladorF=0,acumuladorG=0,acumuladorH=0,acumuladorI=0;
    
    int [,]matrizA={
        {5,-2,3},
        {-5,5,2},
        {2,-3,5}
    };
    int [,]matrizB={
        {5,-3,2},
        {-2,3,5},
        {4,3,1}
    };
    int [,]matrizResultado={
        {0,0,0},     // {A,D,G},
        {0,0,0},    //  {B,E,H},
        {0,0,0}    //   {C, F,I}*
    };
    
    Console.WriteLine("Hello World");
    
    
    for (int i = 0; i < 3; i++) {
        
        switch(i){
        case 0:
        
        for (int j = 0; j < 3; j++) {
       
       a = matrizA[i,j]*matrizB[j,i]; 
       acumuladorA +=a;
       
        }
        for (int j = 0; j < 3; j++) {
            
       b = matrizA[i,j]*matrizB[j,1]; 
       acumuladorB +=b;
       
        }
        for (int j = 0; j < 3; j++) {
            
       c = matrizA[i,j]*matrizB[j,2]; 
       acumuladorC +=c;
       
        }
        break;
        
        case 1:
        
         for (int j = 0; j < 3; j++) {
       
       d = matrizA[i,j]*matrizB[j,0]; 
       acumuladorD +=d;
       
        }
        for (int j = 0; j < 3; j++) {
            
       e = matrizA[i,j]*matrizB[j,1]; 
       acumuladorE +=e;
       
        }
        for (int j = 0; j < 3; j++) {
            
       f = matrizA[i,j]*matrizB[j,2]; 
       acumuladorF +=f;
       
        }
        
        break;
        
        case 2:
        
            for (int j = 0; j < 3; j++) {
       
       g = matrizA[i,j]*matrizB[j,0]; 
       acumuladorG +=g;
       
        }
        for (int j = 0; j < 3; j++) {
            
       h = matrizA[i,j]*matrizB[j,1]; 
       acumuladorH +=h;
       
        }
        for (int j = 0; j < 3; j++) {
            
       I = matrizA[i,j]*matrizB[j,2]; 
       acumuladorI +=I;
       
        }
        
        
        break;

        }
  }
  
    matrizResultado[0,0]=acumuladorA;
    matrizResultado[0,1]=acumuladorB;
    matrizResultado[0,2]=acumuladorC;
    matrizResultado[1,0]=acumuladorD;
    matrizResultado[1,1]=acumuladorE;
    matrizResultado[1,2]=acumuladorF;
    matrizResultado[2,0]=acumuladorG;
    matrizResultado[2,1]=acumuladorH;
    matrizResultado[2,2]=acumuladorI;

        
       Console.WriteLine(acumuladorA+ " " +acumuladorB+ " " +acumuladorC);

       Console.WriteLine(acumuladorD+ " " +acumuladorE+ " " +acumuladorF);
 
       Console.WriteLine(acumuladorG+ " " +acumuladorH+ " " +acumuladorI);
            
    
 }}