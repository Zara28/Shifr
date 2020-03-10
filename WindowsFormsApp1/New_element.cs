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
        public New_element(string c)
        {
            InitializeComponent();
            if(c!=null)
            {
                char[] y = c.ToCharArray();
                for(int i=0; i<y.Length; i++)
                {
                    textBox1.Text = textBox1.Text  + Convert.ToString(y[i]);
                }
               
            }
           
        }

        private void button_show_Click(object sender, EventArgs e)
        {
            see();
        }

      private void see ()
        {
            textBox2.Text = "";
            for (int i = 0; i < Config.alf.Length; i++)
            {
                textBox2.Text = textBox2.Text + Config.alf[i] + " ";
            }
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
            
                char [] elem = textBox1.Text.ToCharArray();
                bool est = false;
                for (int i = 0; i < Config.alf.Length; i++)
                {
                    for(int u = 0; u<elem.Length; u++)
                {
                    if (elem[u] == Config.alf[i])
                    {
                        est = true;
                        MessageBox.Show(Config.It_is);
                        break;

                    }
                    

                    else if (elem[u] == '+' || elem[u] == '"' || elem[u] == ':' || elem[u] == '|')
                    {
                        if (Config.rus_lang)
                        {
                            MessageBox.Show("Это служебный символ");
                        }
                        else
                        {
                            MessageBox.Show("This is a service symbol");
                        }
                        est = true;
                        break;
                    }
                }
                    
                }
                if (!est)
                {
                    StreamWriter f = new StreamWriter("Resours\\alfeng.txt", true);
                for(int i = 0; i< elem.Length; i++)
                    {
                         f.WriteLine(elem[i]);
                    }
                   
                    MessageBox.Show("Ok!");
                    f.Close();

                    Shifr.Overwhite();
                    see();
                    Shifr.raskl();

                    New_element_Load(sender, e);
                }

            
           
        }
    }
}
