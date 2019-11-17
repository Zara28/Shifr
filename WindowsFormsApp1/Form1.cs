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

            textBoxSite.SetWatermark("Сайт, в котором будет аккаунт");
            textBoxPas.SetWatermark("Пароль(пробелы заменить на _");
            BackgroundImageLayout = ImageLayout.Stretch;
            BackgroundImage = Properties.Resources.backgraund;
            buttonWrite.BackgroundImage = Properties.Resources.button;
            buttonWrite.BackgroundImageLayout = ImageLayout.Stretch;
            buttonRead.BackgroundImage = Properties.Resources.button;
            buttonRead.BackgroundImageLayout = ImageLayout.Stretch;
            faqbutton.BackgroundImage = Properties.Resources.button;
            faqbutton.BackgroundImageLayout = ImageLayout.Stretch;
            
            comboBoxSite.Items.Clear();

           String pas = File.ReadAllText("pas.txt");
            vs = pas.Split(new char[] { ':', '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);
            for(int i =0; i<vs.Length; i++)
            {
                if(i%2==0)
                {
                    comboBoxSite.Items.Add(vs[i]);
                }
            }
           

        }

        public void translate ()
        {
            textBoxPas.Text = "";
            string text;
            if (comboBoxSite.SelectedIndex == 0)
            {
                 text = vs[comboBoxSite.SelectedIndex + 1];
            }
            else
            {
                 text = vs[comboBoxSite.SelectedIndex + 2];
            }
            



            char[] l = text.ToCharArray();
            for (int y = 0; y < text.Length; y++)
            {
                for (int i = 0; i < alf.Length; i++)
                {
                    if (l[y] == alf[i])
                    {
                        int d = alf.Length - i - y - 1;

                        textBoxPas.Text = textBoxPas.Text + alf[d];
                        
                    }
                }

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Shifr.raskl(comboBoxLang.Text);
            stroka = textBoxPas.Text;
            Shifr.doit(stroka, alf);
            StreamWriter f = new StreamWriter("pas.txt", true);
            f.WriteLine(textBoxSite.Text + ":" + Shifr.textshifr + Environment.NewLine);
            f.Close();
            textBoxPas.Text = "";
            textBoxSite.Text = "";
            MessageBox.Show("Готово.");
            Form1_Load(sender, e);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Shifr.raskl(comboBoxLang.Text);
            translate();
            MessageBox.Show("Казалось бы, расшифровал...");
        }

        private void faqbutton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Для шифрования:" + Environment.NewLine + "1)выбери раскладку" + Environment.NewLine + "2)введи сайт" + Environment.NewLine +"3)введи пароль, нажми кнопку ''защифровать''" + Environment.NewLine + "4)помолись" + Environment.NewLine+ Environment.NewLine + Environment.NewLine + "Для дешифровки:" + Environment.NewLine + "1)выбери раскладку" + Environment.NewLine + "2)выбери сайт" + Environment.NewLine + "3)нажми кнопку ''Дешифровать''" + Environment.NewLine + "4)помолись" + Environment.NewLine + "Приятного использования");
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
