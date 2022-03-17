using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Task2App
{
    class Program
    {
        static void Main(string[] args)
        {
            var s = "test";
            var a = "t";
            var b = "e";
            var result1 = GetData(s, a, b);
            var result2 = GetData2(s, a, b);
            var result3 = GetData(s, a, b);
            Console.WriteLine($"1:{result1} 2:{result2} 3:{result3}");
            Console.ReadLine();
        }

        static int GetData(string s, string a, string b)
        {
            Regex rx = new Regex(@"^$");
            MatchCollection mathes = rx.Matches(s);
            if (mathes.Count > 0)
                return -1;
            else
            {
                int i = s.Length - 1;
                int aIndex = -1;
                int bIndex = -1;
                while ((aIndex == -1) && (bIndex == -1) && (i >= 0))
                {
                    if (s.Substring(i, Math.Max(Math.Min(i + 1, s.Length - i) - i, 1)).Equals(a)) aIndex = i;
                    if (s.Substring(i, Math.Max(Math.Min(i + 1, s.Length - i) - i, 1)).Equals(b)) bIndex = i;
                    i--;
                }
                if (aIndex != -1)
                {
                    if (bIndex == -1) return aIndex;
                    else return Math.Max(aIndex, bIndex);
                }
                else
                {
                    if (bIndex != -1)
                        return bIndex;
                    else return -1;
                }
            }
        }
        static int GetData2(string s, string a, string b)
        {
            MatchCollection mathes = (new Regex(@"^$")).Matches(s);

            if (mathes.Count > 0) return -1;
            else
            {
                int aIndex = -1, bIndex = -1;
                for (int i = 0; i < s.Length; i++)
                {
                    if (s[i].ToString().Equals(a)) aIndex = i;
                    if (s[i].ToString().Equals(b)) bIndex = i;
                }
                return aIndex == -1 && bIndex == -1 ? -1 : Math.Max(aIndex, bIndex);
            }

        }
        static int GetData3(string s, string a, string b)
        {
            if ((new Regex(@"^$")).Matches(s).Count > 0) return -1;
            int aIndex = s.IndexOf(a), bIndex = s.IndexOf(b);
            return aIndex == -1 && bIndex == -1 ? -1 : Math.Max(aIndex, bIndex);
        }
    }
}

