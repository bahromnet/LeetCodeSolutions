namespace Easy._345.ReverseVowelsofaString;

public class Solution345
{
    public static string ReverseVowels(string s)
    {
        string vowels = "AaEeIiOoUu";
        string available = "";
        for (int i = 0; i < s.Length; i++)
            if (vowels.Contains(s[i]))
                available += s[i];

        char[] arr = available.ToCharArray();
        Array.Reverse(arr);
        available = new string(arr);
        int j = 0;
        char[] result = new char[s.Length];
        for (int i = 0; i < s.Length; i++)
        {
            if (vowels.Contains(s[i]))
                result[i] = available[j++];

            else
                result[i] = s[i];
        }

        return new string(result);
    }
}
