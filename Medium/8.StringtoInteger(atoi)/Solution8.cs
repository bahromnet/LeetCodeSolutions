namespace Medium._8.StringtoInteger_atoi_;
public class Solution8
{
    public int MyAtoi(string s)
    {
        string str = "";
        //List<int> ints = new List<int>();
        for (int i = 0; i < s.Length; i++)
        {
            if (s[i] == '-' || (s[i] >= 48 && s[i] <= 57))
            {
                str += s[i];
            }
        }
        return int.Parse(str);
    }
}
