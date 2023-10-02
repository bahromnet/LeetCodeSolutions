namespace Medium._1143.LongestCommonSubsequence;
public class Solution1143
{
    public int LongestCommonSubsequence(string text1, string text2)
    {
        //int res = 0;
        //int result = 0;
        //int index = int.MinValue;
        //string str = text1;
        //var textArray1 = text1.Length <= text2.Length ? text1.ToCharArray() : text2.ToCharArray();
        //var textArray2 = str.Length > text2.Length ? str.ToCharArray() : text2.ToCharArray();
        //for (int i = 0; i < textArray1.Length;)
        //{
        //    if (textArray2.Contains(textArray1[i]))
        //    {
        //        if (Array.IndexOf(textArray2, textArray1[i]) > index)
        //        {
        //            index = Array.IndexOf(textArray2, textArray1[i]);
        //            textArray2[Array.IndexOf(textArray2, textArray1[i])] = '0';
        //            res++;
        //            i++;
        //        }
        //        else if (res > result)
        //        {
        //            result = res;
        //            res = 0;
        //            index = 0;
        //        }
        //        else
        //            i++;
        //    }
        //    else
        //        i++;
        //}
        //return result > res ? result : res;

        int m = text1.Length;
        int n = text2.Length;

        int[,] dp = new int[m + 1, n + 1];

        for (int i = 1; i <= m; i++)
        {
            for (int j = 1; j <= n; j++)
            {
                if (text1[i - 1] == text2[j - 1])
                    dp[i, j] = dp[i - 1, j - 1] + 1;
                else
                    dp[i, j] = Math.Max(dp[i - 1, j], dp[i, j - 1]);
            }
        }
        return dp[m, n];
    }
}
