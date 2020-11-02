using HandWeapon;
using System;
using System.Collections.Generic;
using System.Text;

namespace HandWeaponPrototype
{
    /// <summary>
    /// Фабрика прототипов
    /// </summary>
    public class PrototypeFactory
    {
        private static Pistol _pistol = null;
        private static SniperRifle _sniperRifle = null;
        private static Machinegun _machinegun = null;
        private static Weapon _weapon = null;

        /// <summary>
        /// Создает фабрику прототипов
        /// </summary>
        /// <param name="pistol">пистолет</param>
        /// <param name="sniperRifle">снайперская винтовка</param>
        /// <param name="machinegun">пулемет</param>
        public PrototypeFactory(Pistol pistol, SniperRifle sniperRifle, Machinegun machinegun)
        {
            _pistol = pistol;
            _machinegun = machinegun;
            _sniperRifle = sniperRifle;
        }

        /// <summary>
        /// создает пистолет
        /// </summary>
        /// <returns>пистолет</returns>
        private Pistol CreatePistol()
        {
            return (Pistol)_pistol.Clone();
        }

        /// <summary>
        /// создает снайперскую винтовку
        /// </summary>
        /// <returns>снайперская винтовка</returns>
        private Weapon CreateSniperRifle()
        {
            return (SniperRifle)_sniperRifle.Clone();
        }

        /// <summary>
        /// создает пулемет
        /// </summary>
        /// <returns>пулемет</returns>
        private Weapon CreateMachinegun()
        {
            return (Machinegun)_machinegun.Clone();
        }

        public Weapon CreateWeapon(ViewWeapon viewWeapon)
        {
            return Weapon.CreateWeapon(viewWeapon);
            //switch (viewWeapon)
            //{
            //    case ViewWeapon.Pistol:
            //        return CreatePistol();
            //    case ViewWeapon.Machinegun:
            //        return CreateMachinegun();
            //    case ViewWeapon.SniperRifle:
            //        return CreateSniperRifle();
            //    default:
            //        return null;
            //}
        }
    }
}
