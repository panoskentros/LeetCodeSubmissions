public class Solution {
    public bool IsPalindrome(string s) {
        s = s.Trim();
        if(s==string.Empty){
            return true;
        }
        s = new string(s.Where(char.IsLetterOrDigit).ToArray()).ToLower();        
        for(int i=0;i<s.Length/2; i++){
            if(s[i] != s[s.Length-1-i]){
                return false;
            }
        }
        return true;
    }
}
