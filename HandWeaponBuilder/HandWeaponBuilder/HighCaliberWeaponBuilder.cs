using HandWeapon;
using System;
using System.Collections.Generic;
using System.Text;

namespace HandWeaponBuilder
{
    /// <summary>
    /// Добавляет в список крупнокалиберное оружие
    /// </summary>
    class HighCaliberWeaponBuilder : WeaponBuilder
    {
        /// <summary>
        /// Добавляет в список крупнокалиберный пулемет
        /// </summary>
        public override void AddMachinegun()
        {
            Weapons.Add(new Machinegun(ViewWeapon.Machinegun, 10, 800, 20, 20, new HandWeapon.Atributes.AutomaticShutter(500, 1000)));
        }

        /// <summary>
        /// Добавляет в список крупнокалиберный пистолет
        /// </summary>
        public override void AddPistol()
        {
            Weapons.Add(new Pistol(ViewWeapon.Pistol, 50, 500, 8, 8, TypePistol.Semiautomatic, TriggerMechanism.Percussion));
        }

        /// <summary>
        /// Добавляет в список крупноколиберную снайперскуб винтовку
        /// </summary>
        public override void AddSniperRifle()
        {
            Weapons.Add(new SniperRifle(ViewWeapon.SniperRifle, 50, 2000, 10, 10, new HandWeapon.Atributes.LongitudinallySlidingShutter(2),
                new HandWeapon.Atributes.RifleBipod(40, 0.2), new HandWeapon.Atributes.OpticalSight(20, 1)));
        }

        public override string ToString()
        {
            return "Строитель крупнокалиберного оружия";
        }
    }
}
