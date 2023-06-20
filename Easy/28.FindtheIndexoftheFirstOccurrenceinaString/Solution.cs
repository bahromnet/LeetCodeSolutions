namespace Easy._28.FindtheIndexoftheFirstOccurrenceinaString;

public class Solution
{
    public int StrStr(string haystack, string needle)
    {
        if (haystack.Contains(needle))
        {
            return haystack.IndexOf(needle);
        }

        return -1;
    }
}
