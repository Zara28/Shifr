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
                    if(f[i]!= " " && f[i]!= "\n")
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
                for (int u = 0; u < a.Length; u++)
                {
                    if (a[u] != ' ' && a[u] != '+' && a[u] != '|' && a[u] != '"' && a[u] != ':' && a[u]!=a[y])
                    {
                        if(Config.ot_symb == null || Config.ot_symb.Contains(a[u]) == false)
                        {
                            Config.ot_symb = Config.ot_symb + a[u];
                            Config.error_no_symbol = true;
                        }
                        
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
        public static void translate(string text)
        {
            Config.textdeshifr = "";
           
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

        public static void Overwhite()
        {
            String pas = File.ReadAllText("pas.txt");
            Config.vs = pas.Split(new char[] { ':', '\r', '\n', '|', }, StringSplitOptions.RemoveEmptyEntries);
           List<string>  l = new List <string>();
            for (int i = 1; i <= Config.vs.Length; i++)
            {
                if (i % 3 == 0)
                {
                    Shifr.translate(Config.vs[i - 1]);
                    l.Add(Config.textdeshifr);
                    Config.textdeshifr = "";
                }
                else
                {
                    l.Add(Config.vs[i-1]);
                }
              

            }
            File.WriteAllText("pas.txt", "");
            Shifr.raskl();
            StreamWriter f = new StreamWriter("pas.txt", true);
            for (int i = 1; i <= l.Count; i++)
            {
                if (i % 3 == 0)
                {
                    Shifr.doit(l[i-1], Config.alf);
                    f.Write(l[i - 3] + ":" + l[i - 2] + ":" + Convert.ToString(Config.dif)+ "+" + Config.textshifr + Environment.NewLine);
                    Config.textshifr = "";
                }
               

            }
            f.Close();
        }
    }
}
