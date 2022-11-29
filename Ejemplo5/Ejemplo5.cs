using System;

namespace Ejemplo5 {
    class Ejemplo5 {
        static void Main(string[] args) {
            //Escribir un programa que genere una combinación aleatoria de la lotería primitiva: 6 números entre 1 y 48, que no se pueden repetir.
            int[] loteria = GenerarCombinacionPrimitiva();
            ImprimirArray(loteria);

        }
        static int[] GenerarCombinacionPrimitiva() {
            int[] combinacion = new int[6];
            Random generador = new Random();
            
            for (int i = 0; i < combinacion.Length; ++i) {
                
                combinacion[i] = GenerarNumeroNoRepetido(combinacion, i);
                
            }
            return combinacion;

        }

        static int GenerarNumeroNoRepetido(int[] lista, int posicionActual) {
            int numeroAleatorio;

            //mientras que el numero sea igual, hay que repetir la operacion
            do {
                Random generador = new Random();
                numeroAleatorio = generador.Next(1, 49);

            } while (NumeroRepetidoEnLista(lista, numeroAleatorio, posicionActual));
            return numeroAleatorio;
        }

        static bool NumeroRepetidoEnLista(int[] lista, int numero, int posicionActual) {
           bool repetido = false;
            for (int j = 0; j < posicionActual && !repetido; ++j) {
                if (numero ==lista[j]) {
                    repetido = true;
                }
            }
            return repetido;
        }



        static void ImprimirArray(int[] lista) {
            for(int i = 0; i < lista.Length; ++i) {
                Console.Write(lista[i]);
                if(i < lista.Length - 1) {
                    Console.Write(",");
                }
            }
        }
    }
}
