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

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public string result = "";
        public string stroka;
        public static char[] alf = new char[100];
        public static string[] vs = new string[100];
        public static int kol;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox2.Items.Clear();
           String pas = File.ReadAllText("pas.txt");
            vs = pas.Split(new char[] { ':', '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);
            for(int i =0; i<vs.Length; i++)
            {
                if(vs[i].Contains("rus")|| vs[i].Contains("eng"))
                {
                    comboBox2.Items.Add(vs[i+1]);
                }
            }

            comboBox1.SelectedIndex = 0;
            
        }

       

        private void button1_Click(object sender, EventArgs e)
        {
            Shifr.raskl(comboBox1.Text);
            stroka = textBox1.Text;
            char[] k = stroka.ToArray();
            stroka = "";
            for(int i = 0; i<k.Length; i++)
            {
                if (i % 5 == 0)
                {
                    stroka = stroka + "%" + k[i];
                }
                else stroka = stroka + k[i];
            }
            label1.Text = Shifr.textdeshifr;
            Shifr.doit(stroka, alf);
            StreamWriter f = new StreamWriter("pas.txt", true);
            f.WriteLine(comboBox1.Text +":"+textBox2.Text+":"+Shifr.textshifr);
            f.Close();
            Form1_Load(sender, e);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label2.Text = "";
            Shifr.raskl(comboBox1.Text);
            Shifr.translate(comboBox2.Text);
            label2.Text = Shifr.textdeshifr;
        }

       
    }
}
