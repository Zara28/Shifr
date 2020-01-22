using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.IO;
using System.Threading.Tasks;

namespace Encryption
{
    class Shifr
    {
        public static void read()
        {
            string lang;
            if (!Config.rus_lang)
            {
                lang = "Resours/lang_eng.txt";
            }
           else
            {
                lang = "Resours/lang_rus.txt";
            }
            StreamReader file = new StreamReader(lang);
            string b = file.ReadToEnd();
            Config.names = b.Split(new char[] { ':', '"', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);

            file.Close();
        }
        public static void raskl()
        {
                string lang = "Resours/alfeng.txt";
                string l = "";
                string[] f = File.ReadAllLines(lang);
                for (int i = 0; i < f.Count(); i++)
                {
                    l = l + f[i];
                }
                Config.alf = l.ToCharArray();
            
            
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
                            int c = alf.Length - i - y-5;
                            int d = alf.Length - c - y-5;

                            try
                            {
                                Config.textshifr = Config.textshifr + alf[c];
                            }
                            catch
                            {
                                c = alf.Length + c;
                                Config.textshifr = Config.textshifr + alf[c];
                            }
                           

                        }
                    }

                }
                Config.textshifr = Config.textshifr + '%';
            }
        }
        public static void translate(string site)
        {
            Config.textdeshifr = "";
            string text = "";
            for (int i = 0; i < Config.vs.Length; i++)
            {
                if (site == Config.vs[i])
                {
                    text = Config.vs[i + 1];
                }
            }
            string[] h = text.Split(new char[] {'%'}, StringSplitOptions.RemoveEmptyEntries);
            for(int m = 0; m<h.Length; m++)
            {
                char[] l = h[m].ToCharArray();
                for (int y = 0; y < h[m].Length; y++)
                {
                    for (int i = 0; i < Config.alf.Length; i++)
                    {
                        if (l[y] == Config.alf[i])
                        {
                            int d = Config.alf.Length - i - y - 5;

                            try
                            {
                                Config.textdeshifr = Config.textdeshifr + Config.alf[d];
                            }
                            catch
                            {
                                d = d - Config.alf.Length;
                                Config.textdeshifr = Config.textdeshifr + Config.alf[d];
                            }
                            
                        }
                    }

                }
            }
            
        }
    }
}
