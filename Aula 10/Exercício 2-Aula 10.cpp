//ex 2

#include <iostream>
#include <list>
#include <unordered_map>
using namespace std;

int main()
    
{
    list<int> numeros;
    for (int i=0; i<100 ; i++){
        
        numeros.push_back( rand()%100);

    }
    
    numeros.sort();
    cout << "Lista de números" << endl;
    for (int numero : numeros) {
    cout << numero << endl;
    
    }

     cout << "Lista de números em crescente" << endl; 
     
     for (auto it = numeros.begin(); it != numeros.end();){
         
      if (*it%2==0) // *  acesso o valor de it
      {
        it =  numeros.erase(it);
      }
     else{
         ++it;
     }
     }

     cout << "Números ímpares: "<<endl;
     for (int impares: numeros) {
 
    cout <<  impares << endl;
    }
    
    unordered_map<int, int> contagem;
    for (int num : numeros) {
        contagem[num]++;
    }
    
    
    bool num_Repetido = false;
    cout << "Números que se repetem na lista:" << endl;
    for (auto& par : contagem) {
        
        if (par.second > 1) {
            cout << par.first << endl;
            num_Repetido = true;
        }
    }

    if (!num_Repetido) {
        cout << "Não foi encontrado nenhum número repetido." << endl;
    }
    
    
    

    return 0;
}