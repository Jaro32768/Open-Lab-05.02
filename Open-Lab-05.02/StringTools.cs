using System;

namespace Open_Lab_05._02
{
    public class StringTools
    {
        public string NoYelling(string sentence)
        {
            string z = "";
            string t = sentence;
            for (int i = 0; i < sentence.Length - 1; i++)
            {
                string x = t[t.Length - 1].ToString();
                string y = t[t.Length - 2].ToString();
                if (x == y)
                {
                    z = "";
                    if (x == "!")
                    {
                        for (int k = 0; k < t.Length - 1; k++)
                        {
                            z = z + t[k];
                        }
                        t = z;
                    }
                    else if (x == "?")
                    {
                        for (int k = 0; k < t.Length - 1; k++)
                        {
                            z = z + t[k];
                        }
                        t = z;
                    }
                    else break;
                }
                else break;
            }
            return t;
        }
    }
}
