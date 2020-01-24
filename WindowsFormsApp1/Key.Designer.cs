namespace Encryption
{
    partial class Key
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
            this.text = new System.Windows.Forms.Label();
            this.textBox_key = new System.Windows.Forms.TextBox();
            this.button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // text
            // 
            this.text.AutoSize = true;
            this.text.Location = new System.Drawing.Point(23, 13);
            this.text.Name = "text";
            this.text.Size = new System.Drawing.Size(51, 20);
            this.text.TabIndex = 0;
            this.text.Text = "label1";
            // 
            // textBox_key
            // 
            this.textBox_key.Location = new System.Drawing.Point(13, 63);
            this.textBox_key.Name = "textBox_key";
            this.textBox_key.Size = new System.Drawing.Size(162, 26);
            this.textBox_key.TabIndex = 1;
            // 
            // button
            // 
            this.button.Location = new System.Drawing.Point(13, 119);
            this.button.Name = "button";
            this.button.Size = new System.Drawing.Size(162, 33);
            this.button.TabIndex = 2;
            this.button.Text = "OK!";
            this.button.UseVisualStyleBackColor = true;
            this.button.Click += new System.EventHandler(this.button_Click);
            // 
            // Key
            // 
            this.ClientSize = new System.Drawing.Size(205, 206);
            this.Controls.Add(this.button);
            this.Controls.Add(this.textBox_key);
            this.Controls.Add(this.text);
            this.Name = "Key";
            this.Load += new System.EventHandler(this.Key_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label text;
        private System.Windows.Forms.TextBox textBox_key;
        private System.Windows.Forms.Button button;
    }
}
