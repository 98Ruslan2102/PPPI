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
        /// <summary>
        /// Переменная длины фигуры
        /// </summary>
        double length;
        /// <summary>
        /// Переменная длины фигуры
        /// </summary>
        double width;
        /// <summary>
        /// Переменная высоты фигуры
        /// </summary>
        double height;
        /// <summary>
        /// Переменная Тип фигуры
        /// </summary>
        string typeShape;

        /// <summary>
        /// Конструктор Shape
        /// </summary>
        /// <param name="_length"> Длина фигуры</param>
        /// <param name="_width"> Ширина фигуры</param>
        /// <param name="_height"> Высота фигуры</param>
        /// /// <param name="_typeShape"> Тип фигуры</param>
        public Shape(double _length, double _width, double _height, string _typeShape)
        {
            length = _length;
            width = _width;
            height = _height;
            typeShape = _typeShape;
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

        /// <summary>
        /// Метод создания цилиндра
        /// </summary>
        /// <param name="_length"> Длина цилиндра</param>
        /// <param name="_height"> Высота цилиндра</param>
        public void Cylinder(double _length, double _height)
        {

        }

    }
}
