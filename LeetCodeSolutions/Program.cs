namespace LeetCodeSolutions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            

            Solution solution = new Solution();
            
        }

    }

    public class Solution
    {
        public uint reverseBits(uint n)
        {
            uint res = 0;

            for (int i = 0; i < 32; i++)
            {
                var ibit = (n >> i) & 1;
                res = (res << 1) + ibit;
            }

            return res;

        }
    }
}