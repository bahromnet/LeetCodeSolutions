namespace Easy._35.SearchInsertPosition;
public class Solution35
{
    public int SearchInsert(int[] nums, int target)
    {
        int left = 0, mid = 0, right = nums.Length - 1;
        while (left <= right)
        {
            mid = (left + right) / 2;
            if (nums[mid] == target)
                return mid;
            if (target > nums[mid])
                left = mid + 1;
            if (target < nums[mid])
                right = mid - 1;
        }
        if (target < nums[nums.Length - 1])
            return right + 1;
        else
            return nums.Length;
    }
}
