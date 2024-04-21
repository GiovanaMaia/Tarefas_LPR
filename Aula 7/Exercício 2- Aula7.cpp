//exercicio2
#include <iostream>
using namespace std;

void funcaoEX1(int quantidade){   
    
    int soma = 0;
    int contador = 0;


    while (quantidade > 0) {
        int numero;
        cout << "Digite um número: ";
        cin >> numero;

        if (numero % 2 == 0) {
            soma += numero;
            contador++;
        }

        quantidade--;
    }

    if (contador > 0) {
        double media = static_cast<double>(soma) / contador;
        cout << "A média dos números pares é: " << media << endl;
    } 
    else {
        cout << "Nenhum número par foi digitado." << endl;
    }

    
}    
    
int funcaoEX3(){

    int soma=0;

    
    for (int i = 50; i <= 500; i++)  
    {
        if(i%2!=0 && i%3==0)
        {
            soma = soma+i;
        }
        
    }
    cout << "Soma = " << soma << endl;
    return 0;
    
}  


    
 void funcaoEX4(int num){
    int digito;
    int soma=0;
    int quadrado;
    
    quadrado = num*num;
    
    while(quadrado > 0)  
    {
       digito = quadrado%10; //15129= 9
       soma = soma + digito; //0+9
       quadrado = quadrado/10; //1512
        
    }
    
    cout<< "A soma dos números é do quadrado é "<< soma <<endl;
 }

int main()
{
    int escolha;
    cout<< "Menu de opções:"<< endl;
    cout<< "1. EX 1-Calcular a média aritmética de um conjunto de números "<< endl;
    cout<< "2.EX 3-Somar todos os números ímpares múltiplos de 3 que se encontrem no conjunto dos números de 50 a 500"<< endl;
    cout<< "3. EX 4-Inserir um número e calcular a soma dos dígitos do quadrado desse número."<< endl;
    cin >> escolha ;
    
    switch (escolha) {
        case 1:
        int quantidade;
        cout << "Digite a quantidade de números a serem inseridos: ";
        cin >> quantidade;
        funcaoEX1(quantidade);
        break;
        
        case 2:
         funcaoEX3();
        break;
        
        case 3:
        int numero;
        cout<< "Digite um número"<< endl;
        cin >> numero;
        funcaoEX4(numero);
        break;
        
        default:
        cout << "Opção inválida";
        break;
        
    }

    
    
    return 0;
}