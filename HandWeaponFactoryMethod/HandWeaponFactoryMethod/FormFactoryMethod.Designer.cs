namespace HandWeaponFactroryMethod
{
    partial class FormFactroryMethod
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
            this.comboBoxSelectFactoryMethod = new System.Windows.Forms.ComboBox();
            this.comboBoxSelectTypeWeapon = new System.Windows.Forms.ComboBox();
            this.textBoxInfo = new System.Windows.Forms.TextBox();
            this.comboBoxSelectFacory = new System.Windows.Forms.ComboBox();
            this.factoryTypeLabel = new System.Windows.Forms.Label();
            this.factoryLabel = new System.Windows.Forms.Label();
            this.weaponLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboBoxSelectFactoryMethod
            // 
            this.comboBoxSelectFactoryMethod.FormattingEnabled = true;
            this.comboBoxSelectFactoryMethod.Items.AddRange(new object[] {
            "Классический вариант фабричного метода",
            "Обобщённый конструктор"});
            this.comboBoxSelectFactoryMethod.Location = new System.Drawing.Point(12, 28);
            this.comboBoxSelectFactoryMethod.Name = "comboBoxSelectFactoryMethod";
            this.comboBoxSelectFactoryMethod.Size = new System.Drawing.Size(335, 23);
            this.comboBoxSelectFactoryMethod.TabIndex = 0;
            this.comboBoxSelectFactoryMethod.SelectedIndexChanged += new System.EventHandler(this.comboBoxSelectFactoryMethod_SelectedIndexChanged);
            // 
            // comboBoxSelectTypeWeapon
            // 
            this.comboBoxSelectTypeWeapon.FormattingEnabled = true;
            this.comboBoxSelectTypeWeapon.Items.AddRange(new object[] {
            "Автомат",
            "Снайперка",
            "Пистолет"});
            this.comboBoxSelectTypeWeapon.Location = new System.Drawing.Point(12, 134);
            this.comboBoxSelectTypeWeapon.Name = "comboBoxSelectTypeWeapon";
            this.comboBoxSelectTypeWeapon.Size = new System.Drawing.Size(335, 23);
            this.comboBoxSelectTypeWeapon.TabIndex = 1;
            this.comboBoxSelectTypeWeapon.SelectedIndexChanged += new System.EventHandler(this.comboBoxSelectTypeWeapon_SelectedIndexChanged);
            // 
            // textBoxInfo
            // 
            this.textBoxInfo.Location = new System.Drawing.Point(12, 205);
            this.textBoxInfo.Multiline = true;
            this.textBoxInfo.Name = "textBoxInfo";
            this.textBoxInfo.Size = new System.Drawing.Size(335, 164);
            this.textBoxInfo.TabIndex = 2;
            // 
            // comboBoxSelectFacory
            // 
            this.comboBoxSelectFacory.FormattingEnabled = true;
            this.comboBoxSelectFacory.Items.AddRange(new object[] {
            "Фбрика автоматов",
            "Фабрика снайперских винтовок",
            "Фабрика пистолетов"});
            this.comboBoxSelectFacory.Location = new System.Drawing.Point(12, 83);
            this.comboBoxSelectFacory.Name = "comboBoxSelectFacory";
            this.comboBoxSelectFacory.Size = new System.Drawing.Size(335, 23);
            this.comboBoxSelectFacory.TabIndex = 3;
            this.comboBoxSelectFacory.SelectedIndexChanged += new System.EventHandler(this.comboBoxSelectFacory_SelectedIndexChanged);
            // 
            // factoryTypeLabel
            // 
            this.factoryTypeLabel.AutoSize = true;
            this.factoryTypeLabel.Location = new System.Drawing.Point(12, 9);
            this.factoryTypeLabel.Name = "factoryTypeLabel";
            this.factoryTypeLabel.Size = new System.Drawing.Size(166, 15);
            this.factoryTypeLabel.TabIndex = 4;
            this.factoryTypeLabel.Text = "Вариант фабричного метода";
            // 
            // factoryLabel
            // 
            this.factoryLabel.AutoSize = true;
            this.factoryLabel.Location = new System.Drawing.Point(12, 65);
            this.factoryLabel.Name = "factoryLabel";
            this.factoryLabel.Size = new System.Drawing.Size(79, 15);
            this.factoryLabel.TabIndex = 5;
            this.factoryLabel.Text = "Вид фабрики";
            // 
            // weaponLabel
            // 
            this.weaponLabel.AutoSize = true;
            this.weaponLabel.Location = new System.Drawing.Point(12, 116);
            this.weaponLabel.Name = "weaponLabel";
            this.weaponLabel.Size = new System.Drawing.Size(72, 15);
            this.weaponLabel.TabIndex = 6;
            this.weaponLabel.Text = "Вид оружия";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 174);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "Результат";
            // 
            // FormFactroryMethod
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(593, 422);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.weaponLabel);
            this.Controls.Add(this.factoryLabel);
            this.Controls.Add(this.factoryTypeLabel);
            this.Controls.Add(this.comboBoxSelectFacory);
            this.Controls.Add(this.textBoxInfo);
            this.Controls.Add(this.comboBoxSelectTypeWeapon);
            this.Controls.Add(this.comboBoxSelectFactoryMethod);
            this.Name = "FormFactroryMethod";
            this.Text = "Фабричный метод";
            this.Load += new System.EventHandler(this.FormFactroryMethod_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxSelectFactoryMethod;
        private System.Windows.Forms.ComboBox comboBoxSelectTypeWeapon;
        private System.Windows.Forms.TextBox textBoxInfo;
        private System.Windows.Forms.ComboBox comboBoxSelectFacory;
        private System.Windows.Forms.Label factoryTypeLabel;
        private System.Windows.Forms.Label factoryLabel;
        private System.Windows.Forms.Label weaponLabel;
        private System.Windows.Forms.Label label1;
    }
}

