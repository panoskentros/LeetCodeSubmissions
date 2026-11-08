public class Solution {
    public bool CanPartition(int[] nums) {
        int target = 0;
        foreach(int num in nums) target += num;
        if(target % 2 != 0) return false;
        target/=2;
        bool[] dp = new bool[target+1];
        // dp[n] = true, if there is a subseq that adds up to n
        // dp[n-num] can i sum up to target if i add num to a i-num amount?
        dp[0] = true;
        foreach(int num in nums){
            for(int i = target; i>=num; i-- ){
                dp[i] = dp[i] || dp[i-num];
            }
        }
        return dp[target];
    }
}
