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
            for (int i = 0; i < Config.names.Length; i++)
            {
                if (Config.names[i] == button_save.Name)
                {
                    button_save.Text = Config.names[i + 1];
                }
                if (Config.names[i] == labelhelpsite.Name)
                {
                    labelhelpsite.Text = Config.names[i + 1];
                }
                if (Config.names[i] == labelhelp_password.Name)
                {
                    labelhelp_password.Text = Config.names[i + 1];
                }
                if (Config.names[i] == Warning.Name)
                {
                    Warning.Text = Config.names[i + 1];
                }
                if (Config.names[i] == Warning2.Name)
                {
                    Warning2.Text = Config.names[i + 1];
                }

            }
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
               // char[] k = stroka.ToCharArray();
               // stroka = "";
                if(stroka.Length>=25)
                {
                    if (Config.rus_lang)
                    {
                       MessageBox.Show("Пароль должен содержать менее 25 символов");
                    }
                    else
                    {
                        MessageBox.Show("Password should be less then 25 symbols");
                    }
                    textBox_password.Text = "";
                }
                else
                {
                    Shifr.doit(stroka, Config.alf);
                    StreamWriter f = new StreamWriter("pas.txt", true);
                    f.WriteLine(textBox_site.Text + ":" + Convert.ToString(Config.dif) + "+" + Config.textshifr);
                    f.Close();
                    Config.textshifr = "";
                    string message;
                    if (Config.rus_lang)
                    {
                        message = "Ваш пароль успешно сохранен!";
                    }
                    else
                    {
                        message = "Your password was saved!";
                    }
                    MessageBox.Show(message);
                    this.Close();
                }
            }
                
            
        }

    }
}
