using System;
using System.Collections.Generic;
using System.Text;

namespace HandWeapon.Atributes
{
    /// <summary>
    /// оптический прицел
    /// </summary>
    public class OpticalSight
    {
        /// <summary>
        /// максимальное увеличение
        /// </summary>
        private int _maxZoom;
        /// <summary>
        /// просветлённость оптики
        /// </summary>
        private int _opticEnlightened;

        /// <summary>
        /// максимально увеличение
        /// </summary>
        public int MaxZoom
        {
            get
            {
                return _maxZoom;
            }
            set
            {
                _maxZoom = value;
            }
        }
        /// <summary>
        /// просветлённост оптики
        /// </summary>
        public int OpticalEnlightened
        {
            get
            {
                return _opticEnlightened;
            }
            set
            {
                _opticEnlightened = value;
            }
        }
        /// <summary>
        /// конструктор
        /// </summary>
        /// <param name="parMaxZoom">максимальное увеличеие</param>
        /// <param name="parOpticalEnlightened">просветлённость оптики</param>
        public OpticalSight(int parMaxZoom, int parOpticalEnlightened)
        {
            _maxZoom = parMaxZoom;
            _opticEnlightened = parOpticalEnlightened;
        }
    }
}
