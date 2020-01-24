using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace Encryption
{
    public partial class Key : Form
    {
        public Key()
        {
            InitializeComponent();
        }

       
        
        public void Key_Load(object sender, EventArgs e)
        {
            Shifr.raskl();
            Shifr.read();

            for (int i = 0; i < Config.names.Length; i++)
            {
                if (Config.names[i] == text.Name)
                {
                    text.Text = Config.names[i + 1];
                }
              
            }
        }

        

        private void button_Click(object sender, EventArgs e)
        {
            try
            {
                int i = Convert.ToInt32(textBox_key.Text);

                if (textBox_key.Text != "")
                {
                    Config.dif = i;
                    Main main = new Main();
                    main.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Where are your key?");
                }

            }
            catch
            {
                MessageBox.Show("Only numbers!");
            }

        }

    }
}
