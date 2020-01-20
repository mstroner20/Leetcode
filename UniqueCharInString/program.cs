public class Solution {
    public int FirstUniqChar(string s) {       
        int[] countArray = new int[s.Length];
        int count = 0;
        
        for(int i = 0; i < s.Length; i++)
        {
            //'e'
            for(int j = 0; j < s.Length; j++)
            {
                if(s[i] == s[j] && j != i)
                {
                    count++;
                    break;
                }
            }
            
            if(count == 0)
            {
                return i;
            }
            
            countArray[i] = count;
            count = 0;
        }
        
        if(countArray.Contains(0) == false)
        {
            return -1;
        }
        return -2;
    }
}