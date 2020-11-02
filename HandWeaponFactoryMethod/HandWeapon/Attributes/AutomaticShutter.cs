using System;
using System.Collections.Generic;
using System.Text;

namespace HandWeapon.Atributes
{
    /// <summary>
    /// автоматический затвор
    /// </summary>
    public class AutomaticShutter
    {
        /// <summary>
        /// максимальное время непрерывной работы
        /// </summary>
        private double _maxWorkTime;
        /// <summary>
        /// выстрелов в минуту
        /// </summary>
        private int _shootsInMinute;

        /// <summary>
        /// выстрелы в минуту
        /// </summary>
        public int ShootsInMinute
        {
            get
            {
                return _shootsInMinute;
            }
            set
            {
                _shootsInMinute = value;
            }
        }

        /// <summary>
        /// максимальное время работы
        /// </summary>
        public double MaxWorkTime
        {
            get
            {
                return _maxWorkTime;
            }
            set
            {
                _maxWorkTime = value;
            }
        }

        /// <summary>
        /// конструктор автоматического затвора
        /// </summary>
        /// <param name="parShootsInMinute">выстрелов в минуту</param>
        /// <param name="parMaxWorkTime">максимальное время работы</param>
        public AutomaticShutter(int parShootsInMinute, double parMaxWorkTime)
        {
            ShootsInMinute = parShootsInMinute;
            MaxWorkTime = parMaxWorkTime;
        }
    }
}
