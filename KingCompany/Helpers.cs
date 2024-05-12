using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KingCompany
{
    public static class Helpers
    {
        public static int GetResistenza(int numero)
        {
            var resistenza = 0;

            while (numero > 9) //finché non si arriva ad avere un numero di una cifra, devo continuare con le operazioni per calcolare la resistenza
            {
                var prodotto = 1;

                foreach (char cifra in numero.ToString())
                {
                    prodotto *= (int)Char.GetNumericValue(cifra);
                }

                numero = prodotto;
                resistenza++;
            }

            return resistenza;
        }

        public static int GetNumeroResistente(int resistenza)
        {
            var numero = 0;
            var resistenzaAttuale = 1;

            while(resistenzaAttuale < resistenza)
            {
                
            }
            return numero;
        }
    }
}
