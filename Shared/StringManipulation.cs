using System.Linq;
using System.Collections.Generic;

namespace StringManipulation
{
    public class Manipulate
    {
        public static IEnumerable<string> FromStringToCollection()
        {
            string mountains = "Monte Falco, 1658, Parco Foreste Casentinesi ; Monte Falterona, 1654, Parco Foreste Casentinesi ; Monte Fumaiolo, 1407, Appennino Tosco Emiliano";

            IEnumerable<string> transformed =
            from peak in mountains.Split(';')
            let trimmed = peak.Trim()
            select trimmed;

            return transformed;
        }
    }
}