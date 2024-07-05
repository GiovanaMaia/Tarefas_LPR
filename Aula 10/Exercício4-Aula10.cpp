//ex4
#include <map>
#include <iostream>
using namespace std; 

int main()
{
    int qntd, populacao, soma, media;
    string nome;
    int maior_populacao, menor_populacao;
    string cidade_maiorPop, cidade_menorPop;
    int excluirCid;
    
    map<string, int> cidade_Populacao ;
    
    cout<< "Digite quantas cidades serão inseridas: " << endl ;
    cin>>qntd;
    
    for(int i=0; i<qntd ; i++ ){
        
        cout<<"Digite o nome da cidade: "<< endl;
        cin>> nome;
        cout<<"Digite o total da população: "<< endl;
        cin>>populacao;
        
        cidade_Populacao.insert({ nome, populacao });

    }
    
    
    
     for (auto cidade : cidade_Populacao)
{
        soma+=cidade.second;
}

    media = soma/qntd;   
    
    cout<<"Cidades com populção acima da média: "<<endl;
    
    for (auto cidade : cidade_Populacao) {
        if (cidade.second > media) {
           cout<<"Cidade: "<< cidade.first << ", população: "<<cidade.second<<endl; 
        }
    }
    
    for (auto cidade : cidade_Populacao) {
        if (cidade.second > maior_populacao) {
            maior_populacao = cidade.second;
            cidade_maiorPop = cidade.first;
        }
    }  
    for (auto cidade : cidade_Populacao) {
        if (cidade.second < maior_populacao) {
            menor_populacao = cidade.second;
            cidade_menorPop = cidade.first;
        }
    }
     cout<<"Cidade mais populosa: "<< cidade_maiorPop<< endl;  
     cout<<"Cidade menos populosa: "<< cidade_menorPop<< endl;   
     
     cout<<"Cidades com qual população será excluida?"<< endl;
     cin>>excluirCid;
     
      for (auto it = cidade_Populacao.begin(); it != cidade_Populacao.end(); )
    {
        if (it->second == excluirCid)
        {
            it = cidade_Populacao.erase(it); 
        }
        else
        {
            ++it;
        }
    }
    
    for (auto cidade : cidade_Populacao) {
        
        cout<<"Cidade: "<< cidade.first << ", população: "<<cidade.second<<endl; 
        }
     

    return 0;
}













