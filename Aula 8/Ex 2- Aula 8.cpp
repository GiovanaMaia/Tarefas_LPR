#include <iostream>
using namespace std;

int main(){
    
    int leitura[10];
    int posicao[10];
    int num = 0, qntd=0, indice=0, numPosicao=0;
    
    cout<< "Digite 10 números inteiros: "<< endl;
    
    for(int i=0; i<10; i++){
        cout<<"Número "<< i << " :";
        cin>>leitura[i];
    }
    cout<< "Digite um número que você quer pesquisar no vetor"<< endl;
    cin>>num;

    for(int cont=0 ; cont<10 ; cont ++){
        if (num == leitura [cont]){
            
            posicao[indice++] = cont;
            qntd++;
        }
        
    }
        
        if(qntd>1){
            
            cout<<" Ele está na posição: ";
        for (int i=0; i<indice ; i++){
            cout<<posicao[i]<< " ";
        }
        cout<< endl;
                cout<<"Ele aparece "<< qntd <<" vezes.";
            }
            else if(qntd<=1){
                cout<<" Ele está na posição: ";
                for (int i=0; i<indice ; i++){
            cout<<posicao[i]<< " ";
        }
        cout<< endl;
            cout<<" Ele aparece "<< qntd << " vez.";
            }
             else {
             cout<< "Número não encontrado!";
             return 0;
         }   
       
        
     
    
    return 0;
}