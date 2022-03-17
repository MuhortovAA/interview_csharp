using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BraceApp
{
    class Program
    {
        static void Main(string[] args)
        {
            

            var result = Brace.validbrace("+{[+()-]}");
        }
    }
    class Brace
    {
        public static bool validbrace(string braces)
        {
            var st = new Stack<char>();
            foreach (var item in braces)
            {
                switch (item)
                {
                    case '(':
                    case '{':
                    case '[':
                        st.Push(item);
                        continue;
                    case ')':
                        if (st.Count == 0 || st.Pop() != '(') return false;
                        continue;
                    case ']':
                        if (st.Count == 0 || st.Pop() != '[') return false;
                        continue;
                    case '}':
                        if (st.Count == 0 || st.Pop() != '{') return false;
                        continue;
                }
            }
            return st.Count == 0;
        }
    }
}
