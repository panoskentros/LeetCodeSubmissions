public class Solution {
    public int[] Intersection(int[] nums1, int[] nums2) {
        int[] freq = new int[1001] ; 
        List<int> ans = new List<int>() ; 
        
        for (int i = 0 ; i < nums1.Length ; i++)
            freq[nums1[i]]++ ; 
        
        for (int i = 0 ; i < nums2.Length ; i++){
            if (freq[nums2[i]] != 0){
                ans.Add(nums2[i]);
                freq[nums2[i]] = 0 ; 
            }
        }

        return ans.ToArray();
    }
}
