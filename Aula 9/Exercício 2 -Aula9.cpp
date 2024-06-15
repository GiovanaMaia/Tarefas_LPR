#include <iostream>
#include<array>
using namespace std;

 struct Livro{
    string Titulo;
    string Autor;
    int AnoPublicacao;
    int NumeroPaginas;
    int Preco;
 };
 
int main()
{
    int total=0, media=0;
    
    array<Livro,3> dados;
    
    for(int i=0; i<3 ;i++){
    cout<<"Digite o título do livro: "<< endl;
    cin >> dados[i].Titulo;
    cout<<"Digite o autor do livro: "<< endl;
    cin >>dados[i].Autor ;
    cout<<"Digite o ano de publicação do livro: "<<endl;
    cin >>dados[i].AnoPublicacao;
    cout<<"Digite a numero de páginas do livro: "<<endl;
    cin >>dados[i].NumeroPaginas;
    cout<<"Digite o preço do livro: "<<endl;
    cin >>dados[i].Preco;
    
    total = dados[0].Preco + dados[1].Preco +  dados[2].Preco;
    media= (dados[0].NumeroPaginas + dados[1].NumeroPaginas +  dados[2].NumeroPaginas)/3;
    
    cout << "Preço total dos livros cadastrados: " << total << endl; 
    cout << "Media de paginas: " << media ; 

}

    return 0;
}