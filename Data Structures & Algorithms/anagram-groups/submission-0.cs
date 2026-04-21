public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs)     {
        List<List<string>> finalList = new List<List<string>>(); 
        List<int> travelledIndices = new List<int>();  
        string[] strsClone = (string[])strs.Clone();
        for (int i = 0; i < strsClone.Length; i++)
        {
            char[] charArray = strsClone[i].ToCharArray();
            Array.Sort(charArray);
            strsClone[i] = new string(charArray);
        }
        for (int i = 0; i < strs.Length; i++)
        {
            if(!travelledIndices.Contains(i))
            {
                           List<string> anagramGroup = new List<string>();
            anagramGroup.Add(strs[i]);
            //Mark the travelled indices in strs Clone
            travelledIndices.Add(i);
            for (int j = i + 1; j < strsClone.Length; j++)
            {
                 if (strsClone[i].ToLower() == strsClone[j].ToLower())
                {
                    anagramGroup.Add(strs[j]);
                    travelledIndices.Add(j);
                }
            }
            if(anagramGroup.Count > 0)
            {
                finalList.Add(anagramGroup);

            }
            }
 
        }
        return finalList;
    }
}
