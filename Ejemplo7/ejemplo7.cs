using System;

namespace Ejemplo7 {
    class ejemplo7 {
        static void Main(string[] args) {
            //Escribir un programa que reciba una ristra de números separados por comas(ignorando
            //aquellos que no son números) y escriba sus cuadrados, también separados por comas.

            Console.WriteLine("Introduce una lista de numeros separados por comas");
            string numerosPorTeclado = Console.ReadLine();

            string[] ristraNumeros = numerosPorTeclado.Split(',');
            for(int i = 0; i < ristraNumeros.Length; ++i) {
                int numero;
                bool numeroValido = int.TryParse(ristraNumeros[i], out numero);
                if (numeroValido) {
                    Console.Write($"{numero * numero} ");
                }
            }

        }
    }
}
