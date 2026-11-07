using System;
using System.Collections.Generic;

public class Solution {
    public int CharacterReplacement(string s, int k) {
        var currentCount = new Dictionary<char, int>();
        int left = 0;
        int mostFrequentLetterCount = 0;
        int longestWindow = 0;

        for (int right = 0; right < s.Length; right++) {
            char currentLetter = s[right];
            currentCount[currentLetter] = currentCount.GetValueOrDefault(currentLetter) + 1;
            mostFrequentLetterCount = Math.Max(mostFrequentLetterCount, currentCount[currentLetter]);

            while ((right - left + 1) - mostFrequentLetterCount > k) {
                currentCount[s[left]]--;
                left++;
            }

            longestWindow = Math.Max(longestWindow, right - left + 1);
        }

        return longestWindow;
    }
}
