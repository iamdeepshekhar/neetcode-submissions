public class Solution {
    public string Encode(IList<string> strs) {
        StringBuilder sb = new StringBuilder();
        foreach(string str in strs)
        {
            sb.Append(str.Length + "#" + str);
        }
        return sb.ToString();
    }

    public List<string> Decode(string s) {
        List<string> result = new List<string>();
        int i=0;
        while(i<s.Length)
        {
            int hashIndex = s.IndexOf("#",i);
            if(hashIndex == -1) { break;}
            int lengthOfCurrentString = int.Parse(s.Substring(i, hashIndex - i));
            //i = hashIndex + 1;
            result.Add(s.Substring(hashIndex+1,lengthOfCurrentString));
            i = hashIndex + 1 + lengthOfCurrentString;
        }
        return result;
    }
}

