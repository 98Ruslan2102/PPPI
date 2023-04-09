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
        /// <summary>
        /// Переменная Вид анимации
        /// </summary>
        string typeAnimation;
        /// <summary>
        /// Переменная Формат сохранения
        /// </summary>
        string FormatSave;
        /// <summary>
        /// Конструктор Animation
        /// </summary>
        /// <param name="_typeAnimation"> Вид анимации</param>
        /// /// <param name="_FormatSave"> Вид анимации</param>
        public Animation(string _typeAnimation, string _FormatSave)
        {
            typeAnimation = _typeAnimation;
            FormatSave = _FormatSave;
        }

        /// <summary>
        /// Метод расчитывающий длительность анимации
        /// </summary>
        /// <param name="_start"> Начало анимации</param>
        /// <param name="_finish"> Конец анимации</param>
        public void TimeAnimation(double _start, double _finish)
        {

        }

        /// <summary>
        /// Рендеринг
        /// </summary>
        /// <param name="_FormatSave">Формат сохранения</param>
        public void Rendering(string _FormatSave)
        {

        }
    }
}
