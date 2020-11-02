using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HandWeapon;

namespace HandWeaponAbstractFactory
{
    /// <summary>
    /// Описывает форму для приложения
    /// </summary>
    public partial class HandWeaponAbstractFactory : Form
    {
        /// <summary>
        /// Инициализирует компоненты формы и устанавливает начальное значения выпадающего списка
        /// </summary>
        public HandWeaponAbstractFactory()
        {
            InitializeComponent();
            comboBoxSelectFactory.Items.Add(new HighCaliberWeaponFactory());
            comboBoxSelectFactory.Items.Add(new LowCaliberWeaponFactrory());
            comboBoxSelectFactory.SelectedIndex = 0;
        }

        /// <summary>
        /// Создает строку, описывающую оружие в массиве
        /// </summary>
        /// <param name="parWeapons">массив оружий</param>
        /// <returns></returns>
        private string GetInformationAboutWeapon(Weapon[] parWeapons)
        {
            StringBuilder result = new StringBuilder();
            for (int i = 0; i < parWeapons.Length; i++)
            {
                result.Append(Environment.NewLine);
                result.Append(i + 1);
                result.Append(" оружие - ");
                result.Append(parWeapons[i].ToString());

            }
            return result.ToString();

        }

        /// <summary>
        /// Создает массив оружия в зависимости от выбранной абстрактной фабрики
        /// </summary>
        /// <param name="sender">отправитель события</param>
        /// <param name="e">аргументы события</param>
        private void comboBoxSelectFactory_SelectedIndexChanged(object sender, EventArgs e)
        {
            WeaponFactory factory = (WeaponFactory)comboBoxSelectFactory.SelectedItem;
            WeaponCreator weaponCreator = new WeaponCreator(factory);
            Weapon[] weapons = weaponCreator.CreateWeapons();
            string infoAboutEmployees = GetInformationAboutWeapon(weapons);
            textBoxInfo.Text = "Созданы следующие типы оружия: " + infoAboutEmployees;
        }
    }
}
