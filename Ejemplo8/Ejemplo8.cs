using System;

namespace Ejemplo8 {
    class Ejemplo8 {
        static void Main(string[] args) {
            Console.WriteLine("Escribe un nombre");
            string nombre = Console.ReadLine();
            string nombreminuscula = nombre.ToLower();

            if(EsVocal(nombre)) {

                Console.WriteLine($"El nombre {nombre} empieza por vocal");
            }
            else { 
                Console.WriteLine($"El nombre {nombre} empieza por consonante");
            }
        }

        static bool EsVocal(string lista) {
            bool esVocal = false;
            if(lista[0] == 'a'
               || lista[0] == 'e'
               || lista[0] == 'i'
               ||lista[0] == 'o'
               || lista[0] == 'u'
               || lista[0] == 'á'
               || lista[0] == 'é'
               || lista[0] == 'í'
               || lista[0] == 'ó'
               || lista[0] == 'ú') {

                esVocal = true;
            }
            return esVocal;
        }
    }
}
