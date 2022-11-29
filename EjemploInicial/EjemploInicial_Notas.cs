using System;

namespace EjemploInicial {
    class EjemploInicial_Notas {
        static void Main(string[] args) {
            //EJEMPLO INICIAL:

            int[] notas;
            //pedimos notas al usuario
            Console.WriteLine("Introduce el numero de notas que quieres saber");
            int longitud = Convert.ToInt32(Console.ReadLine());
            //inicializamos el array
            notas = new int[longitud];

            //Rellenamos el array con numeros aleatorios
            Random generador = new Random();
            for (int i = 0; i < notas.Length; ++i) {

                notas[i] = generador.Next(0,11);
            }

            Console.WriteLine("Tus notas son:");
            //Escribimos por pantalla el contenido del array
            for(int i = 0; i< notas.Length; ++i) {
                Console.WriteLine(notas[i]);
            }                                                                                            

            //Muestro la media de las notas
            Console.WriteLine("Tu nota media es:");
            Console.WriteLine(CalcularMedia(notas));

            //Muestro el numero de veces un determinado valor
            Console.WriteLine("El numero de 10 que has sacado es:");
            Console.WriteLine(CalcularRepeticiones(notas, 10));
        }

        static float CalcularMedia(int[] lista) {
            float media = 0;
            for(int i = 0; i < lista.Length; ++i) {

                media += lista[i];
            }
            media /= lista.Length;
            return media;

        }

        static int CalcularRepeticiones(int [] lista, int valor) {
            int contador = 0;
            for(int i = 0; i < lista.Length; ++i) {
                if(lista[i] == valor) {
                    ++contador;
                }
            }
            return contador; 
        }
    } 
}
