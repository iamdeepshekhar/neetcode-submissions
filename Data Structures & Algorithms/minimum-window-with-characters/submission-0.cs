public class Solution {
        public string MinWindow(string s, string t) {
            int n = s.Length;
            int m = t.Length;
            int l = 0;
            int r = 0;
            int minLength = int.MaxValue;
            int currentCount = 0;
            int indexMinOfL = -1;

            if (m == 0) { return ""; }

            // target frequency from t, only chars in t
            Dictionary<char, int> dictFreqT = new Dictionary<char, int>();
            for (int i = 0; i < m; i++)
            {
                char c = t[i];
                if (dictFreqT.ContainsKey(c))
                {
                    dictFreqT[c]++;
                }
                else
                {
                    dictFreqT[c] = 1;
                }
            }

            while (r < n)
            {
                char rightChar = s[r];

                // Only care about chars that are in t
                if (dictFreqT.ContainsKey(rightChar))
                {
                    // If this char is still "needed"
                    if (dictFreqT[rightChar] > 0)
                    {
                        currentCount++;
                    }
                    dictFreqT[rightChar]--;
                }

                // Try to shrink from the left while the window is valid
                while (currentCount == m)
                {
                    int windowLen = r - l + 1;
                    if (windowLen < minLength)
                    {
                        minLength = windowLen;
                        indexMinOfL = l;
                    }

                    char leftChar = s[l];

                    if (dictFreqT.ContainsKey(leftChar))
                    {
                        dictFreqT[leftChar]++;
                        // Only reduce count if this char was exactly at the boundary
                        if (dictFreqT[leftChar] > 0)
                        {
                            currentCount--;
                        }
                    }
                    l++;
                }

                r++;
            }

                    return indexMinOfL == -1 ? "" : s.Substring(indexMinOfL, minLength);
}
}
