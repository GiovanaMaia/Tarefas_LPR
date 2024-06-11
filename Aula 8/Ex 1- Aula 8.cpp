#include <iostream>
using namespace std;

int main()
{
    int numeros[10];
    int pares[10];
    int impares[10];
    int contPar=0, contImpar=0;
  
    cout<<"Digite 10 números inteiros: " << endl;
    
    for (int cont=0 ; cont<10 ; cont++ ){
       cout<< "Número " << cont+1 << ": " << endl;
       cin>> numeros[cont];
       
       if(numeros[cont]%2 == 0){
           pares[contPar++] = numeros[cont]; 
       }
        else {
           impares[contImpar++] = numeros[cont]; 
       }
    }
    
        cout<< "PAR: ";
        for (int i = 0 ; i<contPar; i++ )
        { 
            cout<< pares[i]<< " ";
        }
        cout << endl;
        
        cout<< "ÍMPAR: ";
         for (int i = 0 ; i<contImpar; i++ )
        { 
            cout<< impares[i]<< " ";
        }

    return 0;
}
