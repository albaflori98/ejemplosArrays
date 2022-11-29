using System;

namespace Ejemplo15 {
    class ejemplo15 {
        static void Main(string[] args) {
            //Escribir un programa que reciba un texto, cambie las aes por '4', las es por '3', las íes por '1'y
            //las oes por '0' y escriba el resultado.


            Console.WriteLine("Introduce un texto.");
            string texto = Console.ReadLine();
            texto.ToLower();

            string textoModificado = "";
            for(int i = 0; i < texto.Length; ++i) {
                if(texto[i] == 'a') {
                    textoModificado += "4";
                }
                else if (texto[i] == 'e') {
                    textoModificado += "3";
                }
                else if (texto[i] == 'i') {
                    textoModificado += "1";
                }
                else if (texto[i] == 'o') {
                    textoModificado += "0";
                }
                else {
                    textoModificado += texto; 
                }
            }

            Console.WriteLine(textoModificado);

        }
    }
}
