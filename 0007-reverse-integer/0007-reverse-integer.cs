public class Solution {
    public int Reverse(int x) {
        int num = x > 0 ? x : x * -1;
        var sign = x > 0 ? 1 : -1;
        int index = num.ToString().Length - 1;
        long result = 0;
        while (num > 0)
        {
            int rem = num % 10;
            num = num / 10;
            result += ((long)Math.Pow((double)10, (double)index--) * rem);
        }

        return result > int.MaxValue ? 0 : (int)(sign * result);
    }
}