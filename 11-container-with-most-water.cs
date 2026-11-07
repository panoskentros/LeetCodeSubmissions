public class Solution {
    public int MaxArea(int[] height) {
        int max = 0;
        int left = 0;
        int right = height.Length - 1;
        while(left<right){
            int distance = right - left;
            int currentArea = Math.Min(height[left],height[right]) * distance;
            max = Math.Max(max,currentArea);
            if(height[left] < height[right]){
                left++;
            }else{
                right--;
            }
        }
        return max;
    }
}
