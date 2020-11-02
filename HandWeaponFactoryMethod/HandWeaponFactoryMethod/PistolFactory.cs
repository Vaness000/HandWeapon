using HandWeapon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandWeaponFactroryMethod
{
    /// <summary>
    /// Фабрика пистолетов
    /// </summary>
    public class PistolFactory : Factrory
    {
        /// <summary>
        /// Создание пистолетов
        /// </summary>
        /// <returns>Новый пистолет</returns>
        public override Weapon CreateWeapon()
        {
            return new Pistol(ViewWeapon.Pistol, 10, 200, 13, 13, TypePistol.Semiautomatic, TriggerMechanism.Percussion);
        }

        /// <summary>
        /// Переопределение метода ToString
        /// </summary>
        /// <returns>Название фабрики</returns>
        public override string ToString()
        {
            return "Фабрика пистолетов";
        }
    }
}
