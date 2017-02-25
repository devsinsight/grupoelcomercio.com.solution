using System.Linq;
using System.Text.RegularExpressions;

namespace grupoelcomercio.com.console
{
    public static class ChangeString 
    {
        public static string build(this string cadena) => changeCharByNextChar(cadena);


        private static string changeCharByNextChar(string cadena) =>
            new string(cadena.ToCharArray().Select(c => c = char.IsLetter(c) ? (char)((int)c + 1) : c).ToArray());

    }
}
