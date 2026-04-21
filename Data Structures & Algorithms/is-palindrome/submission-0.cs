public class Solution {
    public bool IsPalindrome(string s) {
        string cleanSString = new string (s.Where(char.IsLetterOrDigit).ToArray()).ToLower();
        bool isPalindromeCheck = true;
        char[] charArray = cleanSString.ToCharArray();
        for(int i =0; i<charArray.Length/2;i++)
        {
            if(!(charArray[i] == charArray[charArray.Length - i -1]))
            {
                isPalindromeCheck = false;
                break;
            }
        }

        return isPalindromeCheck;
    }
}
