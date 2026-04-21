public class Solution {
      public int LongestConsecutive(int[] nums) {
      Dictionary<int,bool> dicNums = new Dictionary<int,bool>(nums.Length); //this bool value conveys if this item has been traversed or not
      int maxSequenceLength = 0;
      //Add the nums items to a dictionary
      foreach(int item in nums)
        {
            if(!dicNums.ContainsKey(item))
            {
                dicNums.Add(item,false); 
            }
        }
        //traverse through each dictionary item and see if it has been traversed;
        foreach(var item in dicNums)
        {
            int sequenceLength = 0;
            if(item.Value == false)
            {
                dicNums[item.Key] = true;
                //int lowerSequence = dicNums.ElementAt(i).Key - 1;
                sequenceLength = 1 + CheckLowerSequence(item.Key-1,dicNums);
                if(sequenceLength>maxSequenceLength)
                {
                    maxSequenceLength = sequenceLength;
                }
            }
        }
        return maxSequenceLength;
    }
    private int CheckLowerSequence(int integerToCheck, Dictionary<int,bool> dicNums)
    {
        int count = 0;
        bool continueCheck = true;
        while(continueCheck == true)
        {
            if(dicNums.ContainsKey(integerToCheck))
            {
                dicNums[integerToCheck] = true;
                count++;
                integerToCheck = integerToCheck -1;
            }
            else
            {
                continueCheck = false;
            }
        }
        return count;
    }
                      
}