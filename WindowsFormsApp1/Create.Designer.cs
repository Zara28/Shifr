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
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox_site = new System.Windows.Forms.TextBox();
            this.textBox_password = new System.Windows.Forms.TextBox();
            this.button_save = new System.Windows.Forms.Button();
            this.labelhelp_password = new System.Windows.Forms.Label();
            this.labelhelpsite = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button_save);
            this.panel1.Controls.Add(this.labelhelp_password);
            this.panel1.Controls.Add(this.textBox_password);
            this.panel1.Controls.Add(this.textBox_site);
            this.panel1.Controls.Add(this.labelhelpsite);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(266, 175);
            this.panel1.TabIndex = 0;
            // 
            // textBox_site
            // 
            this.textBox_site.Location = new System.Drawing.Point(107, 28);
            this.textBox_site.Name = "textBox_site";
            this.textBox_site.Size = new System.Drawing.Size(100, 20);
            this.textBox_site.TabIndex = 1;
            // 
            // textBox_password
            // 
            this.textBox_password.Location = new System.Drawing.Point(107, 66);
            this.textBox_password.Name = "textBox_password";
            this.textBox_password.Size = new System.Drawing.Size(100, 20);
            this.textBox_password.TabIndex = 1;
            // 
            // button_save
            // 
            this.button_save.Location = new System.Drawing.Point(80, 114);
            this.button_save.Name = "button_save";
            this.button_save.Size = new System.Drawing.Size(75, 23);
            this.button_save.TabIndex = 2;
            this.button_save.Text = "Save";
            this.button_save.UseVisualStyleBackColor = true;
            this.button_save.Click += new System.EventHandler(this.button_save_Click);
            // 
            // labelhelp_password
            // 
            this.labelhelp_password.AutoSize = true;
            this.labelhelp_password.Location = new System.Drawing.Point(48, 69);
            this.labelhelp_password.Name = "labelhelp_password";
            this.labelhelp_password.Size = new System.Drawing.Size(53, 13);
            this.labelhelp_password.TabIndex = 0;
            this.labelhelp_password.Text = "Password";
            // 
            // labelhelpsite
            // 
            this.labelhelpsite.AutoSize = true;
            this.labelhelpsite.Location = new System.Drawing.Point(12, 31);
            this.labelhelpsite.Name = "labelhelpsite";
            this.labelhelpsite.Size = new System.Drawing.Size(89, 13);
            this.labelhelpsite.TabIndex = 0;
            this.labelhelpsite.Text = "Name of account";
            // 
            // Create
            // 
            this.ClientSize = new System.Drawing.Size(266, 175);
            this.Controls.Add(this.panel1);
            this.Name = "Create";
            this.Text = "Create a new password";
            this.Load += new System.EventHandler(this.Create_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button_save;
        private System.Windows.Forms.Label labelhelp_password;
        private System.Windows.Forms.TextBox textBox_password;
        private System.Windows.Forms.TextBox textBox_site;
        private System.Windows.Forms.Label labelhelpsite;
    }
}
