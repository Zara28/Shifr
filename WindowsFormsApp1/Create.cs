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
                if (Config.names[i] == label_name.Name)
                {
                    label_name.Text = Config.names[i + 1];
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
                if (Config.names[i] == this.Name)
                {
                    this.Text = Config.names[i + 1];
                }

            }
        }
        private void check_length(string stroka)
        {
            if (textBox_site.Text == "")
            {
                if (Config.rus_lang)
                {
                    MessageBox.Show("Введите название аккаунта");
                }
                else
                {
                    MessageBox.Show("Write name of your account");
                }
                Config.you_can = false;
            }
           
            else if (textBox_password.Text == "")
            {
                if (Config.rus_lang)
                {
                    MessageBox.Show("Введите пароль");
                }
                else
                {
                    MessageBox.Show("Write your password");
                }
                Config.you_can = false;
            }
            if (stroka.Length >= 25)
            {
                if (Config.rus_lang)
                {
                    MessageBox.Show("Пароль должен содержать менее 25 символов");
                }
                else
                {
                    MessageBox.Show("Password should be less then 25 symbols");
                }
                Config.you_can = false;
            }
            if (stroka.Contains(Convert.ToString('+')) || stroka.Contains(Convert.ToString(':')) || stroka.Contains(Convert.ToString('"'))|| stroka.Contains(Convert.ToString('|')))
            {
                if (Config.rus_lang)
                {
                    MessageBox.Show("Пароль не должен содержать символы '+', кавычки, '|' или ':'");
                }
                else
                {
                    MessageBox.Show("Password shouldn't contains '+', quotation marks, '|' or ':'");
                }
                Config.you_can = false;
            }
            Shifr.have_it(stroka, Config.alf);
            if (Config.error_no_symbol)
            {
                Config.error_no_symbol = false;
                Config.you_can = false;

                if (Config.rus_lang)
                {
                    DialogResult res = MessageBox.Show("Символов "+Config.ot_symb+ "нет в алфавите, добавить его?", "Ошибка", MessageBoxButtons.YesNo);
                    if (res == DialogResult.Yes)
                    {

                        New_element form = new New_element(Config.ot_symb);
                        form.Show();
                    }

                }
                else
                {
                    DialogResult res = MessageBox.Show("Alphabet doesn't have "+ Config.ot_symb+". Do you want add this symbol?", "Error", MessageBoxButtons.YesNo);
                    if (res == DialogResult.Yes)
                    {
                        New_element form = new New_element(Config.ot_symb);
                        form.Show();
                    }
                }
                
            }
        }

            private void button_save_Click(object sender, EventArgs e)
        {
            check_length(textBox_password.Text);
             
            if (Config.you_can)
            {
                if (textBox_name.Text == "")
                {
                    textBox_name.Text = "https://null";
                }
                string stroka = textBox_password.Text;
                
                    Shifr.doit(stroka, Config.alf);
                    StreamWriter f = new StreamWriter("pas.txt", true);
                string[] adress;
                if(textBox_name.Text.Contains("https://"))
                {
                    adress = textBox_name.Text.Split(new string[] { "https://" }, StringSplitOptions.RemoveEmptyEntries);
                    f.WriteLine(textBox_site.Text + ":" + adress[0] + "|" + Convert.ToString(Config.dif) + "+" + Config.textshifr);
                }
                else
                {
                    f.WriteLine(textBox_site.Text + ":" + textBox_name.Text + "|" + Convert.ToString(Config.dif) + "+" + Config.textshifr);
                }
                     
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
            Config.you_can = true;    
            
        }

    }
}
