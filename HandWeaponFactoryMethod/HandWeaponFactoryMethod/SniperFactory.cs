using HandWeapon;
using HandWeapon.Atributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandWeaponFactroryMethod
{
    /// <summary>
    /// Фабрика снайперскиъ винтовок
    /// </summary>
    public class SniperFactory : Factrory
    {
        /// <summary>
        /// создание снайперских винтовок
        /// </summary>
        /// <returns>новая снайперская винтовка</returns>
        public override Weapon CreateWeapon()
        {
            return new SniperRifle(ViewWeapon.SniperRifle, 50, 1000, 5, 5, new LongitudinallySlidingShutter(1),
                        new RifleBipod(40, 0.1), new OpticalSight(15, 2));
        }

        /// <summary>
        /// Переопределение метода ToString
        /// </summary>
        /// <returns>Название фабрики</returns>
        public override string ToString()
        {
            return "Фабрика снайперских винтовок";
        }
    }
}
