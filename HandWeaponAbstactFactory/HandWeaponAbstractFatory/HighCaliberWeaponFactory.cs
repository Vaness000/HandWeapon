using HandWeapon;

namespace HandWeaponAbstractFactory
{
    /// <summary>
    /// Фабрика-наследник крупнокалиберных оружий
    /// Условно считаем крупнокалиберным оружием автомат, пистолет, снайперскую винтовку
    /// </summary>
    public class HighCaliberWeaponFactory : WeaponFactory
    {
        /// <summary>
        /// Переопределние родительского метода по созданию нового автомата
        /// </summary>
        /// <returns>Новый крупнокалиберный автомат с заданными характеристиками</returns>
        public override Machinegun CreateMachineGun()
        {
            return new Machinegun(ViewWeapon.Machinegun, 12, 600, 30, 30, new HandWeapon.Atributes.AutomaticShutter(600, 15));
        }

        /// <summary>
        /// Переопределние родительского метода по созданию нового пистолета
        /// </summary>
        /// <returns>Новый крупнокалиберный пистолет с заданными характеристиками</returns>
        public override Pistol CreatePistol()
        {
            return new Pistol(ViewWeapon.Pistol, 10, 200, 13, 13, TypePistol.Semiautomatic, TriggerMechanism.Percussion);
        }

        /// <summary>
        /// Переопределние родительского метода по созданию новой снайперской винтовки
        /// </summary>
        /// <returns>Новая крупнокалиберная снайперская винтовка с заданными характеристиками</returns>
        public override SniperRifle CreateSniperRifle()
        {
            return new SniperRifle(ViewWeapon.SniperRifle, 20, 1500, 10, 10, new HandWeapon.Atributes.LongitudinallySlidingShutter(4),
                 new HandWeapon.Atributes.RifleBipod(20, 0.32), new HandWeapon.Atributes.OpticalSight(20, 32));
        }

        /// <summary>
        /// Переопределение метода ToString
        /// </summary>
        /// <returns>Название фабрики</returns>
        public override string ToString()
        {
            return "Это фабрика крупнокалиберного оружия";
        }
    }
}
