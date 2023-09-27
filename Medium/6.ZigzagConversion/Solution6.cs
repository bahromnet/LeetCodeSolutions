namespace Medium._6.ZigzagConversion;
public class Solution6
{
    public string Convert(string s, int numRows)
    {
        if (string.IsNullOrEmpty(s))
            return "";

        else if (s.Length == 1 || numRows == 1)
            return s;

        else
        {
            int range = 2 * numRows - 3;
            int rangeDown = range;
            int rangeUp = 1;
            int rangeBetween = range;
            int i = 0;
            string resultStr = "";
            while (s.Length > resultStr.Length)
            {
                i++;
                if (i == 1 || i == numRows)
                {
                    for (int j = i - 1; j < s.Length; j += range + 1)
                    {
                        resultStr += s[j];
                    }
                }
                else
                {
                    int k = 1;
                    for (int j = i - 1; j < s.Length;)
                    {
                        resultStr += s[j];
                        if (k % 2 == 1)
                        {
                            rangeBetween = rangeDown - 2;
                        }

                        else
                        {
                            rangeBetween = rangeUp;
                        }
                        k++;
                        j += rangeBetween + 1;
                    }
                    rangeDown -= 2;
                    rangeUp += 2;
                    rangeBetween = range - rangeDown;
                }
            }
            return resultStr;
        }
    }
}
