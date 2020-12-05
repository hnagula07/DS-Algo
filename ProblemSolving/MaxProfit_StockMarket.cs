using System;
using System.Collections.Generic;

namespace ProblemSolving
{
    
// Runtime: 84 ms Your runtime beats 98.80 % of csharp submissions
// Memory Usage: 25.7 MB Your memory usage beats 83.67 % of csharp submissions
    public class MaxProfit_StockMarket
    {
       public int MaxProfit(int[] prices) {
            if(prices.Length == 1)
            return 0;
            int profit = 0;
            int buy = -1;
            int i = 0;
            while(i<prices.Length-1){
                if(buy == -1){
                    buy = prices[i];
                } else if(buy > prices[i]){
                    buy = prices[i];
                } 
                if (prices[i] > prices[i+1]){
                    profit += prices[i] - buy;
                    buy = -1;
                }
                i++;
            }
            if(buy<prices[i] && buy != -1)
                profit += prices[i] - buy;
            return profit;
        }
    }
}
