public class Solution{
    public bool IsAnagram(string t, string s){
        if(t.Length != s.Length){
            return false;
        }
        int[] letters = new int [26];
        for(int i = 0; i< s.Length; i++){
            letters[t[i] - 'a'] += 1;
            letters[s[i] - 'a'] -= 1;
        }
        foreach(int letterCount in letters){
            if(letterCount != 0){
                return false;
            }
        }
        return true;
    }
}
