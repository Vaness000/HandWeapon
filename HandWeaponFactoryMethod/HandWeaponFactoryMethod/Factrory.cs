using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HandWeapon;

namespace HandWeaponFactroryMethod
{
    /// <summary>
    /// Абстрактная фабрика
    /// </summary>
    public abstract class Factrory
    {
        /// <summary>
        /// Создание оружия, общий абстрактный метод для классического фабричного метода
        /// </summary>
        /// <returns>Новое оружие</returns>
        public abstract Weapon CreateWeapon();
    }
}
