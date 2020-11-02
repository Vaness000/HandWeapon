using HandWeapon;

namespace HandWeaponAbstractFactory
{
    /// <summary>
    /// Фабрика-наследник мелкокалиберных оружий
    /// Условно считаем мелкокалиберным оружием автомат, пистолет, снайперскую винтовку
    /// </summary>
    public class LowCaliberWeaponFactrory : WeaponFactory
    {
        /// <summary>
        /// Переопределние родительского метода по созданию нового автомата
        /// </summary>
        /// <returns>Новый мелкокалиберный автомат с заданными характеристиками</returns>
        public override Machinegun CreateMachineGun()
        {
            return new Machinegun(ViewWeapon.Machinegun, 5, 200, 20, 20, new HandWeapon.Atributes.AutomaticShutter(700, 10));
        }

        /// <summary>
        /// Переопределние родительского метода по созданию нового пистолета
        /// </summary>
        /// <returns>Новый мелкокалиберный пистолет с заданными характеристиками</returns>
        public override Pistol CreatePistol()
        {
            return new Pistol(ViewWeapon.Pistol, 4, 60, 7, 7, TypePistol.Automatic, TriggerMechanism.Trigger);
        }

        /// <summary>
        /// Переопределние родительского метода по созданию новой снайперской винтовки
        /// </summary>
        /// <returns>Новая мелкокалиберная снайперская винтовка с заданными характеристиками</returns>
        public override SniperRifle CreateSniperRifle()
        {
            return new SniperRifle(ViewWeapon.SniperRifle, 10, 500, 7, 7,
                new HandWeapon.Atributes.LongitudinallySlidingShutter(4), new HandWeapon.Atributes.RifleBipod(10, 2), new HandWeapon.Atributes.OpticalSight(10, 2));
        }

        /// <summary>
        /// Переопределение метода ToString
        /// </summary>
        /// <returns>Название фабрики</returns>
        public override string ToString()
        {
            return "Это фабрика мелкокалиберного оружия";
        }
    }
}
