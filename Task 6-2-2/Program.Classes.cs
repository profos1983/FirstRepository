using System.Drawing;

partial class Program
{
    public class Pen
    {
        #region Параметры
        public string color;
        public double cost;
        #endregion

        #region Конструкторы
        public Pen()
        {
            color = "Черный";
            cost = 100.0;
        }

        public Pen (string penColor, double penCost)
        {
            color = penColor;
            cost = penCost;

        }
        #endregion

        #region Методы
        public void ShowPenInfo()
        {
            Console.WriteLine("Цвет ручки: {0}, цена: {1}", color, cost);
        }
        #endregion
    }

    // Создайте класс Rectangle для представления прямоугольников удовлетворяющий следующим требованиям:
    // Класс должен содержать целочисленные поля для сторон a и b.
    // Класс должен содержать метод Square, возвращающий площадь прямоугольника (произведение сторон).
    // Класс должен содержать 3 конструктора: с 2 параметрами, когда a != b, с 1 параметром, когда a == b, 
    // и конструктор без параметров по умолчанию, в котором стороны будут заполняться как a = 6, b = 4.

    public class Rectangle
    {
        #region Параметры класса
        public int a;
        public int b;
        #endregion

        #region Конструкторы
        // Конструктор по умолчанию
        public Rectangle() 
        {
            a = 6;
            b = 4;
        }

        public Rectangle(int first, int second)
        {
            a = first;
            b = second;
        }

        public Rectangle(int site)
        {
            a = site;
            b = site;
        }
        #endregion

        #region Методы
        public int Square ()
        {
            return a * b;
        }

        public void ShowRectangleInfo()
        {
            Console.WriteLine("Длина: {0}, Ширина: {1}, Площадь: {2}", a, b, Square());
        }
        #endregion
    }

}
