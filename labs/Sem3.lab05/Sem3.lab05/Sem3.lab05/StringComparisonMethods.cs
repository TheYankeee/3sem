using System;

namespace Sem3.lab05
{
    public class StringComparisonMethods
    {
        public static int LevensteinDistance(string s1, string s2, int n = -1 , int m = -1)
        {
            if (n == -1)
                n = s1.Length;
            if (m == -1)
                m = s2.Length;

            if (n>0)
            {
                if (m > 0)
                {
                    return Math.Min(Math.Min(LevensteinDistance(s1, s2, n - 1, m) + 1, LevensteinDistance(s1, s2, n, m - 1) + 1),
                        LevensteinDistance(s1, s2, n - 1, m - 1) + Convert.ToInt32(!(s1[n - 1] == s2[m - 1])));
                }
                else
                {
                    return n;
                }
            }
            else
            {
                return m;
            }
        }
    }
}
