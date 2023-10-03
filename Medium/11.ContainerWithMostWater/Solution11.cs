namespace Medium._11.ContainerWithMostWater;
public class Solution11
{
    public int MaxArea(params int[] height)
    {
        //int maxHeight = 0;
        //for (int i = 0; i < height.Length-1; i++)
        //    for (int j = i+1; j < height.Length; j++)
        //        if ((Math.Min(height[i], height[j]) * (j - i)) > maxHeight)
        //            maxHeight = Math.Min(height[i], height[j]) * (j - i);

        //return maxHeight;

        int left = 0;
        int right = height.Length-1;
        int maxArea = 0;
        while (left < right)
        {
            int width = right - left;
            int minHeight = Math.Min(height[left], height[right]);
            maxArea = Math.Max(maxArea, width * minHeight);
            if (height[left] < height[right])
                left++;
            else
                right--;
        }
        return maxArea;
    }
}
