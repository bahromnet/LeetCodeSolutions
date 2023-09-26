namespace Medium._3.LongestSubstringWithoutRepeatingCharacters;
public class Solution3
{
    public int LengthOfLongestSubstring(string s)
    {
        string newStr = "";
        int result = 0;
        for (int i = 0; i < s.Length; i++)
        {
            if (!newStr.Contains(s[i]))
                newStr += s[i];

            else
            {
                int index = newStr.IndexOf(s[i]);
                newStr = newStr.Substring(index+1);
                newStr += s[i];
            }

            if (newStr.Length > result)
                result = newStr.Length;
        }
        return result;
    }
}
