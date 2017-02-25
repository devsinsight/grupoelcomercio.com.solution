using System;
using System.Collections.Generic;
using System.Linq;

namespace grupoelcomercio.com.console
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var test1 = "123abcde!";
            var test2 = "123ABCXX!";
            var test4 = new int[] { 12, 3, 7 };
            var test5 = 1.0M;

            Console.WriteLine("-----------------ChangeString------------------");
            Console.WriteLine(test1.build());
            Console.WriteLine(test2.build());
            Console.WriteLine("-----------------CompleteRange------------------");
            test4.build().ToList().ForEach(x => Console.Write(x + ", "));
            Console.WriteLine("-----------------MoneyParts------------------");
            test5.build().ForEach(x => Console.WriteLine(x));

            Console.Read();

        }





    }
}
