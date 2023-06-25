namespace Easy._13.RomantoInteger;

public class Solution13
{
    public static int RomanToInt(string s)
    {
        int sum = 0;
        int num = 0;
        for (int i = 0; i < s.Length; i++)
        {
            int s1 = num;
            num = keyValuePairs[s[i]];
            int s2 = sum + num;
            if (num > sum)
            {
                num -= sum;
                s2 = num;
                sum = s2;
            }
            else
            {
                if (s1 < num)
                {
                    s2 -= 2 * s1;
                }
                sum = s2;
            }
        }
        return sum;
    }

    public static Dictionary<char, int> keyValuePairs = new Dictionary<char, int>()
    {
        {'I',1 },
        {'V',5 },
        {'X',10 },
        {'L',50 },
        {'C',100 },
        {'D',500 },
        {'M',1000 }
    };
}
