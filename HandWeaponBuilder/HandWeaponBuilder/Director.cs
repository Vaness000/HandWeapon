using HandWeapon;
using System;
using System.Collections.Generic;
using System.Text;

namespace HandWeaponBuilder
{
    /// <summary>
    /// Обрабатывает клиентские запросы на создание объектов
    /// </summary>
    class Director
    {
        /// <summary>
        /// Создает список оружия по заданному параметру оружия
        /// </summary>
        /// <param name="parWeaponBuilder">Тип строителя</param>
        /// <returns></returns>
        public List<Weapon> CreateWeaponList(WeaponBuilder parWeaponBuilder)
        {
            parWeaponBuilder.CreateWeapons();
            parWeaponBuilder.AddMachinegun();
            parWeaponBuilder.AddPistol();
            parWeaponBuilder.AddSniperRifle();
            return parWeaponBuilder.Weapons;
        }
    }
}
