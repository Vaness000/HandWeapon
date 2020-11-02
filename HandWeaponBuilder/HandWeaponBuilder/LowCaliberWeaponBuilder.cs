using System;
using System.Collections.Generic;
using System.Text;
using HandWeapon;
using HandWeapon.Atributes;

namespace HandWeaponBuilder
{
    /// <summary>
    /// Добавляет в список ряд мелкокалиберного оружия
    /// </summary>
    class LowCaliberWeaponBuilder : WeaponBuilder
    {
        /// <summary>
        /// Добавляет в список мелкокалиберный пулемет
        /// </summary>
        public override void AddMachinegun()
        {
            Weapons.Add(new Machinegun(ViewWeapon.Machinegun, 7.62, 400, 30, 30, new AutomaticShutter(600, 1000)));
        }

        /// <summary>
        /// Добавляет в список мелкокалиберный пистолет
        /// </summary>
        public override void AddPistol()
        {
            Weapons.Add(new Pistol(ViewWeapon.Pistol, 9, 100, 10, 10, TypePistol.Semiautomatic, TriggerMechanism.Percussion));
        }

        /// <summary>
        /// Добавляет в список мелкокалиберную снайперскую винтовку
        /// </summary>
        public override void AddSniperRifle()
        {
            Weapons.Add(new SniperRifle(ViewWeapon.SniperRifle, 7.62, 1000, 15, 15, new LongitudinallySlidingShutter(1), 
                new RifleBipod(30, 0.1), new OpticalSight(10, 2)));
        }

        public override string ToString()
        {
            return "Строитель мелкокалиберного оружия";
        }
    }
}
