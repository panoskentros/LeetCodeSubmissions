public class Solution {
    public IList<IList<int>> Subsets(int[] nums) {
        List<IList<int>> res = new();
        res.Add(new List<int>());
        if(nums.Length == 0) return res;
        for(int i=0; i<nums.Length; i++){
            foreach(var lst in res.ToList()){ // .ToList() creates a shallow copy of the res enumerable
                var tmp = new List<int>(lst);
                tmp.Add(nums[i]);
                res.Add(tmp);
            }
        }
        return res;
    }
}
