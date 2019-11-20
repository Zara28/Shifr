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
            String pas = File.ReadAllText("pas.txt");
            Config.vs = pas.Split(new char[] { ':', '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < Config.vs.Length; i++)
            {
                if (i % 2 == 0)
                {
                    comboBox_site.Items.Add(Config.vs[i]);
                }
            }
            comboBox_site.SelectedIndex = 0;
        }

        private void button_get_Click(object sender, EventArgs e)
        {
            Shifr.translate(comboBox_site.Text);
            textBox_password.Text = Config.textdeshifr;
            Config.textdeshifr = "";
        }
    }
}
