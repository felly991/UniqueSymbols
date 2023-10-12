using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trpo2._4
{
    internal class Symbols
    {
        public List<char> Listed(string text)
        {
            List<char> list = new List<char>();
            int a = 0;
            while (a != text.Length - 1)
            {
                list.Add(text[a++]);
            }
            return list;
        }
        public List<char> Sort(List<char> list)
        {
            int a = 0;
            char temp;
            while (a != list.Count)
            {
                int b = a + 1;
                while (b != list.Count)
                {
                    if (list[a] > list[b])
                    {
                        temp = list[a];
                        list[a] = list[b];
                        list[b] = temp;
                    }
                    b++;
                }
                a++;
            }
            return list;
        }
        public List<char> Delete(List<char> text)
        {
            List<char> list = new List<char>();
            int a = 0;
            while (a != text.Count())
            {
                int b = 0;
                int c = 0;
                while (c != text.Count())
                {
                    if (text[a] == text[c])
                    {
                        b++;
                    }
                    c++;
                }
                if (b < 2)
                {
                    list.Add(text[a]);
                }
                a++;
            }
            return list;
        }

    }
}
