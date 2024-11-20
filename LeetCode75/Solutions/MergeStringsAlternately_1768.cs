using System.Numerics;
using System.Text;

namespace LeetCode75.Solutions;
public static class MergeStringsAlternately_1768
{
    public static string MergeAlternately(string word1, string word2)
    {
        int len1 = word1.Length, len2 = word2.Length;
        StringBuilder str = new();
        //char[] chars = new char[len1 + len2];
        var max = Math.Max(len1, len2);
        for (int i = 0; i < max; i++)
        {
            if (i < len1) str.Append(word1[i]);
            if (i < len2) str.Append(word2[i]);
        }
        return str.ToString();
    }

    public static string MergeAlternately3(string word1, string word2)
    {
        int len1 = word1.Length, len2 = word2.Length;
        int minLen = Math.Min(len1, len2);
        char[] chars = new char[len1 + len2];
        int index = 0, i = 0;

        while (i < minLen)
        {
            chars[index++] = word1[i];
            chars[index++] = word2[i];
            i++;
        }

        if (len1 > len2)
        {
            word1.CopyTo(i, chars, index, len1 - i);
        }
        else if (len2 > len1)
        {
            word2.CopyTo(i, chars, index, len2 - i);
        }

        return new string(chars);
    }

    public static string MergeAlternately2(string word1, string word2)
    {
        return string.Create(word1.Length + word2.Length, (word1, word2), (chars, state) =>
        {
            int index = 0, i = 0;
            while (i < state.word1.Length && i < state.word2.Length)
            {
                chars[index++] = state.word1[i];
                chars[index++] = state.word2[i];
                i++;
            }
            while (i < state.word1.Length)
                chars[index++] = state.word1[i++];

            while (i < state.word2.Length)
                chars[index++] = state.word2[i++];
        });
    }
}
