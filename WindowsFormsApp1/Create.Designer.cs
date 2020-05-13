namespace Encryption
{
    partial class Create
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Create));
            this.panel1 = new System.Windows.Forms.Panel();
            this.Warning = new System.Windows.Forms.TextBox();
            this.textBox_name = new System.Windows.Forms.TextBox();
            this.label_name = new System.Windows.Forms.Label();
            this.button_save = new System.Windows.Forms.Button();
            this.labelhelp_password = new System.Windows.Forms.Label();
            this.textBox_password = new System.Windows.Forms.TextBox();
            this.textBox_site = new System.Windows.Forms.TextBox();
            this.labelhelpsite = new System.Windows.Forms.Label();
            this.pictureBox_eye = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_eye)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox_eye);
            this.panel1.Controls.Add(this.Warning);
            this.panel1.Controls.Add(this.textBox_name);
            this.panel1.Controls.Add(this.label_name);
            this.panel1.Controls.Add(this.button_save);
            this.panel1.Controls.Add(this.labelhelp_password);
            this.panel1.Controls.Add(this.textBox_password);
            this.panel1.Controls.Add(this.textBox_site);
            this.panel1.Controls.Add(this.labelhelpsite);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(409, 260);
            this.panel1.TabIndex = 0;
            // 
            // Warning
            // 
            this.Warning.Location = new System.Drawing.Point(13, 154);
            this.Warning.Multiline = true;
            this.Warning.Name = "Warning";
            this.Warning.ReadOnly = true;
            this.Warning.Size = new System.Drawing.Size(384, 65);
            this.Warning.TabIndex = 6;
            // 
            // textBox_name
            // 
            this.textBox_name.Location = new System.Drawing.Point(107, 15);
            this.textBox_name.Name = "textBox_name";
            this.textBox_name.Size = new System.Drawing.Size(100, 26);
            this.textBox_name.TabIndex = 0;
            // 
            // label_name
            // 
            this.label_name.AutoSize = true;
            this.label_name.Location = new System.Drawing.Point(12, 22);
            this.label_name.Name = "label_name";
            this.label_name.Size = new System.Drawing.Size(51, 20);
            this.label_name.TabIndex = 5;
            this.label_name.Text = "label1";
            // 
            // button_save
            // 
            this.button_save.Location = new System.Drawing.Point(81, 225);
            this.button_save.Name = "button_save";
            this.button_save.Size = new System.Drawing.Size(75, 23);
            this.button_save.TabIndex = 3;
            this.button_save.UseVisualStyleBackColor = true;
            this.button_save.Click += new System.EventHandler(this.button_save_Click);
            // 
            // labelhelp_password
            // 
            this.labelhelp_password.AutoSize = true;
            this.labelhelp_password.Location = new System.Drawing.Point(12, 110);
            this.labelhelp_password.Name = "labelhelp_password";
            this.labelhelp_password.Size = new System.Drawing.Size(0, 20);
            this.labelhelp_password.TabIndex = 0;
            // 
            // textBox_password
            // 
            this.textBox_password.Location = new System.Drawing.Point(107, 110);
            this.textBox_password.Name = "textBox_password";
            this.textBox_password.Size = new System.Drawing.Size(100, 26);
            this.textBox_password.TabIndex = 2;
            // 
            // textBox_site
            // 
            this.textBox_site.Location = new System.Drawing.Point(107, 63);
            this.textBox_site.Name = "textBox_site";
            this.textBox_site.Size = new System.Drawing.Size(100, 26);
            this.textBox_site.TabIndex = 1;
            this.textBox_site.TextChanged += new System.EventHandler(this.textBox_site_TextChanged);
            // 
            // labelhelpsite
            // 
            this.labelhelpsite.AutoSize = true;
            this.labelhelpsite.Location = new System.Drawing.Point(12, 63);
            this.labelhelpsite.Name = "labelhelpsite";
            this.labelhelpsite.Size = new System.Drawing.Size(0, 20);
            this.labelhelpsite.TabIndex = 0;
            // 
            // pictureBox_eye
            // 
            this.pictureBox_eye.Location = new System.Drawing.Point(225, 110);
            this.pictureBox_eye.Name = "pictureBox_eye";
            this.pictureBox_eye.Size = new System.Drawing.Size(28, 26);
            this.pictureBox_eye.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_eye.TabIndex = 7;
            this.pictureBox_eye.TabStop = false;
            this.pictureBox_eye.Click += new System.EventHandler(this.pictureBox_eye_Click);
            // 
            // Create
            // 
            this.ClientSize = new System.Drawing.Size(409, 260);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(450, 350);
            this.Name = "Create";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Create a new password";
            this.Load += new System.EventHandler(this.Create_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_eye)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button_save;
        private System.Windows.Forms.Label labelhelp_password;
        private System.Windows.Forms.TextBox textBox_password;
        private System.Windows.Forms.TextBox textBox_site;
        private System.Windows.Forms.Label labelhelpsite;
        private System.Windows.Forms.TextBox textBox_name;
        private System.Windows.Forms.Label label_name;
        private System.Windows.Forms.TextBox Warning;
        private System.Windows.Forms.PictureBox pictureBox_eye;
    }
}
