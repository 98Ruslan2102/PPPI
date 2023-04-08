using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPPI_prog
{


    /// <summary>
    /// Создание класса Shape(фигура)
    /// </summary>
    class Shape
    {
        double length;
        double width;
        double height;

        /// <summary>
        /// Конструктор Shape
        /// </summary>
        /// <param name="_length"> Длина фигуры</param>
        /// <param name="_width"> Ширина фигуры</param>
        /// <param name="_height"> Высота фигуры</param>
        public Shape(double _length, double _width, double _height)
        {
            length = _length;
            width = _width;
            height = _height;
        }

        /// <summary>
        /// Метод создания куба
        /// </summary>
        /// <param name="_length">  Длина фигуры</param>
        /// <param name="_width"> Ширина фигуры</param>
        /// <param name="_height"> Высота фигуры</param>
        public void Cube(double _length, double _width, double _height)
        {

        }

    }
}
