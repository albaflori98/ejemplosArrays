using System;

namespace Ejemplo19 {
    class ejemplo19 {
        static void Main(string[] args) {
            //El método de la burbuja es un método de ordenación muy simple, aunque muy ineficiente.
            //Consiste(para ordenar de menor a mayor) en recorrer todo el array en orden, comparando
            //cada elemento con el siguiente. Si el siguiente es menor, entonces los intercambia.El
            //método ha terminado cuando no hace una pasada sin hacer ningún cambio.
            //Escribir un programa que reciba una lista de números separados por comas(ignorando los
            //que no son números), lo ordene por el método de la burbuja y los vuelva a escribir, ya
            //ordenados, y separados también por comas.

            int[] listaNumeros = { 3, 1, 8, 5, 4, 9 };

            int[] listaNumerosOrdenada = OrdenaElArray(listaNumeros);
            for(int i = 0; i < listaNumerosOrdenada.Length; ++i) {

                Console.Write($"{listaNumerosOrdenada[i]} ");
            }

            
        }

        static int[] OrdenaElArray(int[] lista) {
            bool seHaHechoAlgunCambio;
            do {
                seHaHechoAlgunCambio = false;
                for (int i = 0; i < lista.Length - 1; ++i) {
                    if (lista[i] > lista[i+1]) {
                        int aux = lista[i];
                        lista[i] = lista[i + 1];
                        lista[i + 1] = aux;
                        seHaHechoAlgunCambio = true;
                    }
                }

            } while (seHaHechoAlgunCambio);
            
            return lista;
        }
    }
}
