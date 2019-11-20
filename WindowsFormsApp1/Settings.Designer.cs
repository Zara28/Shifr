namespace Encryption
{
    partial class Settings
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
            this.labelname = new System.Windows.Forms.Label();
            this.button_clear = new System.Windows.Forms.Button();
            this.button_change = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelname
            // 
            this.labelname.AutoSize = true;
            this.labelname.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelname.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelname.Location = new System.Drawing.Point(0, 0);
            this.labelname.Name = "labelname";
            this.labelname.Size = new System.Drawing.Size(143, 39);
            this.labelname.TabIndex = 0;
            this.labelname.Text = "Settings";
            this.labelname.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // button_clear
            // 
            this.button_clear.Location = new System.Drawing.Point(26, 66);
            this.button_clear.Name = "button_clear";
            this.button_clear.Size = new System.Drawing.Size(136, 23);
            this.button_clear.TabIndex = 1;
            this.button_clear.Text = "Clear the all passwords";
            this.button_clear.UseVisualStyleBackColor = true;
            this.button_clear.Click += new System.EventHandler(this.button_clear_Click);
            // 
            // button_change
            // 
            this.button_change.Location = new System.Drawing.Point(26, 109);
            this.button_change.Name = "button_change";
            this.button_change.Size = new System.Drawing.Size(136, 23);
            this.button_change.TabIndex = 2;
            this.button_change.Text = "Change languange";
            this.button_change.UseVisualStyleBackColor = true;
            // 
            // Settings
            // 
            this.ClientSize = new System.Drawing.Size(273, 185);
            this.Controls.Add(this.button_change);
            this.Controls.Add(this.button_clear);
            this.Controls.Add(this.labelname);
            this.Name = "Settings";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelname;
        private System.Windows.Forms.Button button_clear;
        private System.Windows.Forms.Button button_change;
    }
}
