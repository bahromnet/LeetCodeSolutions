using Easy._13.RomantoInteger;
using Medium._912.SortanArray;

namespace LeetCodeSolutions;

internal class Program
{
    static void Main(string[] args)
    {
        int[] a = { 8, 7, 12, 548, 63, 21, 1, 78, 16, 34 };
        int[] b = Solution912.SortArray(a);
        foreach (var item in b)
        {
            Console.Write(item + ", ");
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