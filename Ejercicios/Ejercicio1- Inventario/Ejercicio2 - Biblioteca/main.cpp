#include <iostream>
#include <algorithm>
#include <time.h>

using namespace std;

string libros[20][4];


void cargarLibros() {
    // Arreglo con categoria y descripcion
	libros[0][0] = "Algoritmos"; libros[0][1] = "Algoritmos y Programacion (Guia para docentes)"                                                    ;libros[0][2] = "El buki iglesias"    ;libros[0][3] = "Kaka Ezpinoza";
	libros[1][0] = "Algoritmos"; libros[1][1] = "Apuntes de Algoritmos y Estructuras de Datos"                                                      ;libros[1][2] = "Jorge Navarro"       ;libros[1][3] = "Dr.Mundo";
	libros[2][0] = "Algoritmos"; libros[2][1] = "Breves Notas sobre Analisis de Algoritmos"                                                         ;libros[2][2] = "Ramom Ezpinoza"       ;libros[2][3] = "Josue Ezpinoza";
	libros[3][0] = "Algoritmos"; libros[3][1] = "Fundamentos de Informatica y Programacion"                                                         ;libros[3][2] = "Andres Alvarez"      ;libros[3][3] = "Kevo Kevo";
	libros[4][0] = "Algoritmos"; libros[4][1] = "Temas selectos de estructuras de datos"                                                            ;libros[4][2] = "Issac xevar"         ;libros[4][3] = "Kaka Ezpinoza";
	libros[5][0] = "Algoritmos"; libros[5][1] = "Teoria sintactico-gramatical de objetos"                                                           ;libros[5][2] = "Hernan Quiroja"      ;libros[5][3] = "Dr.Mundo";
	libros[6][0] = "Base de Datos"; libros[6][1] = "Apuntes de Base de Datos 1"                                                                     ;libros[6][2] = "Erick Hakon"         ;libros[6][3] = "Jorge Navarro";
	libros[7][0] = "Base de Datos"; libros[7][1] = "Base de Datos (2005)"                                                                           ;libros[7][2] = "Hernan Quiroja"      ;libros[7][3] = "Kevo Kevo";
	libros[8][0] = "Base de Datos"; libros[8][1] = "Base de Datos (2011)"                                                                           ;libros[8][2] = "Erick Hakon"         ;libros[8][3] = "Dr.Mundo";
	libros[9][0] = "Base de Datos"; libros[9][1] = "Base de Datos Avanzadas (2013)"                                                                 ;libros[9][2] = "Nixaster jijo"       ;libros[9][3] = "Kaka Ezpinoza";
	libros[10][0] = "Base de Datos"; libros[10][1] = "Diseno Conceptual de Bases de Datos"                                                          ;libros[10][2] = "Kevo Kevo"          ;libros[10][3] = "Issac Newton";
	libros[11][0] = "Ciencia Computacional"; libros[11][1] = "Breves Notas sobre Automatas y Lenguajes"                                             ;libros[11][2] = "Issac Newton"       ;libros[11][3] = "Jorge Navarro";
	libros[12][0] = "Ciencia Computacional"; libros[12][1] = "Breves Notas sobre Teoria de la Computacion"                                          ;libros[12][2] = "Jayce top"          ;libros[12][3] = "Kevo Kevo";
	libros[13][0] = "Metodologias de desarrollo de software"; libros[13][1] = "Compendio de Ingenieria del Software"                                ;libros[13][2] = "Jayce top"          ;libros[13][3] = "Issac Newton";
	libros[14][0] = "Metodologias de desarrollo de software"; libros[14][1] = "Diseno agil con TDD"                                                 ;libros[14][2] = "Dr.Mundo"           ;libros[14][3] = "Jorge Navarro";
	libros[15][0] = "Metodologias de desarrollo de software"; libros[15][1] = "Ingenieria de Software: Una Guia para Crear Sistemas de Informacion" ;libros[15][2] = "Peter Parker"       ;libros[15][3] = "Kevo Kevo";
	libros[16][0] = "Metodologias de desarrollo de software"; libros[16][1] = "Scrum & Extreme Programming (para programadores)"                    ;libros[16][2] = "Robin Hood"         ;libros[16][3] = "Jayce top";
	libros[17][0] = "Metodologias de desarrollo de software"; libros[17][1] = "Scrum y XP desde las trincheras"                                     ;libros[17][2] = "Graves jg"          ;libros[17][3] = "Kevo Kevo";
	libros[18][0] = "Miscelaneos"; libros[18][1] = "97 cosas que todo programador deberia saber"                                                    ;libros[18][2] = "Dr.Mundo"           ;libros[18][3] = "Jorge Navarro";
	libros[19][0] = "Miscelaneos"; libros[19][1] = "Docker"                                                                                         ;libros[19][2] = "Jayce top"          ;libros[19][3] = "Andres Alvarez";

}



int main(int argc, char const *argv[])
{
    cargarLibros();
    
    int t_bus=0;
    
    	cout << "Ingrese 1 si quiere buscar por autor "<<endl;
    	cout << "Ingrese 2 si quiere buscar por libros "<<endl;
        cin >> t_bus;
    
    	if (t_bus==1){
    	
    srand (time(NULL));
    
    bool salir = false;

    while (salir == false)
    {
        string buscar = "";
        system("cls");
        cout << "Ingrese el nombre del autor que buscas: ";
        cin >> buscar;

        // busqueda
        for (int i = 0; i < 20; i++)
        {
            string libro = libros[i][2];
            string libroEnminuscula = libro;
            // transformamos a minuscula los string buscar y libro
            transform(libroEnminuscula.begin(), libroEnminuscula.end(), libroEnminuscula.begin(), ::tolower);
            transform(buscar.begin(), buscar.end(), buscar.begin(), ::tolower);

            if (libroEnminuscula.find(buscar) != string::npos) {
                cout << "autor encontrado: " << libro << endl;

                cout << "Tambien te sugerimos estos autores: " << endl;

                int sugerencia1 = rand() % 19 + 1;
                int sugerencia2 = rand() % 19 + 1;
                int sugerencia3 = rand() % 19 + 1;

                cout << " Sugerencia 1: " << libros[sugerencia1][2] << endl;
                cout << " Sugerencia 2: " << libros[sugerencia2][2] << endl;
                cout << " Sugerencia 3: " << libros[sugerencia3][2] << endl;

                salir = true;
                break;
            }
        }
        

        if (salir == false) {
            char continuar = 'n';

            while(true) {
                system("cls");
                cout << "No se encontro el autor que busca. Desea continuar? s/n ";
                cin >> continuar;

                if (continuar == 's' || continuar == 'S') {
                    break;
                } else if (continuar == 'n' || continuar == 'N') {
                    salir = true;
                    break;
                }
            }
        }
    }
}

	else if (t_bus==2){
	
    srand (time(NULL));
    
    bool salir = false;

    while (salir == false)
    {
        string buscar = "";
        system("cls");
        cout << "Ingrese la descripcion del libro que busca: ";
        cin >> buscar;

        // busqueda
        for (int i = 0; i < 20; i++)
        {
            string libro = libros[i][1];
            string libroEnminuscula = libro;
            // transformamos a minuscula los string buscar y libro
            transform(libroEnminuscula.begin(), libroEnminuscula.end(), libroEnminuscula.begin(), ::tolower);
            transform(buscar.begin(), buscar.end(), buscar.begin(), ::tolower);

            if (libroEnminuscula.find(buscar) != string::npos) {
                cout << "Libro encontrado: " << libro << endl;

                cout << "Tambien te sugerimos estos libros: " << endl;

                int sugerencia1 = rand() % 19 + 1;
                int sugerencia2 = rand() % 19 + 1;
                int sugerencia3 = rand() % 19 + 1;

                cout << " Sugerencia 1: " << libros[sugerencia1][1] << endl;
                cout << " Sugerencia 2: " << libros[sugerencia2][1] << endl;
                cout << " Sugerencia 3: " << libros[sugerencia3][1] << endl;

                salir = true;
                break;
            }
        }
        

        if (salir == false) {
            char continuar = 'n';

            while(true) {
                system("cls");
                cout << "No se encontro el libro que busca. Desea continuar? s/n ";
                cin >> continuar;

                if (continuar == 's' || continuar == 'S') {
                    break;
                } else if (continuar == 'n' || continuar == 'N') {
                    salir = true;
                    break;
                }
            }
        }
    }
    
}
    return 0;
}
