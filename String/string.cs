using System;

namespace String {
    class Program {
        static void Main(string[] args) {
            string palabra = "Hola";
             //palabra.Length();
            Console.WriteLine(palabra[2]);
            //No se puede hacer palabra[2] = 'c';

            //EJEMPLO:
            string frase = "Winter is coming";
            string[] palabras = frase.Split(' ');
            for(int i = 0; i < palabras.Length + 4; ++i) {
                Console.Write("*");
                
            }
            for (int i = 0; i < palabras.Length; ++i) {
                
                Console.WriteLine(palabras[i]);

            }
            

        }
    }
}
