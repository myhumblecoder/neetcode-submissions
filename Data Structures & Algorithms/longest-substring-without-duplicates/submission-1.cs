public class Solution {
    public int LengthOfLongestSubstring(string s) {
        if(s.Length == 0) return 0;
        
        int left = 0, right = 0, maxLength = 0;

        // use a hashset to capture with window size
        HashSet<char> set = new HashSet<char>();
        
        while(right < s.Length){
            // expand the window
            if(!set.Contains(s[right])){
                set.Add(s[right]);
                right++;
                maxLength = Math.Max(maxLength, right - left);
            }
            else{
                //shrink the window
                set.Remove(s[left]);
                left++;
            }
        } 

        return maxLength;
    }
}
