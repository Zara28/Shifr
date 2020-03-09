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
    public partial class Editing : Form
    {
        public Editing()
        {
            InitializeComponent();
           

        }




        private void Editing_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();

            Shifr.raskl();
            Shifr.read();
            for (int i = 0; i < Config.names.Length; i++)
            {
                if (Config.names[i] == button_edit.Name)
                {
                    button_edit.Text = Config.names[i + 1];
                }
                if (Config.names[i] == label_edit.Name)
                {
                    label_edit.Text = Config.names[i + 1];
                }
                if (Config.names[i] == label_choose.Name)
                {
                    label_choose.Text = Config.names[i + 1];
                }
                if (Config.names[i] == this.Name)
                {
                    this.Text = Config.names[i + 1];
                }

            }

            String pas = File.ReadAllText("pas.txt");
            Config.vs = pas.Split(new char[] { ':', '\r', '\n', '|', }, StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < Config.vs.Length; i++)
            {
                if (i % 3 == 0)
                {
                    comboBox1.Items.Add(Config.vs[i]);
                }
            }
        }

        private void button_edit_Click(object sender, EventArgs e)
        {
            Create.check_length(textBox2.Text, comboBox1.Text);
            if(Config.you_can)
            {
                File.WriteAllText("pas.txt", "");
                StreamWriter f = new StreamWriter("pas.txt", true);
                for (int i = 0; i < Config.vs.Length; i++)
                {

                    if (comboBox1.Text == Config.vs[i])
                    {
                        Shifr.doit(textBox2.Text, Config.alf);

                        f.WriteLine(Config.vs[i] + ":" + Config.vs[i + 1] + "|" + Convert.ToString(Config.dif) + "+" + Config.textshifr);
                        MessageBox.Show("Ok");
                        Config.textshifr = "";
                    }
                    else
                    {
                        if (i % 3 == 0)
                        {
                            f.WriteLine(Config.vs[i] + ":" + Config.vs[i + 1] + "|" + Config.vs[i + 2]);
                        }
                    }
                }
                f.Close();
            }
            Config.you_can = true;
        }

        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < Config.vs.Length; i++)
            {
                if(Config.vs[i] == comboBox1.Text)
                {
                    Shifr.translate(Config.vs[i+2]);
                    label1.Text = Config.textdeshifr;
                }
            }
        }
    }
}
