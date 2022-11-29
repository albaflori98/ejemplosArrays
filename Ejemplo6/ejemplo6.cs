using System;

namespace Ejemplo6 {
    class ejemplo6 {
        static void Main(string[] args) {
            //Escribir un programa que pida un número entero positivo. A continuación, pedirá tantos
            // números enteros como el número introducido y los almacenará en un array. Por último, los
            //escribirá al revés de como fueron introducidos.

            //Pedimos la longitud n
            int longitud = PedirLongitudAlUsuario();

            //Generamos la lista de numeros
            int[] listaNumeros = GuardaNumerosEnElArray(longitud);
            //Mostramos los numeros al reves
            ImprimeArray(listaNumeros);


        }

        static int PedirLongitudAlUsuario() {
            int numero;
            bool valorCorrecto;
            do {

                Console.WriteLine("Introduce un numero mayor que cero");
                valorCorrecto = int.TryParse(Console.ReadLine(), out numero);
                return numero;
            } while (!valorCorrecto);
          }
        static int PedirNumeroAlUsuario() {
            int numero;
            bool valorCorrecto;
            do {

                Console.WriteLine("Introduce un numero");
                valorCorrecto = int.TryParse(Console.ReadLine(), out numero) && numero > 0;
            } while (!valorCorrecto);
            return numero;
        }

        static int[] GuardaNumerosEnElArray(int numero) {
            int[] listaNumeros = new int[numero];
            //Pedimos n numeros y las guardamos en un array
            for (int i = 0; i < listaNumeros.Length; ++i) {
                listaNumeros[i] = PedirNumeroAlUsuario();
            }
            return listaNumeros;
        }

        static void ImprimeArray(int[] lista) {

            for (int i = lista.Length - 1; i >= 0; --i) {
                Console.Write(lista[i]);
                if (i > 0) {
                    Console.Write(",");
                }
            }
        }

    }
}
