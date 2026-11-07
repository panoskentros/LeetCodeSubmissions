public class Solution {
    public int LongestConsecutive(int[] nums) {
        int maxSeq = 0;
        HashSet<int> hashSet = new HashSet<int>(nums);
        foreach(int num in hashSet){
            if(hashSet.Contains(num-1)){
                continue;
            }
            int seq = 1;
            while(hashSet.Contains(num+seq)){
                seq++;
            }
            maxSeq = Math.Max(maxSeq,seq);
        }
        return maxSeq;
    }
}
