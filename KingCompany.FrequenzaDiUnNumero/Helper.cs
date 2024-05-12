using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace KingCompany.FrequenzaDiUnNumero
{
    public static class Helper
    {
        public static int GetMaxFrequente(int[] vector)
        {
            var dictionary = GetDictionaryConFrequenze(vector);
            int maxFrequenza = dictionary.Max(x => x.Value); //recuperiamo il valore piu alto del dizionario
            var numeriPiuFrequente = dictionary.Where(x => x.Value == maxFrequenza).ToList().OrderBy(x => x.Key); //Ordiniamo la lista in ordine Ascendente (dal piu piccolo al piu grande)
            var numeroPiuFrequente = numeriPiuFrequente.First().Key; //Avendo una lista ordinata dal piu piccolo, basta prendere il primo elemento
            return numeroPiuFrequente;
        }

        public static int[] GetMaxFrequenti(int[] vector, int k)
        {
            if (vector.Length >= k) // Check se chiediamo piu elementi di quelli che sono
            {
                var dictionary = GetDictionaryConFrequenze(vector).OrderByDescending(x => x.Value).ThenBy(x => x.Key); //Ordinare il dizionario prima per la frquenza che coincide col valore poi per valore
                var numeriPiuFrequenti = dictionary.Select(k => k.Key).ToList().Take(k); //prendiamo i key che corrispondono ai numeri ordinati, e poi prendere i K numeri passati dall'utente
                return numeriPiuFrequenti.ToArray(); 
            }
            else
            {
                throw new ArgumentOutOfRangeException();
            }
        }


        private static Dictionary<int, int> GetDictionaryConFrequenze(int[] vector)
        {
            Dictionary<int, int> frequenze = new Dictionary<int, int>(); //usiamo un dizionario cosi da poter creare una struttura Key e Value

            foreach (int numero in vector)
            {
                if (frequenze.ContainsKey(numero))
                {
                    frequenze[numero]++; //se c'è gia aumentiamo il suo valore di frequenza
                }
                else
                {
                    frequenze[numero] = 1; //se è la prima volta, mettiamo 1
                }
            }

            return frequenze;
        }

        public static void PrintArray(int[] vector)
        {
            for(int i = 0; i < vector.Length; i++)
            {
                Console.WriteLine(vector[i]);
            }
        }
    }
}
