using Medium._1143.LongestCommonSubsequence;
using Medium._6.ZigzagConversion;
using Medium._7.ReverseInteger;

namespace LeetCodeSolutions;

internal class Program
{
    static void Main(string[] args)
    {
        Solution1143 solution = new Solution1143();
        Console.WriteLine(solution.LongestCommonSubsequence("pmjghexybyrgzczy", "hafcdqbgncrcbihkd"));

    }

    static public void MainMerge(int[] numbers, int left, int mid, int right)
    {
        int[] temp = new int[25];
        int i, eol, num, pos;
        eol = (mid - 1);
        pos = left;
        num = (right - left + 1);

        while ((left <= eol) && (mid <= right))
        {
            if (numbers[left] <= numbers[mid])
                temp[pos++] = numbers[left++];
            else
                temp[pos++] = numbers[mid++];
        }
        while (left <= eol)
            temp[pos++] = numbers[left++];
        while (mid <= right)
            temp[pos++] = numbers[mid++];
        for (i = 0; i < num; i++)
        {
            numbers[right] = temp[right];
            right--;
        }
    }

    static public void SortMerge(int[] numbers, int left, int right)
    {
        int mid;
        if (right > left)
        {
            mid = (right + left) / 2;
            SortMerge(numbers, left, mid);
            SortMerge(numbers, (mid + 1), right);
            MainMerge(numbers, left, (mid + 1), right);
        }
    }


    public int[] SortArray(int[] array, int leftIndex, int rightIndex)
    {
        var i = array.First();
        var j = array.Last();
        var pivot = array[leftIndex];
        while (i <= j)
        {
            while (array[i] < pivot)
            {
                i++;
            }

            while (array[j] > pivot)
            {
                j--;
            }
            if (i <= j)
            {
                int temp = array[i];
                array[i] = array[j];
                array[j] = temp;
                i++;
                j--;
            }
        }

        if (leftIndex < j)
            SortArray(array, leftIndex, j);
        if (i < rightIndex)
            SortArray(array, i, rightIndex);
        return array;
    }

}