using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace Encryption
{
    public partial class Form1 : Form
    {
        public static int kol;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox2.Items.Clear();

            Shifr.raskl();
            String pas = File.ReadAllText("pas.txt");
            Config.vs = pas.Split(new char[] { ':', '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);
            for(int i =0; i<Config.vs.Length; i++)
            {
                if(i%2==0)
                {
                    comboBox2.Items.Add(Config.vs[i]);
                }
            }

            
        }

       

        public void button1_Click(object sender, EventArgs e)
        {
             string stroka = textBox1.Text;
            char[] k = stroka.ToArray();
            stroka = "";
            for(int i = 0; i<k.Length; i++)
            {
                if (i % 2 == 0)
                {
                    stroka = stroka + "%" + k[i];
                }
                else stroka = stroka + k[i];
            }
            Shifr.doit(stroka, Config.alf);
            StreamWriter f = new StreamWriter("pas.txt", true);
            f.WriteLine(textBox2.Text+":"+Config.textshifr);
            f.Close();
            Config.textshifr = "";
            Form1_Load(sender, e);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label2.Text = "";
            Shifr.translate(comboBox2.Text);
            label2.Text = Config.textdeshifr;
            Config.textdeshifr = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
           
            File.WriteAllText("pas.txt", "");
            Form1_Load(sender, e);

        }
    }
}
