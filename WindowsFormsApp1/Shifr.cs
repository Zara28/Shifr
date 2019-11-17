using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.IO;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class Shifr
    {
        public static string textshifr;
        public static string textdeshifr;

        public static void raskl(string lang)
        {
            if (lang == "Русская")
            {
                lang = "alfrus.txt";
            }
            else
            {
                lang = "alfeng.txt";
            }
                string l = "";
                string[] f = File.ReadAllLines(lang);
                for (int i = 0; i < f.Count(); i++)
                {
                    l = l + f[i];
                }
                Form1.alf = l.ToCharArray();
            
            
        }
        public static void doit(string str, char [] alf)
        {
            char[] a = str.ToCharArray();
            for (int y = 0; y < str.Length; y++)
            {
                for (int i = 0; i < alf.Length; i++)
                {
                    if (a[y] == alf[i])
                    {
                        int c = Math.Abs(alf.Length - 1 - i - y);
                        int d = alf.Length - c - y-1;
                        textshifr = textshifr + alf[c];
                        
                        textdeshifr = textdeshifr + alf[d];
                    }
                }

            }
        }
    }
}
