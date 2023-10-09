using System;
using System.Collections.Generic;
using System.Linq;
namespace ShopKeeper
{
   public class PurchaseAnalyzer
    {
        public static void main(string[] args) { }
            public static int FindPriceOfItemSoldOnce(int[] purchases)
            {
                Dictionary<int, int> purchaseCount = new Dictionary<int, int>();
                foreach (int price in purchases)
                {
                    if (purchaseCount.ContainsKey(price))
                    {
                        purchaseCount[price]++;
                    }
                    else
                    {
                        purchaseCount[price] = 1;
                    }
                }

                int itemSoldOnce = purchaseCount.FirstOrDefault(x => x.Value == 1).Key;

                return itemSoldOnce;
            }

            public static int FindPriceOfItemSoldMoreThanOnce(int[] purchases)
            {
                Dictionary<int, int> purchaseCount = new Dictionary<int, int>();
                foreach (int price in purchases)
                {
                    if (purchaseCount.ContainsKey(price))
                    {
                        purchaseCount[price]++;
                    }
                    else
                    {
                        purchaseCount[price] = 1;
                    }
                }

                int itemSoldMoreThanOnce = purchaseCount.FirstOrDefault(x => x.Value > 1).Key;

                return itemSoldMoreThanOnce;
            }
        }
    }