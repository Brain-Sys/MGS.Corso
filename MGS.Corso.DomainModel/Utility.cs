using System;
using System.Collections.Generic;
using System.Text;

namespace MGS.Corso.DomainModel
{
    public static class Utility
    {
        // Extension method
        public static DateTime PrimoGiornoDelMese(this DateTime value)
        {
            return new DateTime(value.Year, value.Month, 1);
        }

        public static bool IsMaggiorenne(this DateTime value)
        {
            int anni = DateTime.Now.Year - value.Year;
            return anni >= 18;
        }

        public static bool IsMaggiorenne(this DateTime value, string country)
        {
            int anni = DateTime.Now.Year - value.Year;
            return anni >= 21;
        }

        public static void Metodo(this IEnumerable<Fattura> lista)
        {

        }
    }
}