﻿namespace Encryption
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Settings));
            this.labelname = new System.Windows.Forms.Label();
            this.button_clear = new System.Windows.Forms.Button();
            this.button_change = new System.Windows.Forms.Button();
            this.new_element = new System.Windows.Forms.Button();
            this.button_edit = new System.Windows.Forms.Button();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
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
            // button_clear
            // 
            this.button_clear.Location = new System.Drawing.Point(26, 67);
            this.button_clear.Name = "button_clear";
            this.button_clear.Size = new System.Drawing.Size(158, 42);
            this.button_clear.TabIndex = 1;
            this.button_clear.UseVisualStyleBackColor = true;
            this.button_clear.Click += new System.EventHandler(this.button_clear_Click);
            // 
            // button_change
            // 
            this.button_change.Location = new System.Drawing.Point(26, 115);
            this.button_change.Name = "button_change";
            this.button_change.Size = new System.Drawing.Size(158, 39);
            this.button_change.TabIndex = 2;
            this.button_change.UseVisualStyleBackColor = true;
            this.button_change.Click += new System.EventHandler(this.button_change_Click);
            // 
            // new_element
            // 
            this.new_element.Location = new System.Drawing.Point(26, 221);
            this.new_element.Name = "new_element";
            this.new_element.Size = new System.Drawing.Size(158, 55);
            this.new_element.TabIndex = 3;
            this.new_element.UseVisualStyleBackColor = true;
            this.new_element.Click += new System.EventHandler(this.new_element_Click);
            // 
            // button_edit
            // 
            this.button_edit.Location = new System.Drawing.Point(26, 160);
            this.button_edit.Name = "button_edit";
            this.button_edit.Size = new System.Drawing.Size(158, 44);
            this.button_edit.TabIndex = 4;
            this.button_edit.UseVisualStyleBackColor = true;
            this.button_edit.Click += new System.EventHandler(this.button1_Click);
            // 
            // Settings
            // 
            this.ClientSize = new System.Drawing.Size(219, 286);
            this.Controls.Add(this.button_edit);
            this.Controls.Add(this.new_element);
            this.Controls.Add(this.button_change);
            this.Controls.Add(this.button_clear);
            this.Controls.Add(this.labelname);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Settings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Settings_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelname;
        private System.Windows.Forms.Button button_clear;
        private System.Windows.Forms.Button button_change;
        private System.Windows.Forms.Button new_element;
        private System.Windows.Forms.Button button_edit;
        private System.Windows.Forms.FontDialog fontDialog1;
    }
}
