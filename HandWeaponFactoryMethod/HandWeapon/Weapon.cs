using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace HandWeapon{

    /// <summary>
    /// оружие
    /// </summary>
    public abstract class Weapon 
    {
        /// <summary>
        /// вид оружия
        /// </summary>
        private ViewWeapon _viewWeapon;

        /// <summary>
        /// калибр оружия
        /// </summary>
        private double _caliberWeapon;

        /// <summary>
        /// дальность выстрела
        /// </summary>
        private int _shotRange;

        /// <summary>
        /// максимальное кол-во патрон в магазине
        /// </summary>
        private int _cartridges;

        /// <summary>
        /// текущее кол-во патрон
        /// </summary>
        private int _currentCartridges;

        /// <summary>
        /// текущее кол-во патронов
        /// </summary>
        public int CurrrentCartriges
        {
            get
            {
                return _currentCartridges;
            }
            set
            {
                _currentCartridges = value;
            }
        }

        /// <summary>
        /// вид оружия
        /// </summary>
        public ViewWeapon ViewWeapon
        {
            get 
            {
                return _viewWeapon;
            }
            set
            {
                _viewWeapon = value;
            }
        }

        /// <summary>
        /// калибр
        /// </summary>
        public double CaliberWeapon
        {
            get
            {
                return _caliberWeapon;
            }
            set
            {
                _caliberWeapon = value;
            }
        }

        /// <summary>
        /// дистанция выстрела
        /// </summary>
        public int ShootRange
        {
            get
            {
                return _shotRange;
            }
            set
            {
                _shotRange = value;
            }
        }

        /// <summary>
        /// кол-во патрон вмещаемое в магазин
        /// </summary>
        public int Cartridges
        {
            get
            {
                return _cartridges;
            }
            set
            {
                _cartridges = value;
            }
        }
        /// <summary>
        /// Хэштаблица для шаблона прототип
        /// </summary>
        private static Hashtable _registry = new Hashtable();
        /// <summary>
        /// Конструктор создающий объект по выбранному типу оружия
        /// </summary>
        /// <param name="parWeaponType">вид оружия</param>
        protected Weapon(ViewWeapon parWeaponType)
        {
            _viewWeapon = parWeaponType;
        }
        
        /// <summary>
        /// Копирует выбранное оружее
        /// </summary>
        /// <returns>объект оружия</returns>
        public abstract Weapon Clone();
        
        /// <summary>
        /// Создает оружее на основе выбранного типа оружия
        /// </summary>
        /// <param name="parViewWeapon">тип оружия</param>
        /// <returns></returns>
        public static Weapon NewWeapon(ViewWeapon parViewWeapon)
        {
            Weapon weapon = null;
            if (_registry.Contains(parViewWeapon))
            {
                weapon = (Weapon)_registry[parViewWeapon];
                return weapon.Clone();
            }

            return weapon;
        }

        /// <summary>
        /// Добавляет прототип в хэш-таблицу
        /// </summary>
        /// <param name="parWeapon">объект оружия</param>
        protected void AddPrototype(Weapon parWeapon)
        {
            _registry[parWeapon._viewWeapon] = parWeapon;
        }

        /// <summary>
        /// Удаляет объект из хэш таблицы по выбранному типу
        /// </summary>
        /// <param name="parViewWeapon">тип оружия</param>
        protected void RemovePrototype(ViewWeapon parViewWeapon)
        {
            _registry.Remove(parViewWeapon);
        }



        /// <summary>
        /// отстрел одного патрона
        /// </summary>
        public void Shoot()
        {
            Console.WriteLine("BANG!");
            CurrrentCartriges--;
        }        
        /// <summary>
        /// перезарядка
        /// </summary>
        public void Rechardge()
        {
            CurrrentCartriges = Cartridges;
        }

        /// <summary>
        /// конструктор орудия
        /// </summary>
        /// <param name="parViewWeapon">вид оружия</param>
        /// <param name="parCaliberWeapon">калибр оружия</param>
        /// <param name="parShootRange">дальность</param>
        /// <param name="parCartridges">кол-во патронов</param>
        /// <param name="parCurrentCartridges">текущее кол-во патронов</param>
        public Weapon(ViewWeapon parViewWeapon, double parCaliberWeapon, int parShootRange, int parCartridges, int parCurrentCartridges)
        {
            try
            {
                if (parCaliberWeapon < 0)
                {
                    throw new Exception("Калибр не может быть меньше нуля");
                }

                if (parShootRange < 0)
                {
                    Console.WriteLine("Дальность выстрела не может быть меньше нуля");
                }

                if (parCartridges < 0)
                {
                    Console.WriteLine("Кол-во патрон в патроннике не может быть меньше нуля");
                }
                if (parCurrentCartridges < 0)
                {
                    Console.WriteLine("Кол-во патрон в патроннике не может быть меньше нуля");
                }
                else
                {
                    ViewWeapon = parViewWeapon;
                    CaliberWeapon = parCaliberWeapon;
                    ShootRange = parShootRange;
                    Cartridges = parCartridges;
                    CurrrentCartriges = parCurrentCartridges;
                }                
            }
            catch (Exception wrongnumber)
            {
                Console.WriteLine(wrongnumber.Message);

            }

        }

        public static Weapon CreateWeapon(ViewWeapon weaponType)
        {
            Weapon weapon = null;

            switch (weaponType)
            {
                case ViewWeapon.Machinegun:
                    weapon = new Machinegun(weaponType, 50, 200, 100, 100, new Atributes.AutomaticShutter(1000, 60));
                    break;
                case ViewWeapon.Pistol:
                    weapon = new Pistol(weaponType, 9, 100, 10, 10, TypePistol.Semiautomatic, TriggerMechanism.Trigger);
                    break;
                case ViewWeapon.SniperRifle:
                    weapon = new SniperRifle(weaponType, 50, 1000, 5, 5, new Atributes.LongitudinallySlidingShutter(1),
                        new Atributes.RifleBipod(40, 0.1), new Atributes.OpticalSight(15, 2));
                    break;
            }

            return weapon;
        }
    }

}
