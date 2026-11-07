public class Solution{
    public bool ContainsDuplicate(int[] nums){
        HashSet<int> numsHash = new();
        foreach(int num in nums){
            if(numsHash.Contains(num)){
                return true;
            }
            numsHash.Add(num);
        }
        return false;
    }
}
