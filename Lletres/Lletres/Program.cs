using System;
using System.Collections.Generic;

namespace Lletres
{
    class Program
    {
        static void Main(string[] args)
        {
            //Fase 1
            char[] nom = {'M','i','g','u','e','l',' ','Á','n','g','e','l'};
            for (int i = 0; i < nom.Length; i++)
            {
                Console.WriteLine(nom[i]);
            }

            //Fase 2
            List<char> nomList = new List<char>{ 'M', 'i', 'g', 'u', 'e', 'l', ' ', 'A', 'n', 'g', 'e', 'l' };
            for (int i = 0; i < nomList.Count; i++)
            {
                switch (nomList[i])
                {
                    case 'a':
                    case 'e':
                    case 'i':
                    case 'o':
                    case 'u':
                    case 'A':
                    case 'E':
                    case 'I':
                    case 'O':
                    case 'U':
                        Console.WriteLine(nomList[i] + " Vocal");
                        break;
                    case '1':
                    case '2':
                    case '3':
                    case '4':
                    case '5':
                    case '6':
                    case '7':
                    case '8':
                    case '9':
                    case '0':
                        Console.WriteLine(nomList[i] + " Los nombres de personas no tienen números");
                        break;
                    default:
                        Console.WriteLine(nomList[i] + " Consonant");
                        break;
                }
            }

            //Fase 3
            Dictionary<char, int> diccionario=new Dictionary<char, int>();
            char lletra;
            int contador;
            contador = 0;

            for (int i = 0; i < nomList.Count; i++) //Recorremos toda la lista
            {
                lletra = nomList[i];
                for (int j = 0; j < nomList.Count; j++) //Contamos las repeticiones
                {
                    if (lletra == nomList[j])
                        contador++;
                }


                if (!diccionario.ContainsKey(lletra)) //Comprobamos que la clave no está repetida
                {                
                    diccionario.Add(lletra, contador);
                    Console.WriteLine(lletra + " " + diccionario[lletra]);
                }

                contador = 0;

            }

            //Fase 4
            List<char> cognomList = new List<char> { 'B', 'a', 'r', 'c', 'l', 'ó'};
            List<char> fullNom = new List<char>();
            fullNom = nomList;
            fullNom.Add(' ');
            foreach (var value in cognomList)
            {
                nomList.Add(value);
            }

            /*********************************
             * Comprobació de la llista nova *
             *********************************/
            Console.WriteLine(" ");
            foreach (var value in fullNom)
            {
                Console.WriteLine(value);
            }
        }
    }
}
