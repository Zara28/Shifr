using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.IO;

namespace Encryption
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Random rnd = new Random();
            int value = rnd.Next(0, 9);
            Config.dif = value;
          
                StreamReader file = new StreamReader("Resours/lang_rus.txt");
                string b = file.ReadToEnd();
                Config.names = b.Split(new char[] { ':', '"', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);

                file.Close();
            StreamWriter f = new StreamWriter("Resours/lang_rus.txt", true);
           
                    if(Config.names[Config.names.Length - 2] == "lang")
                    {
                         Config.rus_lang = Convert.ToBoolean(Config.names[Config.names.Length - 1]);
                         Config.isit = true;
                    }
                
           
           
            if (Config.isit == false)
                {
                    DialogResult res = MessageBox.Show("Do you want change language \n Хотите изменить язык на русский?", "Language", MessageBoxButtons.YesNo);

                    if (res == DialogResult.Yes)
                    {
                         Config.rus_lang = true;
                    }
                    else
                    {
                        Config.rus_lang = false;
                    }
                f.WriteLine("lang:" + '"' + Convert.ToString(Config.rus_lang) + '"');
            }

           
            f.Close();
            Application.Run(new Main());

        }
    }
}
