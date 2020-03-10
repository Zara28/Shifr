namespace Encryption
{
    partial class Get
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Get));
            this.label_choose = new System.Windows.Forms.Label();
            this.comboBox_site = new System.Windows.Forms.ComboBox();
            this.textBox_password = new System.Windows.Forms.TextBox();
            this.label_password = new System.Windows.Forms.Label();
            this.button_get = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label_name = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label_choose
            // 
            this.label_choose.AutoSize = true;
            this.label_choose.Location = new System.Drawing.Point(12, 9);
            this.label_choose.Name = "label_choose";
            this.label_choose.Text = "label_choose";

            this.label_choose.Size = new System.Drawing.Size(0, 20);
            this.label_choose.TabIndex = 0;
            // 
            // comboBox_site
            // 
            this.comboBox_site.FormattingEnabled = true;
            this.comboBox_site.Location = new System.Drawing.Point(13, 40);
            this.comboBox_site.Name = "comboBox_site";
            this.comboBox_site.Size = new System.Drawing.Size(121, 28);
            this.comboBox_site.TabIndex = 1;
            // 
            // textBox_password
            // 
            this.textBox_password.Location = new System.Drawing.Point(95, 85);
            this.textBox_password.Name = "textBox_password";
            this.textBox_password.Size = new System.Drawing.Size(100, 26);
            this.textBox_password.TabIndex = 2;
            // 
            // label_password
            // 
            this.label_password.AutoSize = true;
            this.label_password.Location = new System.Drawing.Point(10, 88);
            this.label_password.Name = "label_password";
            this.label_password.Size = new System.Drawing.Size(0, 20);
            this.label_password.TabIndex = 3;
            // 
            // button_get
            // 
            this.button_get.Location = new System.Drawing.Point(158, 40);
            this.button_get.Name = "button_get";
            this.button_get.Size = new System.Drawing.Size(75, 23);
            this.button_get.TabIndex = 4;
            this.button_get.UseVisualStyleBackColor = true;
            this.button_get.Click += new System.EventHandler(this.button_get_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(95, 118);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 26);
            this.textBox1.TabIndex = 5;
            // 
            // label_name
            // 
            this.label_name.AutoSize = true;
            this.label_name.Location = new System.Drawing.Point(16, 123);
            this.label_name.Name = "label_name";
            this.label_name.Size = new System.Drawing.Size(51, 20);
            this.label_name.TabIndex = 6;
            this.label_name.Text = "label1";
           
            // 
            // Get
            // 
            this.ClientSize = new System.Drawing.Size(266, 175);
            this.Controls.Add(this.label_name);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button_get);
            this.Controls.Add(this.label_password);
            this.Controls.Add(this.textBox_password);
            this.Controls.Add(this.comboBox_site);
            this.Controls.Add(this.label_choose);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(300, 250);
            this.Name = "Get";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Get password";
            this.Load += new System.EventHandler(this.Get_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_choose;
        private System.Windows.Forms.ComboBox comboBox_site;
        private System.Windows.Forms.TextBox textBox_password;
        private System.Windows.Forms.Label label_password;
        private System.Windows.Forms.Button button_get;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label_name;
    }
}
