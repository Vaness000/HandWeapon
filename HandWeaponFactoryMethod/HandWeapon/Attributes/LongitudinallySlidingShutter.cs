using System;
using System.Collections.Generic;
using System.Text;

namespace HandWeapon.Atributes
{
    /// <summary>
    /// продольно-скользящий затвор
    /// </summary>
    public class LongitudinallySlidingShutter
    {
        /// <summary>
        /// время перезарядки одного патрона
        /// </summary>
        private double _timeToReloadOneCartridge;

        /// <summary>
        /// время перезарядки одного патрона
        /// </summary>
        public double TimeToReloadOneCartridge
        {
            get
            {
                return _timeToReloadOneCartridge;
            }
            set
            {
                _timeToReloadOneCartridge = value;
            }
        }

        /// <summary>
        /// конструктор
        /// </summary>
        /// <param name="parTimeToReloadOneCartridge">время перезарядки одного патрона</param>
        public LongitudinallySlidingShutter(double parTimeToReloadOneCartridge)
        {
            TimeToReloadOneCartridge = parTimeToReloadOneCartridge;
        }
    }
}
