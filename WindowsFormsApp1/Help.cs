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
    public partial class Help : Form
    {
        public Help()
        {
            InitializeComponent();
        }

        private void Help_Load(object sender, EventArgs e)
        {
            //string [] names = File.ReadAllLines("lang_rus");
            Shifr.read();

            for(int i = 0; i<Config.names.Length; i++)
            {
               if (Config.names[i]== textBox_about.Name)
                {
                   
                    textBox_about.Text = Config.names[i+1];
                }
                if (Config.names[i] == textBox_create.Name)
                {
                    textBox_create.Text = Config.names[i + 1];
                }
                if (Config.names[i] == textBox_get.Name)
                {
                    textBox_get.Text = Config.names[i + 1];
                }
            }
           
        }
    }
}
