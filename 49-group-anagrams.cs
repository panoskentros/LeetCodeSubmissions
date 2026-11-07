class Solution{
    public IList<IList<string>> GroupAnagrams(string[] strs){
        Dictionary<string,List<string>> map = new();
        foreach(string word in strs){
            char[] charArr = word.ToCharArray();
            Array.Sort(charArr);
            string key = new string(charArr);
            if(!map.TryGetValue(key,out var list)){
               list = new List<string>();
               map[key] = list; 
            }
            list.Add(word);
        }
        return new List<IList<string>>(map.Values);
    }
}
