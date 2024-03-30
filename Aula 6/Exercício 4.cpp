//exercicio4
#include <iostream>
using namespace std;

int main()
{
    int num, digito;
    int soma=0;
    int quadrado;
    
    cout<< "Digite um número"<< endl;
    cin >> num ;
    quadrado = num*num;
    
    while(quadrado > 0)  
    {
       digito = quadrado%10; //15129= 9
       soma = soma + digito; //0+9
       quadrado = quadrado/10; //1512
        
    }
    
    cout<< "A soma dos números é do quadrado é "<< soma <<endl;
    

    return 0;
}