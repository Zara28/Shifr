﻿namespace Encryption
{
    partial class Help
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
            this.tabControl = new System.Windows.Forms.TabControl();
            this.About = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_about = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Create_password = new System.Windows.Forms.TabPage();
            this.textBox_create = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Get_password = new System.Windows.Forms.TabPage();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.textBox_get = new System.Windows.Forms.TextBox();
            this.tabControl.SuspendLayout();
            this.About.SuspendLayout();
            this.Create_password.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.Get_password.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.About);
            this.tabControl.Controls.Add(this.Create_password);
            this.tabControl.Controls.Add(this.Get_password);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(477, 262);
            this.tabControl.TabIndex = 0;
            // 
            // About
            // 
            this.About.Controls.Add(this.label1);
            this.About.Controls.Add(this.textBox_about);
            this.About.Controls.Add(this.textBox1);
            this.About.Location = new System.Drawing.Point(4, 22);
            this.About.Name = "About";
            this.About.Padding = new System.Windows.Forms.Padding(3);
            this.About.Size = new System.Drawing.Size(469, 236);
            this.About.TabIndex = 0;
            this.About.Text = "About";
            this.About.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Font = new System.Drawing.Font("Georgia", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(290, 34);
            this.label1.TabIndex = 2;
            this.label1.Text = "Encryption password";
            // 
            // textBox_about
            // 
            this.textBox_about.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.textBox_about.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_about.Location = new System.Drawing.Point(3, 40);
            this.textBox_about.Multiline = true;
            this.textBox_about.Name = "textBox_about";
            this.textBox_about.Size = new System.Drawing.Size(463, 193);
            this.textBox_about.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.AllowDrop = true;
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox1.Location = new System.Drawing.Point(3, 3);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(463, 230);
            this.textBox1.TabIndex = 0;
            // 
            // Create_password
            // 
            this.Create_password.Controls.Add(this.textBox_create);
            this.Create_password.Controls.Add(this.pictureBox1);
            this.Create_password.Location = new System.Drawing.Point(4, 22);
            this.Create_password.Name = "Create_password";
            this.Create_password.Padding = new System.Windows.Forms.Padding(3);
            this.Create_password.Size = new System.Drawing.Size(469, 236);
            this.Create_password.TabIndex = 1;
            this.Create_password.Text = "Create";
            this.Create_password.UseVisualStyleBackColor = true;
            // 
            // textBox_create
            // 
            this.textBox_create.AllowDrop = true;
            this.textBox_create.Dock = System.Windows.Forms.DockStyle.Left;
            this.textBox_create.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_create.Location = new System.Drawing.Point(3, 3);
            this.textBox_create.Multiline = true;
            this.textBox_create.Name = "textBox_create";
            this.textBox_create.ReadOnly = true;
            this.textBox_create.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_create.Size = new System.Drawing.Size(178, 230);
            this.textBox_create.TabIndex = 4;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox1.Image = global::WindowsFormsApp1.Properties.Resources.Create;
            this.pictureBox1.Location = new System.Drawing.Point(187, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(279, 230);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // Get_password
            // 
            this.Get_password.Controls.Add(this.pictureBox2);
            this.Get_password.Controls.Add(this.textBox_get);
            this.Get_password.Location = new System.Drawing.Point(4, 22);
            this.Get_password.Name = "Get_password";
            this.Get_password.Padding = new System.Windows.Forms.Padding(3);
            this.Get_password.Size = new System.Drawing.Size(469, 236);
            this.Get_password.TabIndex = 2;
            this.Get_password.Text = "Get";
            this.Get_password.UseVisualStyleBackColor = true;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox2.Image = global::WindowsFormsApp1.Properties.Resources.Get;
            this.pictureBox2.Location = new System.Drawing.Point(183, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(283, 230);
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // textBox_get
            // 
            this.textBox_get.AllowDrop = true;
            this.textBox_get.Dock = System.Windows.Forms.DockStyle.Left;
            this.textBox_get.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_get.Location = new System.Drawing.Point(3, 3);
            this.textBox_get.Multiline = true;
            this.textBox_get.Name = "textBox_get";
            this.textBox_get.ReadOnly = true;
            this.textBox_get.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_get.Size = new System.Drawing.Size(174, 230);
            this.textBox_get.TabIndex = 5;
            // 
            // Help
            // 
            this.ClientSize = new System.Drawing.Size(477, 262);
            this.Controls.Add(this.tabControl);
            this.Name = "Help";
            this.Load += new System.EventHandler(this.Help_Load);
            this.tabControl.ResumeLayout(false);
            this.About.ResumeLayout(false);
            this.About.PerformLayout();
            this.Create_password.ResumeLayout(false);
            this.Create_password.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.Get_password.ResumeLayout(false);
            this.Get_password.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage About;
        private System.Windows.Forms.TabPage Create_password;
        private System.Windows.Forms.TabPage Get_password;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox_about;
        private System.Windows.Forms.TextBox textBox_create;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox textBox_get;
        private System.Windows.Forms.Label label1;
    }
}