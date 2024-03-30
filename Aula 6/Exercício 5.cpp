//exercicio 5
#include <iostream>
using namespace std;

int main()
{
    int contador=0;
    float horas, total_horas=0, dias, semanas, meses;
    

    cout<<"Digite o número de horas de treinamento por dia:"<< endl;
    cin>>horas;
    
    
    while (contador<5)
    {
     total_horas+= horas;
     contador++;
    }
    
    dias = 1000/horas;
    semanas = dias/5;
    meses = semanas/4.5;
    
    cout << "Em uma semana ele trabalha "<< total_horas << " horas" <<endl;
    cout << "Para alcançar o total de 1000 horas de treinamento ele precisa treinar:" <<endl;
    cout << dias << " dias" <<endl;
    cout << semanas << " semanas" <<endl;
    cout << meses << " meses" <<endl;



    return 0;
}