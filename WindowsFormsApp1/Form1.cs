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
                if(i%2==0)
                {
                    comboBox2.Items.Add(vs[i]);
                }
            }
           

        }

        public void translate ()
        {
            label2.Text = "";
            string text = vs[comboBox2.SelectedIndex + 1];
            char[] l = text.ToCharArray();
            for (int y = 0; y < text.Length; y++)
            {
                for (int i = 0; i < alf.Length; i++)
                {
                    if (l[y] == alf[i])
                    {
                        int d = alf.Length - i - y - 1;

                        label2.Text = label2.Text + alf[d];
                    }
                }

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Shifr.raskl(comboBox1.Text);
           // translate();
            stroka = textBox1.Text;
            Shifr.doit(stroka, alf);
            StreamWriter f = new StreamWriter("pas.txt", true);
            f.WriteLine(textBox2.Text+":"+Shifr.textshifr);
            f.Close();
            Form1_Load(sender, e);
        }
    }
}
