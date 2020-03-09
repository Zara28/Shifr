namespace Encryption
{
    partial class Editing
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Editing));
            this.labelname = new System.Windows.Forms.Label();
            this.label_choose = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label_edit = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button_edit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelname
            // 
            this.labelname.AutoSize = true;
            this.labelname.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelname.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelname.Location = new System.Drawing.Point(0, 0);
            this.labelname.Name = "labelname";
            this.labelname.Size = new System.Drawing.Size(0, 61);
            this.labelname.TabIndex = 0;
            this.labelname.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label_choose
            // 
            this.label_choose.AutoSize = true;
            this.label_choose.Location = new System.Drawing.Point(13, 13);
            this.label_choose.Name = "label_choose";
            this.label_choose.Size = new System.Drawing.Size(51, 20);
            this.label_choose.TabIndex = 1;
            this.label_choose.Text = "label1";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(12, 44);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 28);
            this.comboBox1.TabIndex = 3;
            this.comboBox1.SelectedValueChanged += new System.EventHandler(this.comboBox1_SelectedValueChanged);
            // 
            // label_edit
            // 
            this.label_edit.AutoSize = true;
            this.label_edit.Location = new System.Drawing.Point(12, 90);
            this.label_edit.Name = "label_edit";
            this.label_edit.Size = new System.Drawing.Size(51, 20);
            this.label_edit.TabIndex = 4;
            this.label_edit.Text = "label2";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(134, 84);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(136, 26);
            this.textBox2.TabIndex = 5;
            // 
            // button_edit
            // 
            this.button_edit.Location = new System.Drawing.Point(12, 133);
            this.button_edit.Name = "button_edit";
            this.button_edit.Size = new System.Drawing.Size(75, 27);
            this.button_edit.TabIndex = 6;
            this.button_edit.Text = "button1";
            this.button_edit.UseVisualStyleBackColor = true;
            this.button_edit.Click += new System.EventHandler(this.button_edit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(170, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "label1";
            // 
            // Editing
            // 
            this.ClientSize = new System.Drawing.Size(346, 173);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_edit);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label_edit);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label_choose);
            this.Controls.Add(this.labelname);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Editing";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Editing_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelname;
        private System.Windows.Forms.Label label_choose;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label_edit;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button_edit;
        private System.Windows.Forms.Label label1;
    }
}
