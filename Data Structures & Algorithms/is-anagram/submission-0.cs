public class Solution {
    public bool IsAnagram(string s, string t) {
        char[] sArray = s.ToCharArray();
        char[] tArray = t.ToCharArray();
        Array.Sort(sArray);
        Array.Sort(tArray);
        string sString = new string(sArray).ToLower();
        string tString = new string(tArray).ToLower();
        if(sString == tString)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}
