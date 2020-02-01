using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace Encryption
{
    public partial class New_element : Form
    {
        public New_element()
        {
            InitializeComponent();
        }

        private void button_show_Click(object sender, EventArgs e)
        {
            Process p = Process.Start("Resours\\alfeng.txt");

        }

      

        private void New_element_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < Config.names.Length; i++)
            {
                if (Config.names[i] == button_add.Name)
                {
                    button_add.Text = Config.names[i + 1];
                }
                if (Config.names[i] == button_show.Name)
                {
                    button_show.Text = Config.names[i + 1];
                }
                if (Config.names[i] == label_add.Name)
                {
                    label_add.Text = Config.names[i + 1];
                }
                if (Config.names[i] == "It_is")
                {
                    Config.It_is = Config.names[i + 1];
                }

            }
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            Shifr.raskl();
            char elem = Convert.ToChar(textBox1.Text);
            bool est = false;
            for (int i = 0; i<Config.alf.Length; i++)
            {
                if(elem == Config.alf[i])
                {
                    est = true;
                    break;
                }
            }
            if(!est)
            {
                StreamWriter f = new StreamWriter("Resours\\alfeng.txt", true);
                f.WriteLine("\n" + textBox1.Text);
                MessageBox.Show("Ok!");
                f.Close();
            }
            else
            {
                MessageBox.Show(Config.It_is);
            }
        }
    }
}
