//exercicio 1 aula 7
#include <iostream>
using namespace std;

int funcao_reverso(int num){
        int digito;  
        int reverso=0;
        
      while (num>0){
        
       digito = num%10; 
       reverso = reverso * 10 + digito;
       num = num/10;
       
      }
      return reverso;
} 

int main()
{
    int x, resul;
    cout << "Digite um número" << endl;
    cin >> x;
    
    resul = funcao_reverso(x);
     
    cout << "Reverso = " << resul << endl; 
        

        
    return 0;
}