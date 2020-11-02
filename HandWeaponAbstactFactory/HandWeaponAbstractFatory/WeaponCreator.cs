using HandWeapon;

namespace HandWeaponAbstractFactory
{
    /// <summary>
    /// Класс, создающий оружие, используя переданную фабрику классов
    /// </summary>
    public class WeaponCreator
    {
        /// <summary>
        /// Переданная фабрика классов оружия, которую нужно создать
        /// </summary>
        private WeaponFactory _weaponFactory;

        /// <summary>
        /// Массив взаимосвязанных объектов, каждый из которых представляет собой отдельное оружие
        /// </summary>
        private Weapon[] _weapons;

        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="parWeaponFactory">Фабрика классов оружия, которую нужно создать</param>
        public WeaponCreator(WeaponFactory parWeaponFactory)
        {
            _weaponFactory = parWeaponFactory;
        }

        /// <summary>
        /// Метод по созданию оружия с использованием переданной фабрики классов
        /// </summary>
        /// <returns>Массив взаимосвязанных объектов, каждый из которых является отдельным оружием</returns>
        public Weapon[] CreateWeapons()
        {
            _weapons = new Weapon[3];
            _weapons[0] = _weaponFactory.CreateMachineGun();
            _weapons[1] = _weaponFactory.CreatePistol();
            _weapons[2] = _weaponFactory.CreateSniperRifle();
            return _weapons;
        }
    }
}
