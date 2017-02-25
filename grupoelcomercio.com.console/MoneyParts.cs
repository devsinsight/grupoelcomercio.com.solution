using System.Collections.Generic;
using System.Linq;

namespace grupoelcomercio.com.console
{
    public static class MoneyParts
    {
        private static List<List<decimal>> storeAmounts = new List<List<decimal>>();

        public static List<string> build(this decimal money)
        {
            List<int> amounts = new List<int>() { 5, 20, 50, 500, 1000, 2000, 5000, 10000, 20000 };
            List<int> coins = new List<int>();
            List<string> result = new List<string>();

            var m = (int)(money * 100);

            Change(coins, amounts, 0, 0, m);

            storeAmounts.ForEach(r => {
                result.Add("[" + string.Join(",", r) + "]");
            });

            return result;
        }

        private static void Change(List<int> coins, List<int> amounts, int highest, int sum, int goal)
        {

            if (sum == goal)
            {
                Store(coins, amounts);
                return;
            }

            if (sum > goal) return;

            foreach (int value in amounts)
            {
                if (value >= highest)
                {
                    List<int> copy = new List<int>(coins);
                    copy.Add(value);
                    Change(copy, amounts, value, sum + value, goal);
                }
            }
        }

        private static void Store(List<int> coins, List<int> amounts)
        {
            List<decimal> d = new List<decimal>();

            foreach (int amount in amounts)
            {
                coins.ForEach(value =>
                {
                    if (value == amount)
                        d.Add(amount / 100.0M);
                });
            }
            storeAmounts.Add(d);
        }

    }


}

