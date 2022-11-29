using System;

namespace EjemploSergio {
    class ejemploarray {
        static void Main(string[] args) {

            int[] listaNumeros = CopiaArrayStringAInt();
            int numero = PideNumeroABuscarAlUsuario();
            int[] longitud = CrearArrayDePosiciones(listaNumeros, numero);

            //Muestro el resultado:
            MostrarArray(listaNumeros, numero);


        }

        static string[] CreaArray() {
            //El usuario inserta un array de numeros a traves del teclado, con numeros separados por comas
            Console.WriteLine("Introduce una serie de numeros, separalos por comas");
            string numerosArray = Console.ReadLine();
            //separo los numeros
            string[] numerosSeparados = numerosArray.Split(",");
            return numerosSeparados;
        }

        static int[] CopiaArrayStringAInt() {
            string[] lista = CreaArray();
            //creo un array de enteros
            int[] listaNumeros = new int[lista.Length];
            int numeroEntero = 0;
            //paso los chars del string[] a int
            for (int i = 0; i < listaNumeros.Length; ++i) {
                numeroEntero = int.Parse(lista[i]);
                listaNumeros[i] += numeroEntero;
            }
            return listaNumeros;
        }
        static int PideNumeroABuscarAlUsuario() {

            int numero;
            bool valorCorrecto;
            do {
                Console.WriteLine("Introduce el numero que deseas buscar:");
                valorCorrecto = int.TryParse(Console.ReadLine(), out numero);
            } while (!valorCorrecto);
            return numero;
        }

        static int[] CrearArrayDePosiciones(int[] listaNumeros, int numero) {
            int posicion = 0;
            int contadorPosiciones = 0;
            int[] resultados = new int[listaNumeros.Length];
            for (int i = 0; i < listaNumeros.Length; ++i) {
                if (listaNumeros[i] == numero) {
                    posicion = i;
                    resultados[posicion] = i;
                    ++contadorPosiciones;
                }
            }

            resultados = LimpiarArray(resultados, posicion);
            return resultados;
        }

        static int[] LimpiarArray(int[] lista, int longitud) {
            int [] listaLimpia = new int[longitud];
            for (int i = 0; i < longitud; ++i) {
                listaLimpia[i] = lista[i];
            }
            return listaLimpia; 
        }
         static void MostrarArray(int[] listaNumeros, int numero) {
            int[] resultado = CrearArrayDePosiciones(listaNumeros, numero);
            for(int i = 0; i < resultado.Length; ++i) {
                Console.Write($"{resultado[i]}");
                if (i < listaNumeros.Length) {
                    Console.Write(",");
                }
            }
            
        }
    }
}
