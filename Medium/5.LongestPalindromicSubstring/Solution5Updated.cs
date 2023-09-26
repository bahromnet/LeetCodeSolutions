namespace Medium._5.LongestPalindromicSubstring;
public class Solution5Updated
{
    public string LongestPalindrome(string s)
    {
        if (string.IsNullOrEmpty(s))
            return "";

        int maxLength = 0;
        int start = 0;

        for (int i = 0; i < s.Length; i++)
        {
            int lenOdd = ExpandAroundCenter(s, i, i);
            int lenEven = ExpandAroundCenter(s, i, i + 1);

            int len = Math.Max(lenOdd, lenEven);

            if (len > maxLength)
            {
                maxLength = len;
                start = i - (len - 1) / 2;
            }
        }

        return s.Substring(start, maxLength);
    }

    private int ExpandAroundCenter(string s, int left, int right)
    {
        int L = left;
        int R = right;

        while (L >= 0 && R < s.Length && s[L] == s[R])
        {
            L--;
            R++;
        }

        return R - L - 1;
    }
}
