using System;
using System.Threading;

namespace Ejemplo10 {
    class ejemplo10 {
        static void Main(string[] args) {
            //Escribir un programa que reciba un texto y lo reescriba carácter a carácter, con una pequeña
            //pausa(50 milisegundos, por ejemplo) entre un carácter y el siguiente.
            Console.WriteLine("Introduce un texto");
            string texto = Console.ReadLine();

            for(int i = 0; i < texto.Length; ++i) {
                Console.Write(texto[i]);
                //creamos la pausa
                Thread.Sleep(50);
            }

        }
    }
}
