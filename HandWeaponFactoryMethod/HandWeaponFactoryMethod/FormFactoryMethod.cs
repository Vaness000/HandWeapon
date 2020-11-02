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

namespace HandWeaponFactroryMethod
{
    /// <summary>
    /// Описывает форму приложения
    /// </summary>
    public partial class FormFactroryMethod : Form
    {
        /// <summary>
        /// Инициализирует компоненты формы
        /// </summary>
        public FormFactroryMethod()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Изменяет видимость элементов в зависимости от выбранного метода создания объекта
        /// </summary>
        /// <param name="sender">отправитель события</param>
        /// <param name="e">аргументы события</param>
        private void comboBoxSelectFactoryMethod_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBoxSelectFactoryMethod.SelectedIndex == 0)
            {
                comboBoxSelectTypeWeapon.Visible = false;
                comboBoxSelectFacory.Visible = true;
                factoryLabel.Visible = true;
                weaponLabel.Visible = false;
            }
            if(comboBoxSelectFactoryMethod.SelectedIndex == 1)
            {
                comboBoxSelectFacory.Visible = false;
                comboBoxSelectTypeWeapon.Visible = true;
                factoryLabel.Visible = false;
                weaponLabel.Visible = true;
            }
        }

        /// <summary>
        /// Создает объект и выводит информацию о нем в зависимости от выбранного вида оружия с помощью классического метода
        /// </summary>
        /// <param name="sender">отправитель события</param>
        /// <param name="e">аргументы события</param>
        private void comboBoxSelectFacory_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBoxSelectFacory.SelectedIndex == 0)
            {
                Factrory factrory = new MachinegunFactory();
                Weapon weapon = factrory.CreateWeapon();
                textBoxInfo.Clear();
                textBoxInfo.Text = weapon.ToString();
            }
            if(comboBoxSelectFacory.SelectedIndex == 1)
            {
                Factrory factrory = new SniperFactory();
                Weapon weapon = factrory.CreateWeapon();
                textBoxInfo.Clear();
                textBoxInfo.Text = weapon.ToString();
            }
            if(comboBoxSelectFacory.SelectedIndex == 2)
            {
                Factrory factrory = new PistolFactory();
                Weapon weapon = factrory.CreateWeapon();
                textBoxInfo.Clear();
                textBoxInfo.Text = weapon.ToString();
            }
        }

        /// <summary>
        /// Создает объект и выводит информацию о нем в зависимости от выбранного вида оружия с помощью обобщенного конструктора
        /// </summary>
        /// <param name="sender">отправитель события</param>
        /// <param name="e">аргументы события</param>
        private void comboBoxSelectTypeWeapon_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBoxSelectTypeWeapon.SelectedIndex == 0)
            {
                Weapon weapon = Weapon.CreateWeapon(ViewWeapon.Machinegun);
                textBoxInfo.Clear();
                textBoxInfo.Text = weapon.ToString();
            }
            if(comboBoxSelectTypeWeapon.SelectedIndex == 1)
            {
                Weapon weapon = Weapon.CreateWeapon(ViewWeapon.SniperRifle);
                textBoxInfo.Clear();
                textBoxInfo.Text = weapon.ToString();
            }
            if (comboBoxSelectTypeWeapon.SelectedIndex == 2)
            {
                Weapon weapon = Weapon.CreateWeapon(ViewWeapon.Pistol);
                textBoxInfo.Clear();
                textBoxInfo.Text = weapon.ToString();
            }
        }

        /// <summary>
        /// Задает видимость элементов в начале работы приложения
        /// </summary>
        /// <param name="sender">отправитель события</param>
        /// <param name="e">аргументы события</param>
        private void FormFactroryMethod_Load(object sender, EventArgs e)
        {
            comboBoxSelectFacory.Visible = false;
            comboBoxSelectTypeWeapon.Visible = false;
            factoryLabel.Visible = false;
            weaponLabel.Visible = false;
        }
    }
}
