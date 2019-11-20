using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Encryption
{
    public partial class Create : Form
    {
        public Create()
        {
            InitializeComponent();
        }

        private void Create_Load(object sender, EventArgs e)
        {
        }

            private void button_save_Click(object sender, EventArgs e)
        {
            if(textBox_site.Text == "")
            {
                MessageBox.Show("Write name of your account/site");
            }
            if (textBox_password.Text == "")
            {
                MessageBox.Show("Write your password");
            }
            else
            {
                string stroka = textBox_password.Text;
                char[] k = stroka.ToCharArray();
                stroka = "";
                for (int i = 0; i < k.Length; i++)
                {
                    if (i % 2 == 0)
                    {
                        stroka = stroka + "%" + k[i];
                    }
                    else stroka = stroka + k[i];
                }
                Shifr.doit(stroka, Config.alf);
                StreamWriter f = new StreamWriter("pas.txt", true);
                f.WriteLine(textBox_site.Text + ":" + Config.textshifr);
                f.Close();
                Config.textshifr = "";
                MessageBox.Show("Password was saved!");
                this.Close();
            }
            
        }
    }
}
