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
    public partial class Get : Form
    {
        public Get()
        {
            InitializeComponent();
        }

        private void Get_Load(object sender, EventArgs e)
        {
            comboBox_site.Items.Clear();

            Shifr.raskl();
            Shifr.read();
            for (int i = 0; i < Config.names.Length; i++)
            {
                if (Config.names[i] == label_choose.Name)
                {
                   // label_choose.Text = " ";
                    label_choose.Text = Config.names[i + 1];
                }
                if (Config.names[i] == this.Name)
                {
                    this.Text = Config.names[i + 1];
                }
                if (Config.names[i] == label_password.Name)
                {
                    label_password.Text = Config.names[i + 1];
                }
                if (Config.names[i] == button_get.Name)
                {
                    button_get.Text = Config.names[i + 1];
                }
                if (Config.names[i] == label_name.Name)
                {
                    label_name.Text = Config.names[i + 1];
                }
            }


            String pas = File.ReadAllText("pas.txt");
            Config.vs = pas.Split(new char[] { ':', '\r', '\n' , '|',}, StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < Config.vs.Length; i++)
            {
                if (i % 3 == 0)
                {
                    comboBox_site.Items.Add(Config.vs[i]);
                }
            }
           
        }

        private void button_get_Click(object sender, EventArgs e)
        {
            string text = "";
            for (int i = 0; i < Config.vs.Length; i++)
            {
                if (comboBox_site.Text == Config.vs[i])
                {
                    Config.adress = Config.vs[i + 1];
                    text = Config.vs[i + 2];
                }
            }
            Shifr.translate(text);
            if(Config.adress!="null")
            {
                textBox1.Text = "https://" + Config.adress;
            }
            else textBox1.Text = "";
            textBox_password.Text = Config.textdeshifr;
            Config.textdeshifr = "";
        }
    }
}
