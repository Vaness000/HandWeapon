using HandWeapon;

namespace HandWeaponAbstractFactory
{
    /// <summary>
    ///  Базовый абстрактный класс для создания каждого типа оружия
    /// </summary>
    public abstract class WeaponFactory
    {
        /// <summary>
        ///  Создание нового автомата, абстрактный метод, переопределён в наследниках
        /// </summary>
        /// <returns>Новый автомат</returns>
        public abstract Machinegun CreateMachineGun();

        /// <summary>
        /// Создание новой снайперской винтовки, абстрактный метод, переопределён в наследниках
        /// </summary>
        /// <returns>Новая снайперская винтовка</returns>
        public abstract SniperRifle CreateSniperRifle();

        /// <summary>
        /// Создание нового пистолета, абстрактный метод, переопределён в наследниках
        /// </summary>
        /// <returns>Новый пистолет</returns>
        public abstract Pistol CreatePistol();
    }
}
