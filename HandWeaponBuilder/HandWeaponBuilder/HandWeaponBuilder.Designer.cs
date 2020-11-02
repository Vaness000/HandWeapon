namespace HandWeaponBuilder
{
    partial class HandWeaponBuilder
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.builderTypeComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.richTextBoxInfo = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // builderTypeComboBox
            // 
            this.builderTypeComboBox.FormattingEnabled = true;
            this.builderTypeComboBox.Location = new System.Drawing.Point(13, 50);
            this.builderTypeComboBox.Name = "builderTypeComboBox";
            this.builderTypeComboBox.Size = new System.Drawing.Size(418, 23);
            this.builderTypeComboBox.TabIndex = 0;
            this.builderTypeComboBox.TabStop = false;
            this.builderTypeComboBox.SelectedIndexChanged += new System.EventHandler(this.builderTypeComboBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Тип строителя";
            // 
            // richTextBoxInfo
            // 
            this.richTextBoxInfo.Location = new System.Drawing.Point(13, 118);
            this.richTextBoxInfo.Name = "richTextBoxInfo";
            this.richTextBoxInfo.ReadOnly = true;
            this.richTextBoxInfo.Size = new System.Drawing.Size(418, 226);
            this.richTextBoxInfo.TabIndex = 2;
            this.richTextBoxInfo.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Результат";
            // 
            // HandWeaponBuilder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.richTextBoxInfo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.builderTypeComboBox);
            this.Name = "HandWeaponBuilder";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox builderTypeComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox richTextBoxInfo;
        private System.Windows.Forms.Label label2;
    }
}

