/*
Filtering over lists with LINQ
*/
using System.Linq;
using System.Collections.Generic;


namespace Filtering
{
    public class Filter
    {
        public static IEnumerable<string> CitiesByString(string param)
        {
            string[] cities = new string[] { "Arezzo", "Arezzo", "Siena", "Firenze", "Lucca" };

            IEnumerable<string> filtered =
            from city in cities where city == param select city;
            return filtered;
        }
    }
}