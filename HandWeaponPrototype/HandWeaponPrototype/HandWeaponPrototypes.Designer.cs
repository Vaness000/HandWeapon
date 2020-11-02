namespace HandWeaponPrototype
{
    partial class Form1
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
            this.weaponTypesCB = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.prototypeFactoryTB = new System.Windows.Forms.RichTextBox();
            this.prototypeFactoryButton = new System.Windows.Forms.Button();
            this.commonConstructorTB = new System.Windows.Forms.RichTextBox();
            this.commonConstructorButton = new System.Windows.Forms.Button();
            this.shootsPMTB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.workTimeTB = new System.Windows.Forms.TextBox();
            this.countBulletsTB = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.caliberTB = new System.Windows.Forms.TextBox();
            this.sightTB = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.reload1BulletTB = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // weaponTypesCB
            // 
            this.weaponTypesCB.FormattingEnabled = true;
            this.weaponTypesCB.Location = new System.Drawing.Point(12, 31);
            this.weaponTypesCB.Name = "weaponTypesCB";
            this.weaponTypesCB.Size = new System.Drawing.Size(333, 23);
            this.weaponTypesCB.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Вид оружия";
            // 
            // prototypeFactoryTB
            // 
            this.prototypeFactoryTB.Location = new System.Drawing.Point(12, 132);
            this.prototypeFactoryTB.Name = "prototypeFactoryTB";
            this.prototypeFactoryTB.Size = new System.Drawing.Size(333, 169);
            this.prototypeFactoryTB.TabIndex = 2;
            this.prototypeFactoryTB.Text = "";
            // 
            // prototypeFactoryButton
            // 
            this.prototypeFactoryButton.Location = new System.Drawing.Point(12, 75);
            this.prototypeFactoryButton.Name = "prototypeFactoryButton";
            this.prototypeFactoryButton.Size = new System.Drawing.Size(333, 23);
            this.prototypeFactoryButton.TabIndex = 3;
            this.prototypeFactoryButton.Text = "Фабрика прототипов";
            this.prototypeFactoryButton.UseVisualStyleBackColor = true;
            this.prototypeFactoryButton.Click += new System.EventHandler(this.prototypeFactoryButton_Click);
            // 
            // commonConstructorTB
            // 
            this.commonConstructorTB.Location = new System.Drawing.Point(370, 132);
            this.commonConstructorTB.Name = "commonConstructorTB";
            this.commonConstructorTB.Size = new System.Drawing.Size(333, 169);
            this.commonConstructorTB.TabIndex = 4;
            this.commonConstructorTB.Text = "";
            // 
            // commonConstructorButton
            // 
            this.commonConstructorButton.Location = new System.Drawing.Point(381, 75);
            this.commonConstructorButton.Name = "commonConstructorButton";
            this.commonConstructorButton.Size = new System.Drawing.Size(322, 23);
            this.commonConstructorButton.TabIndex = 5;
            this.commonConstructorButton.Text = "Обобщенный конструктор";
            this.commonConstructorButton.UseVisualStyleBackColor = true;
            this.commonConstructorButton.Click += new System.EventHandler(this.commonConstructorButton_Click);
            // 
            // shootsPMTB
            // 
            this.shootsPMTB.Location = new System.Drawing.Point(12, 342);
            this.shootsPMTB.Name = "shootsPMTB";
            this.shootsPMTB.Size = new System.Drawing.Size(100, 23);
            this.shootsPMTB.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 319);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "Скорострельность";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 372);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "Рабочее время";
            // 
            // workTimeTB
            // 
            this.workTimeTB.Location = new System.Drawing.Point(13, 391);
            this.workTimeTB.Name = "workTimeTB";
            this.workTimeTB.Size = new System.Drawing.Size(100, 23);
            this.workTimeTB.TabIndex = 9;
            // 
            // countBulletsTB
            // 
            this.countBulletsTB.Location = new System.Drawing.Point(140, 342);
            this.countBulletsTB.Name = "countBulletsTB";
            this.countBulletsTB.Size = new System.Drawing.Size(100, 23);
            this.countBulletsTB.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(141, 319);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 15);
            this.label4.TabIndex = 11;
            this.label4.Text = "Количество патронов";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(141, 372);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 15);
            this.label5.TabIndex = 12;
            this.label5.Text = "Калибр оружия";
            // 
            // caliberTB
            // 
            this.caliberTB.Location = new System.Drawing.Point(141, 391);
            this.caliberTB.Name = "caliberTB";
            this.caliberTB.Size = new System.Drawing.Size(100, 23);
            this.caliberTB.TabIndex = 13;
            // 
            // sightTB
            // 
            this.sightTB.Location = new System.Drawing.Point(286, 341);
            this.sightTB.Name = "sightTB";
            this.sightTB.Size = new System.Drawing.Size(100, 23);
            this.sightTB.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(286, 319);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(113, 15);
            this.label6.TabIndex = 15;
            this.label6.Text = "Кратность прицела";
            // 
            // reload1BulletTB
            // 
            this.reload1BulletTB.Location = new System.Drawing.Point(286, 390);
            this.reload1BulletTB.Name = "reload1BulletTB";
            this.reload1BulletTB.Size = new System.Drawing.Size(100, 23);
            this.reload1BulletTB.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(286, 372);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(155, 15);
            this.label7.TabIndex = 17;
            this.label7.Text = "Перезаряд одного патрона";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(717, 583);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.reload1BulletTB);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.sightTB);
            this.Controls.Add(this.caliberTB);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.countBulletsTB);
            this.Controls.Add(this.workTimeTB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.shootsPMTB);
            this.Controls.Add(this.commonConstructorButton);
            this.Controls.Add(this.commonConstructorTB);
            this.Controls.Add(this.prototypeFactoryButton);
            this.Controls.Add(this.prototypeFactoryTB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.weaponTypesCB);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox weaponTypesCB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox prototypeFactoryTB;
        private System.Windows.Forms.Button prototypeFactoryButton;
        private System.Windows.Forms.RichTextBox commonConstructorTB;
        private System.Windows.Forms.Button commonConstructorButton;
        private System.Windows.Forms.TextBox shootsPMTB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox workTimeTB;
        private System.Windows.Forms.TextBox countBulletsTB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox caliberTB;
        private System.Windows.Forms.TextBox sightTB;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox reload1BulletTB;
        private System.Windows.Forms.Label label7;
    }
}

