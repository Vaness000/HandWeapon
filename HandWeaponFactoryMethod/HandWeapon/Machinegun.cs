using HandWeapon.Atributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace HandWeapon
{
    /// <summary>
    /// автоматическое оружие
    /// </summary>
    public class Machinegun : Weapon
    {
        /// <summary>
        /// автоматический затвор
        /// </summary>
        private AutomaticShutter _shutter;

        /// <summary>
        /// прототип пулемета
        /// </summary>
        private static Machinegun _prototype = new Machinegun();

        /// <summary>
        /// Экземпляр объекта пулемет
        /// </summary>
        private static Machinegun _instance = null;

        /// <summary>
        /// Свойство отвечающее за прототип пулемета
        /// </summary>
        public static Machinegun Prototype
        {
            get { return _prototype; }
            set { _prototype = value; }
        }
        
        /// <summary>
        /// автоматический затвор
        /// </summary>
        public AutomaticShutter Shutter
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
        /// конструктор автоматического оружия
        /// </summary>
        /// <param name="parViewWeapon">вид оружия</param>
        /// <param name="parCaliberWeapon">калибр</param>
        /// <param name="parShootRange">дистанция выстрела</param>
        /// <param name="parCartridges">кол-во патрон</param>
        /// <param name="parCurrentCartridges">текущее кол-во патрон</param>
        /// <param name="parAutomaticShutter">автоматический затвор</param>
        public Machinegun(ViewWeapon parViewWeapon, double parCaliberWeapon, int parShootRange, int parCartridges, 
            int parCurrentCartridges, AutomaticShutter parAutomaticShutter) :
            base(parViewWeapon,parCaliberWeapon,parShootRange,parCartridges,parCurrentCartridges)
        {
            _shutter = parAutomaticShutter;
        }

        /// <summary>
        /// Конструктор без параметров для реализации шаблона прототип
        /// </summary>
        public Machinegun() : base(ViewWeapon.Machinegun)
        {
            base.AddPrototype(this);
        }

        /// <summary>
        /// отстрел определённого кол-ва патрон
        /// </summary>
        /// <param name="parCountShots"></param>
        public void ShootingTurn(int parCountShots)
        {
            for (int i = 1; i == parCountShots; i++)
            {
                if(i > Cartridges)
                {
                    break;
                }
                Shoot();
            }
        }

        /// <summary>
        /// метод отстрела всех патронов
        /// </summary>
        public void ShootingClamp()
        {
            int cart = CurrrentCartriges;
            if (CurrrentCartriges == 0)
            {
                Rechardge();
            }
            for (int i = 1; i == cart; i++)
            {
                Shoot();
            }
        }

        /// <summary>
        /// переопределйнный toString
        /// </summary>
        /// <returns>Информация об автомате</returns>
        public override string ToString()
        {
            return "Это автоматическое оружие со скоростью стрельбы " + Shutter.ShootsInMinute +
                "и временем непрерывной работы " + Shutter.MaxWorkTime + "кол-во патронов в магазине " + Cartridges;
        }

        /// <summary>
        /// Метод по получению экземпляра объекта пулемет
        /// </summary>
        /// <returns>Экземпляр объекта пулемет</returns>
        public static Machinegun GetInstance()
        {
            if (_instance == null)
                _instance = new Machinegun();
            return _instance;
        }

        /// <summary>
        /// Клонирует снайперскую винтовку
        /// </summary>
        /// <returns>Клон текущего объекта</returns>
        public override Weapon Clone()
        {
            return new Machinegun();
        }
    }
}
