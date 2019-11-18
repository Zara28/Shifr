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
            if (lang == "rus")
            {
                lang = "alfrus.txt";
            }
            else if (lang == "eng")
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
            string [] st = str.Split(new char[] {'%'}, StringSplitOptions.RemoveEmptyEntries);
            for( int l = 0; l <st.Length; l++)
            {
                char[] a = st[l].ToCharArray();
                for (int y = 0; y < a.Length; y++)
                {
                    for (int i = 0; i < alf.Length; i++)
                    {
                        if (a[y] == alf[i])
                        {
                            int c = Math.Abs(alf.Length - 1 - i - y);
                            int d = alf.Length - c - y - 1;

                            textshifr = textshifr + alf[c];

                        }
                    }

                }
                textshifr = textshifr + '%';
            }
            textdeshifr = textshifr;
        }
        public static void translate(string site)
        {
            Shifr.textdeshifr = "";
            string text = "";
            string lang = "";
            for (int i = 0; i < Form1.vs.Length; i++)
            {
                if (site == Form1.vs[i])
                {
                    text = Form1.vs[i + 1];
                    lang = Form1.vs[i - 1];
                }
            }
            Shifr.raskl(lang);
            string[] h = text.Split(new char[] {'%'}, StringSplitOptions.RemoveEmptyEntries);
            for(int m = 0; m<h.Length; m++)
            {
                char[] l = h[m].ToCharArray();
                for (int y = 0; y < h[m].Length; y++)
                {
                    for (int i = 0; i < Form1.alf.Length; i++)
                    {
                        if (l[y] == Form1.alf[i])
                        {
                            int d = Form1.alf.Length - i - y - 1;

                            Shifr.textdeshifr = Shifr.textdeshifr + Form1.alf[d];
                        }
                    }

                }
            }
            
        }
    }
}
