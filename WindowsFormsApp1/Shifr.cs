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
                string lang = "Resours\\alfeng.txt";
                string l = "";
                string[] f = File.ReadAllLines(lang);
                for (int i = 0; i < f.Count(); i++)
                {
                    if(f[i]!= " ")
                    {
                         l = l + f[i];
                    }
                    
                }
                Config.alf = l.ToCharArray();
            
            
        }

        public static void have_it (string str, char[] alf)
        {
            char[] a = str.ToCharArray();
            for (int y = 0; y < a.Length; y++)
            {
                for (int i = 0; i < alf.Length; i++)
                {
                    if (a[y] == alf[i])
                    {
                        a[y] = ' ';
                    }


                }


            }
            for (int y = 0; y < a.Length; y++)
            {
                for (int i = 0; i < alf.Length; i++)
                {
                    if (a[y] != ' ')
                    {
                        Config.error_no_symbol = true;
                        break;
                    }


                }


            }
        }
        public static void doit(string str, char [] alf)
        {
           // string[] st = str.ToCharArray();//Split(new char[] {'%'}, StringSplitOptions.RemoveEmptyEntries);
           
                char[] a = str.ToCharArray();
                for (int y = 0; y < a.Length; y++)
                {
                    for (int i = 0; i < alf.Length; i++)
                    {
                    int d, c;
                        if (a[y] == alf[i])
                        {

                             c = alf.Length - i - y-Config.dif;
                       
                             d = alf.Length - c - y - Config.dif;

                            
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
        }
        public static void translate(string site)
        {
            Config.textdeshifr = "";
            string text = "";
            for (int i = 0; i < Config.vs.Length; i++)
            {
                if (site == Config.vs[i])
                {
                    Config.adress = Config.vs[i + 1];
                    text = Config.vs[i + 2];
                }
            }
             string[] n = text.Split(new char[] { '+' }, StringSplitOptions.RemoveEmptyEntries);
             Config.dif = Convert.ToInt32(n[0]);
                char[] l = n[1].ToCharArray();
                for (int y = 0; y < l.Length; y++)
                {
                    for (int i = 0; i < Config.alf.Length; i++)
                    {
                        if (l[y] == Config.alf[i])
                        {
                            int d = Config.alf.Length - i - y - Config.dif;

                            try
                            {
                                Config.textdeshifr = Config.textdeshifr + Config.alf[d];
                            }
                            catch
                            {
                                d = Config.alf.Length +d;
                                Config.textdeshifr = Config.textdeshifr + Config.alf[d];
                            }
                            
                        }
                    }

                }
            
            
        }
    }
}
