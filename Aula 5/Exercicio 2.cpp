#include <iostream>
using namespace std;

int main()
{
    int num1, num2;
    
    cout<<"Digite dois números inteiro"<< endl;
    cin >> num1;
    cin >> num2;
    
    
    if ( num1%num2==0 || num2%num1==0){
        
        cout<<"Os números " << num1 << " e " << num2<< " são multiplos."<< endl;
        
    }
    else {
        
        cout<<"Os números " << num1 << " e " << num2<< " não são multiplos."<< endl;
        
    }

    return 0;
}