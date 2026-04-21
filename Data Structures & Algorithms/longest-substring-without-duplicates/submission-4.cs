public class Solution {
    public int LengthOfLongestSubstring(string s) {
            int maxLength = 0;
        for(int i =0;i<s.Length;i++)
        {
            string currentSubstring = s.Substring(i);
            char[] currentCharArr = currentSubstring.ToCharArray();
            int j=0;//Starting index of this char array
            Dictionary<char,int> dict= new Dictionary<char,int>();
            //if(s.Length == 1) { return 1;}
            int currentLength = 0;
            while(j<currentCharArr.Length)
            {
                if(dict.ContainsKey(currentCharArr[j]))
                {
                    currentLength++;
                    if(currentLength-1>maxLength) { maxLength = currentLength-1;} //Subtracting 1 in this path as it already contains the items, so avoid re-calculation of the same char
                    break; 
                }
                else
                {
                    dict[currentCharArr[j]] = 1;
                    currentLength++;
                    if(currentLength>maxLength) { maxLength = currentLength;}
                }
                j++;                
            }
        }
        return maxLength;    
}
}
