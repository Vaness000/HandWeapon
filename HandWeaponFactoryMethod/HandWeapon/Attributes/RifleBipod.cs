using System;
using System.Collections.Generic;
using System.Text;

namespace HandWeapon.Atributes
{
    /// <summary>
    /// сошки снайперской винтовки
    /// </summary>
    public class RifleBipod ///сошки для снайперки
    {
        /// <summary>
        /// высота сошек
        /// </summary>
        private int _bipodHeight;
        /// <summary>
        /// коэффициент амортизации
        /// </summary>
        private double _depreciationСoefficient;

        /// <summary>
        /// высота сошек
        /// </summary>
        public int BipodHeight
        {
            get
            {
                return _bipodHeight;
            }
            set
            {
                _bipodHeight = value;
            }
        }

        public double DepreciationCoefficient
        {
            get
            {
                return _depreciationСoefficient;
            }
            set
            {
                _depreciationСoefficient = value;
            }
        }

        /// <summary>
        /// конструктор сошек
        /// </summary>
        /// <param name="parBipodHeight">высота сошек</param>
        /// <param name="parDepricationCoefficient">коэффициент амортизации</param>
        public RifleBipod(int parBipodHeight, double parDepricationCoefficient)
        {
            _bipodHeight = parBipodHeight;
            _depreciationСoefficient = parDepricationCoefficient;
        }
    }
}
