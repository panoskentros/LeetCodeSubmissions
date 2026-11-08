public class Solution {
    public int CoinChange(int[] coins, int amount) {
        // dp[n] = k, where k the fewest number of coins to reach the amount n

        int[] dp = new int[amount+1];
        Array.Fill(dp,amount+1);
        dp[0] = 0;
        for(int i=1; i<amount+1; i++){
            foreach(int coin in coins){
                if(coin > i) continue; // if the coin is bigger than the target amount ignore the coin
                dp[i] =  Math.Min(dp[i], dp[i-coin] +1);
            }
        }
        return dp[amount] != amount+1 ? dp[amount] : -1;
    }
}
