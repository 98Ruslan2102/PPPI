using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPPI_prog
{
    
    /// <summary>
    /// Создание класса Анимации
    /// </summary>
    class Animation
    {
        string typeAnimation;
        /// <summary>
        /// Конструктор Animation
        /// </summary>
        /// <param name="_typeAnimation"> Вид анимации</param>
        public Animation(string _typeAnimation)
        {
            typeAnimation = _typeAnimation;
        }
    }
}
