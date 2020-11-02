using System;
using System.Collections.Generic;
using System.Text;

namespace HandWeapon
{
    /// <summary>
    /// пистолет
    /// </summary>
    public class Pistol : Weapon
    {
        /// <summary>
        /// тип пистолета
        /// </summary>
        private TypePistol _typePistol;
        /// <summary>
        /// ударно-спусковой механизм
        /// </summary>
        private TriggerMechanism _triggerMechanism;

        /// <summary>
        /// Прототип пистолета
        /// </summary>
        private static Pistol _prototype = new Pistol();

        /// <summary>
        /// Экземпляр объекта
        /// </summary>
        private static Pistol _instance = null;

        /// <summary>
        /// Свойство отвечающее за прототип пистолета
        /// </summary>
        public static Pistol Prototype
        {
            get { return _prototype; }
            set { _prototype = value; }
        }

        /// <summary>
        /// тип пистолета
        /// </summary>
        public TypePistol TypePistol
        {
            get
            {
                return _typePistol;
            }
            set
            {
                _typePistol = value;
            }
        }

        /// <summary>
        /// ударно-спусковой механизм
        /// </summary>
        public TriggerMechanism TriggerMechanism
        {
            get
            {
                return _triggerMechanism;
            }
            set
            {
                _triggerMechanism = value;
            }
        }

        /// <summary>
        /// конструктор пистолета
        /// </summary>
        /// <param name="parViewWeapon">тип оружия</param>
        /// <param name="parCaliberWeapon">калибр оружия</param>
        /// <param name="parShootRange">дистанция выстрела</param>
        /// <param name="parCartridges">кол-во патронов</param>
        /// <param name="parCurrentCartridges">текущее кол-во патронов</param>
        /// <param name="parTypePistol">тип пистолета</param>
        /// <param name="parTriggerMechanism">ударно-спуковой механизм</param>
        public Pistol(ViewWeapon parViewWeapon, double parCaliberWeapon, int parShootRange, int parCartridges, 
            int parCurrentCartridges, TypePistol parTypePistol, TriggerMechanism parTriggerMechanism) 
            : base(parViewWeapon, parCaliberWeapon, parShootRange , parCartridges, parCurrentCartridges)
        {
            _triggerMechanism = parTriggerMechanism;
            _typePistol = parTypePistol;
        }

        /// <summary>
        /// Конструктор без параметров для реализации шаблона прототип
        /// </summary>
        public Pistol() : base(ViewWeapon.Pistol)
        {
            base.AddPrototype(this);
        }

        /// <summary>
        /// Метод по получению экземпляра объекта пистолет
        /// </summary>
        /// <returns>Экземпляр объекта пистолет</returns>
        public static Pistol GetInstance()
        {
            if (_instance == null)
                _instance = new Pistol();
            return _instance;
        }

        /// <summary>
        /// стрельба из пистолета
        /// </summary>
        public void ShootPistol()
        {
            if (TypePistol == TypePistol.Automatic)
            {
                for (int i = 1; i < Cartridges; i++)
                {
                    if (CurrrentCartriges == 0)
                    {
                        Console.WriteLine("Магазин закончился нужна перезарядка");
                        break;
                    }
                    Shoot();
                }
            }
            else
            {
                Shoot();
            }

        }

        /// <summary>
        /// переопределённый toString
        /// </summary>
        /// <returns>Информация о пистолете</returns>
        public override string ToString()
        {
            if(TypePistol == TypePistol.Semiautomatic)
            {
                if(TriggerMechanism == TriggerMechanism.Percussion)
                {
                    return "Это полуавтоматический пистолет с курковым ударно-спусковым сеханизмом";
                }
                else
                {
                    return "Это полуавтоматический пистолет с ударниковым ударно-спусковым механизмом";
                }
            }
            else
            {
                if (TriggerMechanism == TriggerMechanism.Percussion)
                {
                    return "Это автоматический пистолет с курковым ударно-спусковым механизмом";
                }
                else
                {
                    return "Это автоматический пистлет с ударниковым ударно-спусковым механизмом";
                }
            }
        }

        /// <summary>
        /// Клонирует пистолет
        /// </summary>
        /// <returns>Клон текущего объекта</returns>
        public override Weapon Clone()
        {
            return new Pistol();
        }
    }
}
