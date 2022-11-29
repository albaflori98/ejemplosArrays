using System;

namespace Ejemplo14 {
    class Ejemplo14 {
        static void Main(string[] args) {
            //Escribir un programa que reciba un texto y escriba el número de aes, es, íes, oes y úes que
            //tiene(incluyendo mayúsculas, y con tilde), con el siguiente formato:
            Console.WriteLine("Introduce un texto");
            string texto = Console.ReadLine();

            texto.ToLower();
            ImprimeArray(texto);

        }
        static int[] CuentaLasVocales(string texto) {
            int[] vocales = { 0, 0, 0, 0, 0 };

            for (int i = 0; i < texto.Length; ++i) {
                if (texto[i] == 'a' || texto[i] == 'á') {
                    ++vocales[0];
                }
                if (texto[i] == 'e' || texto[i] == 'é') {
                    ++vocales[1];
                }
                if (texto[i] == 'i' || texto[i] == 'í') {
                    ++vocales[2];
                }
                if (texto[i] == 'o' || texto[i] == 'ó') {
                    ++vocales[3];
                }
                if (texto[i] == 'u' || texto[i] == 'ú') {
                    ++vocales[4];
                }
            }
            return vocales;
        }


        static void ImprimeArray(string texto) {
            int[] vocales = CuentaLasVocales(texto);
            Console.WriteLine($"a: {vocales[0]} \ne: {vocales[1]} \ni: {vocales[2]} \no: {vocales[3]} \nu: {vocales[4]} ");

        }
    }
}
