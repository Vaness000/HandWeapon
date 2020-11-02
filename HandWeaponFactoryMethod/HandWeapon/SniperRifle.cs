using HandWeapon.Atributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace HandWeapon
{
    /// <summary>
    /// снайперская винтовка
    /// </summary>
    public class SniperRifle : Weapon
    {
        /// <summary>
        /// продольно скользящий затвор
        /// </summary>
        private LongitudinallySlidingShutter _shutter;

        /// <summary>
        /// сошки снайперской винтовки
        /// </summary>
        private RifleBipod _bipod;

        /// <summary>
        /// оптический прицел
        /// </summary>
        private OpticalSight _opticalSight;

        /// <summary>
        /// Конструктор без параметров для реализации шаблона прототип
        /// </summary>

        /// <summary>
        /// прототип снайперской винтовки
        /// </summary>
        private static SniperRifle _prototype = new SniperRifle();

        /// <summary>
        /// Экземпляр объекта снайперская винтовка
        /// </summary>
        private static SniperRifle _instance = null;

        /// <summary>
        /// Свойство отвечающее за прототип снайперской винтовки
        /// </summary>
        public static SniperRifle Prototype
        {
            get { return _prototype; }
            set { _prototype = value; }
        }

        public SniperRifle() : base(ViewWeapon.SniperRifle)
        {
            base.AddPrototype(this);
        }

        /// <summary>
        /// конструктор снайперской винтовки
        /// </summary>
        /// <param name="parViewWeapon">вид оружия</param>
        /// <param name="parCaliberWeapon">калибр оружия</param>
        /// <param name="parShootRange">дистанция выстрела</param>
        /// <param name="parCartridges">кол-во патронов</param>
        /// <param name="parCurrentCartridges">текущее кол-во патронов</param>
        /// <param name="parShutter">затвор</param>
        /// <param name="parBipod">сошки</param>
        public SniperRifle(ViewWeapon parViewWeapon, double parCaliberWeapon, int parShootRange, int parCartridges, int parCurrentCartridges, 
            LongitudinallySlidingShutter parShutter, RifleBipod parBipod, OpticalSight parOpticalSight) :
            base(parViewWeapon, parCaliberWeapon, parShootRange, parCartridges, parCurrentCartridges)
        {
            _shutter = parShutter;
            _bipod = parBipod;
            _opticalSight = parOpticalSight;
        }

        /// <summary>
        /// продольноскользящий затвор
        /// </summary>
        public LongitudinallySlidingShutter Shutter
        {
            get
            {
                return _shutter;
            }
            set
            {
                _shutter = value;
            }
        }

        /// <summary>
        /// сошки снайперской винтовки
        /// </summary>
        public RifleBipod Bipod
        {
            get
            {
                return _bipod;
            }
            set
            {
                _bipod = value;
            }
        }

        /// <summary>
        /// оптический прицел
        /// </summary>
        public OpticalSight OpticalSight
        {
            get
            {
                return _opticalSight;
            }
            set
            {
                _opticalSight = value;
            }
        }

        /// <summary>
        /// Метод по получению экземпляра объекта руководитель по маркетингу
        /// </summary>
        /// <returns>Экземпляр объекта руководитель по маркетингу</returns>
        public static SniperRifle GetInstance()
        {
            if (_instance == null)
                _instance = new SniperRifle();
            return _instance;
        }

        /// <summary>
        /// Клонирует снайперскую винтовку
        /// </summary>
        /// <returns>Клон текущего объекта</returns>
        public override Weapon Clone()
        {
            return new SniperRifle();
        }

        /// <summary>
        /// переопределённый toString
        /// </summary>
        /// <returns>Информация о снайперской винтовке</returns>
        public override string ToString()
        {
            return "Это снайперская винтовка " + CaliberWeapon + " калибра с максимальным увеличением "
                + OpticalSight.MaxZoom + " и временем перезарядки " + Shutter.TimeToReloadOneCartridge;
        }
    }
}
