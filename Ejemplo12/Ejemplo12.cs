using System;

namespace Ejemplo12 {
    class Ejemplo12 {
        static void Main(string[] args) {
            //Escribir un programa que reciba un texto y devuelva el número de aes minúsculas que tiene
            //antes de la primera t minúscula.
            Console.WriteLine("Introduce un texto:");
            string texto = Console.ReadLine();
            int contador = 0;
            bool tEncontrada = false;
            for(int i = 0; i < texto.Length && !tEncontrada; ++i) {
                    if (texto[i] == 'a') {
                        ++contador;
                    }
                    else if(texto[i] == 't') {
                    tEncontrada = true; 
                    }
            }
            Console.WriteLine($"El numero de aes antes de la t es {contador}");
        }
    }
}
