public class Solution {
    public bool IsValid(string s) {
        if(s.Length < 2)return false;
        Stack<char> stack = new();
      Dictionary<char, char> dict = new() {
            {')', '('},
            {']', '['},
            {'}', '{'},
        };
       foreach(char c in s){
        if(dict.ContainsKey(c)){
            if(stack.Count == 0){
                return false;
            }
            char topElement = stack.Pop();
            if (topElement!=dict[c]){
                return false;
            }
        }else{
            stack.Push(c);
        }
       }
       return stack.Count == 0;
    }
}
