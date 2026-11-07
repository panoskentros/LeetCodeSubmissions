public class Solution {
    public int[] TwoSum(int[] nums, int target){
        Dictionary<int,int> numMap = new Dictionary<int,int>();
        for(int i = 0; i<nums.Length; i++){
            int completent = target - nums[i];
            if(numMap.ContainsKey(completent)){
                return new int[2] {i, numMap[completent] };
            }
            numMap[nums[i]] = i;
        }
        return new int[] {};
    }

}
