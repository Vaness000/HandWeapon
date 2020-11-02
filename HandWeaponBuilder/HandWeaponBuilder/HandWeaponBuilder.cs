using HandWeapon;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HandWeaponBuilder
{
    /// <summary>
    /// Описывает форму приложения
    /// </summary>
    public partial class HandWeaponBuilder : Form
    {
        /// <summary>
        /// Инициализирует компоненты
        /// </summary>
        public HandWeaponBuilder()
        {
            InitializeComponent();
            builderTypeComboBox.Items.Add(new HighCaliberWeaponBuilder());
            builderTypeComboBox.Items.Add(new LowCaliberWeaponBuilder());
        }

        /// <summary>
        /// Создает список оружия в зависимости от выбранного объекта строителя
        /// </summary>
        /// <param name="sender">отправитель события</param>
        /// <param name="e">аргументы события</param>
        private void builderTypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<Weapon> weapons;
            Director director = new Director();
            if (builderTypeComboBox.SelectedIndex == 0)
            {
                weapons = director.CreateWeaponList(new HighCaliberWeaponBuilder());
                
            }
            else
            {
                weapons = director.CreateWeaponList(new LowCaliberWeaponBuilder());
            }

            richTextBoxInfo.Text = DescribeWeapons(weapons);
        }

        /// <summary>
        /// Формирует строку для описания всех объектов в списке оружий
        /// </summary>
        /// <param name="sender">отправитель события</param>
        /// <param name="e">аргументы события</param>
        private string DescribeWeapons(List<Weapon> weapons)
        {
            string result = string.Empty;
            foreach (var item in weapons)
            {
                result += item.ToString() + "\n";
            }

            return result;
        }
    }
}
