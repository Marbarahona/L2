#include <iostream>
#include "startShip.h"
#include "snake.h"

using namespace std;

int main(int argc, char const *argv[])
{
    
    int juego =0;
    while (true){
            system ("cls");
            cout << "*****************" << endl;
            cout << "  MENU DE JUEGOS " << endl;
            cout << "*****************" << endl;
            cout << endl;

            cout << "Seleccione un Juego: " << endl;
            cout << "1 - StarShip" << endl;
            cout << "2 - Snake" << endl;

            cout << endl;
            cout << "Ingrese un numero del menu para seleccionar un juego" <<endl;
            cin >> juego;

            switch(juego)
            {
                case 1:
                    system ("cls");
                    starShip();
                    break;
                case 2:
                    system ("cls");
                    snake();
                    break;
            }
    }
        system("cls");

    return 0;
}
