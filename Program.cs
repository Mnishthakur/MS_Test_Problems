using System;
using System.Collections.Generic;
namespace MSTestProlems
{
    public class PurchaseAnalyzer
    {
        public int GetPriceOfItemSoldOnce(string purchases)
        {
            var prices = GetPrices(purchases);
            var priceCount = CountPrices(prices);

            foreach (var kvp in priceCount)
            {
                if (kvp.Value == 1)
                {
                    return kvp.Key;
                }
            }

            return 0;
        }

        public int GetPriceOfItemSoldMoreThanOnce(string purchases)
        {
            var prices = GetPrices(purchases);
            var priceCount = CountPrices(prices);

            foreach (var kvp in priceCount)
            {
                if (kvp.Value > 1)
                {
                    return kvp.Key;
                }
            }

            return 0; 
        }

        private List<int> GetPrices(string purchases)
        {
            var prices = new List<int>();
            var purchaseArray = purchases.Split(' ');

            foreach (var purchase in purchaseArray)
            {
                if (int.TryParse(purchase, out int price))
                {
                    prices.Add(price);
                }
            }

            return prices;
        }

        private Dictionary<int, int> CountPrices(List<int> prices)
        {
            var priceCount = new Dictionary<int, int>();

            foreach (var price in prices)
            {
                if (priceCount.ContainsKey(price))
                {
                    priceCount[price]++;
                }
                else
                {
                    priceCount[price] = 1;
                }
            }

            return priceCount;
        }
    }


}
