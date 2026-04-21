public class Solution {
    public int CharacterReplacement(string s, int k) {
            int n = s.Length;
            int maxLength = 0;
            int maxFrequencyOfAnyChar = 0;
            int l = 0;
            int r = 0;
            int[] freqArrayOfChars = new int[26]; //Storing the frequency of individual capital alphabets(26)
            while(r<n) //n-1 because r+1 would be out of index when n is present
            {
                int indexOfCurrentChar = s[r] - 'A';
                freqArrayOfChars[indexOfCurrentChar]++;
                maxFrequencyOfAnyChar = Math.Max(maxFrequencyOfAnyChar, freqArrayOfChars[indexOfCurrentChar]);

                //Check if the no. of replacements are exceeding k 
                while((r+1-l) - maxFrequencyOfAnyChar > k)
                {
                    //Remove the item from the left side only (NOT RIGHT SIDE)
                    int leftIndex = s[l] - 'A';
                    freqArrayOfChars[leftIndex]--; //reduce the frequency of char from the left
                    l++; //increment the left counter
                }
                maxLength = Math.Max(maxLength, r + 1 - l);
                r++;

            }
            return maxLength;
        
    }
}
