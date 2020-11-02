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
    /// Фабрика автоматов
    /// </summary>
    public class MachinegunFactory : Factrory
    {
        /// <summary>
        /// Создание автоматов
        /// </summary>
        /// <returns>Новый автомат</returns>
        public override Weapon CreateWeapon()
        {
            return new Machinegun(ViewWeapon.Machinegun, 50, 200, 100, 100, new AutomaticShutter(1000, 60));
        }

        /// <summary>
        /// Переопределение метода ToString
        /// </summary>
        /// <returns>Название фабрики</returns>
        public override string ToString()
        {
            return "Фабрика автоматов";
        }
    }
}
