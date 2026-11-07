public class Solution{
    public bool IsPalindrome(int x){
        if(x<0 || (x%10==0 && x!=0)){
            return false;
        }
        int reversedHalf = 0;
        while(reversedHalf<x){
            int lastDigit = x % 10;
            x/=10;
            reversedHalf = reversedHalf * 10 + lastDigit;
        }
        return reversedHalf == x || (reversedHalf/10==x);
    }
}
