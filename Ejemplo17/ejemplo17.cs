using System;

namespace Ejemplo17 {
    class ejemplo17 {
        static void Main(string[] args) {
            //comienzo ejercicio 1
            //Pedir numeros hasta que el usuario introduzca 0
            //Esos numeros se guardan en el array
            //Esta funcion debe devolver el array limpio
            int[] listaNumeros = CrearArray();
            //Escribir el contenido del array
            ImprimeArray(listaNumeros);

        }
        static int PideNumeroAlUsuario() {
            int numero;
            bool valorCorrecto;
            do {
                Console.WriteLine("introduce un numero:");
                valorCorrecto = int.TryParse(Console.ReadLine(), out numero);
            } while (!valorCorrecto);
            return numero;
        }

        static int[] CrearArray() {
            int[] numerosArray = new int[1];
            int numero;
            int contador = 0;
            do {
                numero = PideNumeroAlUsuario();
                if(numero!= 0) {
                    //metemos el numero en el array
                    numerosArray = IntroducirNumeroEnArray(numero, numerosArray, contador); 
                    ++contador;
                }
            } while (numero != 0);

            //limpiamos el array
            int[] arrayLimpio = LimpiaElArray(numerosArray, contador);
            return arrayLimpio;

        }
        static int[] IntroducirNumeroEnArray(int numero, int[] lista, int posicion) {
            if(posicion >= lista.Length) {
                // Si no cabe, duplicamos el tamaño del array
                int[] duplicado = DuplicaTamañoDelArray(lista);
                lista = duplicado;
            }
            //Ahora seguro que el numero cabe, asi que lo asignamos y devolvemos el array
            lista[posicion] = numero;
            return lista;
        }

        static int[] DuplicaTamañoDelArray(int[] lista) {
            int[] duplicado= new int[lista.Length * 2];
            for (int i = 0; i < lista.Length; ++i) {
                duplicado[i] = lista[i];
            }

            return duplicado; 
        }

        static int[] LimpiaElArray(int[] lista, int longitud) {
            int[] arrayLimpio = new int[longitud];
            for (int i = 0; i < arrayLimpio.Length; ++i) {
                arrayLimpio[i] =lista[i];
            }
            return arrayLimpio;
        }

        static void ImprimeArray(int[] lista) {
            for(int i = 0; i < lista.Length; ++i) {
                Console.Write($"{lista[i]}");
                if(i < lista.Length - 1) {
                    Console.Write(", ");
                }
            }
        }

        
    }
}
