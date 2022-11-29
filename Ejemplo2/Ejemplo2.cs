using System;

namespace Ejemplo2 {
    class Ejemplo2 {
        static void Main(string[] args) {
            //Recibe un array de enteros y devuelve el elemento mayor

            int[] lista = { 7, -15, 8, 9, 4, 6 };
            Console.WriteLine("El elemento mayor de la lista es:");
            Console.WriteLine(CalculaElementoMayor(lista));
        }

        static int CalculaElementoMayor(int[] lista) {
           //Iniciamos el mayor al numero mas pequeño posible
            int numeroMayor = lista[0];

            for (int i = 0; i < lista.Length; ++i) {
               if(numeroMayor < lista[i]) {
                    numeroMayor = lista[i];
                }
            }
            return numeroMayor;
        }
    }
}
