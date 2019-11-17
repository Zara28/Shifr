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
using System.Runtime.InteropServices;

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
            textBox1.SetWatermark("Сайт, в котором будет аккаунт");
            textBox2.SetWatermark("Пароль(пробелы заменить на _");
            BackgroundImageLayout = ImageLayout.Stretch;
            BackgroundImage = Properties.Resources.backgraund;
            button1.BackgroundImage = Properties.Resources.button;
            button1.BackgroundImageLayout = ImageLayout.Stretch;
            button2.BackgroundImage = Properties.Resources.button;
            button2.BackgroundImageLayout = ImageLayout.Stretch;
           


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
            textBox2.Text = "";
            string text;
            if (comboBox2.SelectedIndex == 0)
            {
                 text = vs[comboBox2.SelectedIndex + 1];
            }
            else
            {
                 text = vs[comboBox2.SelectedIndex + 2];
            }
            



            char[] l = text.ToCharArray();
            for (int y = 0; y < text.Length; y++)
            {
                for (int i = 0; i < alf.Length; i++)
                {
                    if (l[y] == alf[i])
                    {
                        int d = alf.Length - i - y - 1;

                        textBox2.Text = textBox2.Text + alf[d];
                    }
                }

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Shifr.raskl(comboBox1.Text);
            stroka = textBox1.Text;
            Shifr.doit(stroka, alf);
            StreamWriter f = new StreamWriter("pas.txt", true);
            f.WriteLine(textBox2.Text+":"+Shifr.textshifr);
            f.Close();
            Form1_Load(sender, e);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Shifr.raskl(comboBox1.Text);
            translate();
        }

    }

    public static class TextBoxWatermarkExtensionMethod
    {
        private const uint ECM_FIRST = 0x1500;
        private const uint EM_SETCUEBANNER = ECM_FIRST + 1;

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = false)]
        private static extern IntPtr SendMessage(IntPtr hWnd, uint Msg, uint wParam, [MarshalAs(UnmanagedType.LPWStr)] string lParam);

        public static void SetWatermark(this TextBox textBox, string watermarkText)
        {
            SendMessage(textBox.Handle, EM_SETCUEBANNER, 0, watermarkText);
        }

    }

}
