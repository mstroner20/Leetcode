public class Solution {
    public bool CanConstruct(string ransomNote, string magazine) {
        int ransomCheck = 0;
       
        char[] magazineArray = magazine.ToCharArray();
        char[] ransomArray = ransomNote.ToCharArray();
        
        for(int i = 0; i < ransomArray.Length; i++)
        {
            for(int j = 0; j < magazine.Length; j++)
            {
                if(ransomNote[i] == magazineArray[j])
                {
                    ransomCheck++;
                    magazineArray[j] = ' ';
                    break;
                }
                
            } 
        }
        
        if(ransomCheck == ransomNote.Length)
        {
            return true;
        }
        else {
            return false; 
        } 
    }
}