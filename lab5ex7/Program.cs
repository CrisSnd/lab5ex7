using System;

namespace MyApp
{
    internal class Program
    {

        static void Main(string[] args)
        {
            /*Scrieti un program care va citi doua siruri de caractere de la tastatura si va verifica daca cele doua siruri de caractere sunt anagrame.*/


            Console.WriteLine("Introduceti primul sir de caractere: ");
            string sirCaractere1 = Console.ReadLine();

            Console.WriteLine("Introduceti al doilea sir de caractere: ");
            string sirCaractere2 = Console.ReadLine();

            //Se convertesc ambele siruri in matrice de caractere;
            char[] cuvant1 = sirCaractere1.ToLower().ToCharArray();
            char[] cuvant2 = sirCaractere2.ToLower().ToCharArray();

            //Se sorteaza cele 2 matrici de caractere în ordine crescătoare/descrescătoare,cu  aceeași ordine pentru ambele matrici;
            Array.Sort(cuvant1);
            Array.Sort(cuvant2);

            //Se creaza 2 șiruri din cele două seturi de caractere sortate
            string cuvantNou1 = new string(cuvant1);
            string cuvantNou2 = new string(cuvant2);

            //Se compara cele  2 siruri de caractere.
            if (cuvantNou1 == cuvantNou2)
            {
                Console.WriteLine("Cuvintele \"{0}\" si \"{1}\" sunt anagrame.", sirCaractere1, sirCaractere2);
            }
            else
            {
                Console.WriteLine("Cuvintele\"{0}\" si \"{1}\" nu sunt anagrame.", sirCaractere1, sirCaractere2);
            }
        }
    }
}
