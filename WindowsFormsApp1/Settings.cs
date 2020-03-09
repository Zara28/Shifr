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
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();
        }

        private void button_clear_Click(object sender, EventArgs e)
        {
           DialogResult  res =  MessageBox.Show(Config.message, Config.name, MessageBoxButtons.YesNo);
               if(res == DialogResult.Yes)
            {
                File.WriteAllText("pas.txt", "");
                MessageBox.Show("Ok!");
            }
        }

        private void button_change_Click(object sender, EventArgs e)
        {
            if (!Config.rus_lang)
            {
                Config.rus_lang = true;
            }
            else
            {
                Config.rus_lang = false;
            }
            Shifr.read();
            
            Settings_Load(sender, e);
        }

        private void Settings_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < Config.names.Length; i++)
            {
                if (Config.names[i] == button_change.Name)
                {
                    button_change.Text = Config.names[i + 1];
                }
                if (Config.names[i] == button_clear.Name)
                {
                    button_clear.Text = Config.names[i + 1];
                }
                if (Config.names[i] == labelname.Name)
                {
                    labelname.Text = Config.names[i + 1];
                }
                if (Config.names[i] == "name")
                {
                    Config.name = Config.names[i + 1];
                }
                if (Config.names[i] == "message")
                {
                    Config.message = Config.names[i + 1];
                }
                if (Config.names[i] == new_element.Name)
                {
                   new_element.Text = Config.names[i + 1];
                }
                if (Config.names[i] == button_edit.Name)
                {
                    button_edit.Text = Config.names[i + 1];
                }

            }
        }

        private void new_element_Click(object sender, EventArgs e)
        {
            New_element main = new New_element(null);
            main.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Editing form = new Editing();
            form.Show();
        }
    }
}
