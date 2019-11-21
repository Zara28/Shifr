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
            File.WriteAllText("pas.txt", "");
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


            }
        }

       
    }
}
