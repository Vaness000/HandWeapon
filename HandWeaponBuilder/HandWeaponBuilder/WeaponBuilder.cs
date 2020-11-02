using System;
using System.Collections.Generic;
using System.Text;
using HandWeapon;

namespace HandWeaponBuilder
{
    /// <summary>
    /// Абстрактный класс, описывающий шаблон строитель для оружия
    /// </summary>
    public abstract class WeaponBuilder
    {
        /// <summary>
        /// список оружия
        /// </summary>
        private List<Weapon> _weapons;

        /// <summary>
        /// Создает список оружия
        /// </summary>
        public void CreateWeapons()
        {
            _weapons = new List<Weapon>();
        }

        /// <summary>
        /// Добавляет пистолет в список
        /// </summary>
        public abstract void AddPistol();
        /// <summary>
        /// Добавляет в список снайперсую винтовку
        /// </summary>
        public abstract void AddSniperRifle();
        /// <summary>
        /// Добавляет в список пулемет
        /// </summary>
        public abstract void AddMachinegun();
        /// <summary>
        /// Свойство, возвращающее список оружия
        /// </summary>
        public List<Weapon> Weapons { get { return _weapons; } }
    }
}
