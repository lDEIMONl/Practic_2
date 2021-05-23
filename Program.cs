using System;

namespace Practic_2
{
    class Program
    {
        private static int OutputF(string f)
        {
            int token1 = f.IndexOf("f");
            int token2 = f.LastIndexOf("f");
            
            if (token1 == -1 || token2 == -1)
            {
                return -2;
            }
            else if (token1 == token2)
            {
                return -1;
            }
            else
            {
                int t = 0;
                int k = 0;
                for (int i = 0; i < f.Length; i++)
                {
                    if (f[i].Equals('f'))
                    {
                        t++;
                        if (t == 2)
                        {
                            k = i;
                        }
                    }
                }
                return k;
            }

        }

        private static string Eng(string ru)
        {
            string[] a = {"a", "b", "v", "g", "d", "e", "e","zh", "z", "i", "j", "k", "l", "m", "n", "o",
                "p", "r", "s", "t", "u", "f", "h", "c", "ch", "sh","shch", "e", "yu", "ya"};

            string b = "абвгдеёжзийклмнопрстуфхцчшщэюя";

            string newEng = "";
            for (int i = 0; i < ru.Length; i++)
            {
                for (int j = 0; j < b.Length; j++)
                {
                    if (ru[i].Equals(b[j]) && (!ru[i].Equals('ь') || !ru[i].Equals('ъ') || !ru[i].Equals('ы')))
                    {
                        newEng += a[j];
                    }
                }
            }
            return newEng;
        }

        private static string OutputH(string h)
        {
            int tokenFirst = h.IndexOf("h");
            int tokenLast = h.LastIndexOf("h");
            if (tokenFirst == tokenLast)
            {
                return h;
            }
            string a = "";
            for (int i = 0; i < h.Length; i++)
            {
                if (tokenFirst == i)
                {
                    a += h[i].ToString();
                }
                else if (tokenLast == i)
                {
                    a += h[i].ToString();
                }
                else
                {
                    if (h[i].Equals('h'))
                    {
                        string hUpper = h[i].ToString().ToUpper();
                        a += hUpper;
                    }
                    else
                    {
                        a += h[i].ToString();
                    }
                }
            }
            return a;
        }
        static void Main(string[] args)
        {
            //Задание 1
            string a = "asdgh";
            Console.WriteLine("Задание 1: " + OutputF(a));

            //Задание 2
            string b = "вадим";
            Console.WriteLine("Задание 2: " + Eng(b));

            //Задание 3
            string c = "asdhdshasdhas";
            Console.WriteLine("Задание 3: " + OutputH(c));
        }
    }
}
