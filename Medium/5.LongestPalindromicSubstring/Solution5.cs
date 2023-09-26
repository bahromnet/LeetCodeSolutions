namespace Medium._5.LongestPalindromicSubstring;
public class Solution5
{
    public string LongestPalindrome(string s)
    {
        if (string.IsNullOrEmpty(s))
            return "";
        else if (s.Length == 1)
            return s;
        else
        {
            int n = s.Length;
            int result = 0;
            string resultPalindrom = "";
            for (int len = 1; len <= n; len++)
            {
                for (int i = 0; i <= n - len; i++)
                {
                    int j = i + len - 1;
                    if (IsPalindrom(s, i, j) && len > result)
                    {
                        result = len;
                        resultPalindrom = s.Substring(i, len);
                    }
                }
            }
            return resultPalindrom;
        }
    }

    private static bool IsPalindrom(string s, int i, int j)
    {
        while (i < j)
        {
            if (s[i++] != s[j--])
                return false;
        }
        return true;
    }
}
