namespace HandWeaponAbstractFactory
{
    partial class HandWeaponAbstractFactory
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
            this.comboBoxSelectFactory = new System.Windows.Forms.ComboBox();
            this.textBoxInfo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboBoxSelectFactory
            // 
            this.comboBoxSelectFactory.FormattingEnabled = true;
            this.comboBoxSelectFactory.Location = new System.Drawing.Point(229, 65);
            this.comboBoxSelectFactory.Name = "comboBoxSelectFactory";
            this.comboBoxSelectFactory.Size = new System.Drawing.Size(274, 23);
            this.comboBoxSelectFactory.TabIndex = 0;
            this.comboBoxSelectFactory.SelectedIndexChanged += new System.EventHandler(this.comboBoxSelectFactory_SelectedIndexChanged);
            // 
            // textBoxInfo
            // 
            this.textBoxInfo.Location = new System.Drawing.Point(229, 124);
            this.textBoxInfo.Multiline = true;
            this.textBoxInfo.Name = "textBoxInfo";
            this.textBoxInfo.Size = new System.Drawing.Size(274, 286);
            this.textBoxInfo.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(229, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Тип оружия";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(229, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Результат";
            // 
            // HandWeaponAbstractFactory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 422);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxInfo);
            this.Controls.Add(this.comboBoxSelectFactory);
            this.Name = "HandWeaponAbstractFactory";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxSelectFactory;
        private System.Windows.Forms.TextBox textBoxInfo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

