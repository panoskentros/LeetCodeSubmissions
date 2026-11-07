public class Solution {
    public bool CheckInclusion(string s1, string s2) {
        int s1Len = s1.Length;
        if(s1.Length > s2.Length) return false;
        int[] target = new int[26];
        foreach(char c in s1) target[c-'a']++;
        int[] count = new int[26];

        for(int i = 0; i < s2.Length; i++){
            count[s2[i]-'a']++;
            if(i+1> s1Len ) count[s2[i-s1Len]-'a']--;

            if(areTheSame(count,target)) return true;
        }
        return false;
     
    } 
    private bool areTheSame(int[] count,int[] target){
        for(int i =0; i<26; i++){
            if(count[i] != target[i]){
                return false;
            }
        }
        return true;
    }
}
