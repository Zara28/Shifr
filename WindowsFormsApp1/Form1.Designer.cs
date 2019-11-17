namespace WindowsFormsApp1
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.buttonWrite = new System.Windows.Forms.Button();
            this.textBoxPas = new System.Windows.Forms.TextBox();
            this.comboBoxLang = new System.Windows.Forms.ComboBox();
            this.comboBoxSite = new System.Windows.Forms.ComboBox();
            this.textBoxSite = new System.Windows.Forms.TextBox();
            this.buttonRead = new System.Windows.Forms.Button();
            this.faqbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonWrite
            // 
            this.buttonWrite.Location = new System.Drawing.Point(21, 114);
            this.buttonWrite.Margin = new System.Windows.Forms.Padding(4);
            this.buttonWrite.Name = "buttonWrite";
            this.buttonWrite.Size = new System.Drawing.Size(221, 28);
            this.buttonWrite.TabIndex = 3;
            this.buttonWrite.Text = "Записать в файл";
            this.buttonWrite.UseVisualStyleBackColor = true;
            this.buttonWrite.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxPas
            // 
            this.textBoxPas.Location = new System.Drawing.Point(21, 81);
            this.textBoxPas.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxPas.Name = "textBoxPas";
            this.textBoxPas.Size = new System.Drawing.Size(221, 22);
            this.textBoxPas.TabIndex = 2;
            // 
            // comboBoxLang
            // 
            this.comboBoxLang.FormattingEnabled = true;
            this.comboBoxLang.Items.AddRange(new object[] {
            "Русская",
            "English"});
            this.comboBoxLang.Location = new System.Drawing.Point(21, 16);
            this.comboBoxLang.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxLang.Name = "comboBoxLang";
            this.comboBoxLang.Size = new System.Drawing.Size(182, 24);
            this.comboBoxLang.TabIndex = 0;
            this.comboBoxLang.Text = "Выбрать раскладку";
            // 
            // comboBoxSite
            // 
            this.comboBoxSite.FormattingEnabled = true;
            this.comboBoxSite.Location = new System.Drawing.Point(252, 15);
            this.comboBoxSite.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxSite.Name = "comboBoxSite";
            this.comboBoxSite.Size = new System.Drawing.Size(160, 24);
            this.comboBoxSite.TabIndex = 4;
            this.comboBoxSite.Text = "Выбрать сайт";
            // 
            // textBoxSite
            // 
            this.textBoxSite.Location = new System.Drawing.Point(21, 49);
            this.textBoxSite.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxSite.Name = "textBoxSite";
            this.textBoxSite.Size = new System.Drawing.Size(221, 22);
            this.textBoxSite.TabIndex = 1;
            // 
            // buttonRead
            // 
            this.buttonRead.Location = new System.Drawing.Point(250, 43);
            this.buttonRead.Margin = new System.Windows.Forms.Padding(4);
            this.buttonRead.Name = "buttonRead";
            this.buttonRead.Size = new System.Drawing.Size(162, 28);
            this.buttonRead.TabIndex = 5;
            this.buttonRead.Text = "Дешифровать";
            this.buttonRead.UseVisualStyleBackColor = true;
            this.buttonRead.Click += new System.EventHandler(this.button2_Click);
            // 
            // faqbutton
            // 
            this.faqbutton.Location = new System.Drawing.Point(210, 12);
            this.faqbutton.Name = "faqbutton";
            this.faqbutton.Size = new System.Drawing.Size(30, 30);
            this.faqbutton.TabIndex = 6;
            this.faqbutton.Text = "?";
            this.faqbutton.UseVisualStyleBackColor = true;
            this.faqbutton.Click += new System.EventHandler(this.faqbutton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 153);
            this.Controls.Add(this.faqbutton);
            this.Controls.Add(this.buttonRead);
            this.Controls.Add(this.textBoxSite);
            this.Controls.Add(this.comboBoxSite);
            this.Controls.Add(this.comboBoxLang);
            this.Controls.Add(this.buttonWrite);
            this.Controls.Add(this.textBoxPas);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximumSize = new System.Drawing.Size(500, 200);
            this.MinimumSize = new System.Drawing.Size(500, 200);
            this.Name = "Form1";
            this.Text = "Шифровщик";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonWrite;
        private System.Windows.Forms.TextBox textBoxPas;
        private System.Windows.Forms.ComboBox comboBoxLang;
        private System.Windows.Forms.ComboBox comboBoxSite;
        private System.Windows.Forms.TextBox textBoxSite;
        private System.Windows.Forms.Button buttonRead;
        private System.Windows.Forms.Button faqbutton;
    }
}

