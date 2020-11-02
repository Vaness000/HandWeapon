using HandWeapon;
using HandWeapon.Atributes;
using System;
using System.Windows.Forms;

namespace HandWeaponPrototype
{
    public partial class Form1 : Form
    {
        //переменные для работы класса
        Weapon weapon;
        PrototypeFactory _prototypeFactory;

        //конструктор
        public Form1()
        {
            InitializeComponent();
            weaponTypesCB.Items.Add(ViewWeapon.Machinegun);
            weaponTypesCB.Items.Add(ViewWeapon.SniperRifle);
            weaponTypesCB.Items.Add(ViewWeapon.Pistol);
        }

        //создание прототипов по нажатию кнопки
        private void prototypeFactoryButton_Click(object sender, EventArgs e)
        {
            CreatePrototypeFactory();
            weapon = CreateWeapon((ViewWeapon)weaponTypesCB.SelectedItem);
            prototypeFactoryTB.Text = weapon.ToString();
        }

        /// <summary>
        /// Создает фабрику прототипов
        /// </summary>
        private void CreatePrototypeFactory()
        {
            try
            {
                int countBullets = int.Parse(countBulletsTB.Text);
                int shoots = int.Parse(shootsPMTB.Text);
                double workTime = double.Parse(workTimeTB.Text);
                double caliber = double.Parse(caliberTB.Text);
                int sight = int.Parse(sightTB.Text);
                int reload = int.Parse(reload1BulletTB.Text);

                Pistol pistol = new Pistol();
                pistol.TriggerMechanism = TriggerMechanism.Percussion;
                pistol.TypePistol = TypePistol.Semiautomatic;

                Machinegun machinegun = new Machinegun();
                machinegun.Cartridges = countBullets;
                machinegun.Shutter = new AutomaticShutter(shoots, workTime);

                SniperRifle sniperRifle = new SniperRifle();
                sniperRifle.CaliberWeapon = caliber;
                sniperRifle.OpticalSight = new OpticalSight(sight, 1);
                sniperRifle.Shutter = new LongitudinallySlidingShutter(reload);

                _prototypeFactory = new PrototypeFactory(pistol, sniperRifle, machinegun);
            }
            catch
            {
                MessageBox.Show("Фабрика прототипов не была создана из-за ошибочно введенных данных");
            }
        }

        /// <summary>
        /// Создает оружие в зависимости от типа
        /// </summary>
        /// <param name="viewWeapon">Тип оружия</param>
        /// <returns></returns>
        private Weapon CreateWeapon(ViewWeapon viewWeapon)
        {
            return _prototypeFactory.CreateWeapon(viewWeapon);
        }

        //Создает прототип на основе обобщенного конструктора
        private void commonConstructorButton_Click(object sender, EventArgs e)
        {
            weapon = Weapon.NewWeapon((ViewWeapon)weaponTypesCB.SelectedIndex);
            commonConstructorTB.Text = weapon.ToString();
        }
    }
}
