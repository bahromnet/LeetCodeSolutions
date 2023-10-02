namespace Medium._7.ReverseInteger;
public class Solution7
{
    public int Reverse(int x)
    {
        if (x < 10 && x > -10)
            return x;

        string minus = "";
        string str = x.ToString();
        if (str[0] == '-')
        {
            minus = str[0].ToString();
            str = str.Remove(0, 1);
        }

        char[] arr = str.ToCharArray();
        char[] resultArr = arr.Reverse().ToArray();
        string resultStr = string.Join("", resultArr);

        while (resultStr[0] == '0')
        {
            resultStr = resultStr.Remove(0, 1);
        }

        if (double.Parse(minus + resultStr) < -2147483648 || double.Parse(minus + resultStr) > 2147483647)
            return 0;

        return Int32.Parse(minus + resultStr);
    }
}
