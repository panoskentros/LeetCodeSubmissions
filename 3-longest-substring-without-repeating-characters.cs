public class Solution {
    public int LengthOfLongestSubstring(string s) {
        int n = s.Length;
        int left = 0, right = 0;
        int maxLen = 0;
        var set = new HashSet<char>();

        while (right < n) {
            if (!set.Contains(s[right])) {
                set.Add(s[right]);
                maxLen = Math.Max(maxLen, right - left + 1);
                right++;
            } else {
                set.Remove(s[left]);
                left++;
            }
        }

        return maxLen;
    }
}
