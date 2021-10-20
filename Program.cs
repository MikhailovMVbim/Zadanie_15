using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_15
{
    /*
     * Разработать интерфейс ISeries генерации ряда чисел. Интерфейс содержит следующие элементы:
        метод void setStart(int x) - устанавливает начальное значение
        метод int getNext() - возвращает следующее число ряда
        метод void reset() - выполняет сброс к начальному значению
        Разработать классы ArithProgression и GeomProgression, которые реализуют интерфейс ISeries.
    В классах реализовать методы интерфейса в соответствии с логикой арифметической и геометрической прогрессии соответственно.
     */
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задание 15. Интерфейсы.");
            Console.WriteLine("Реализация методов интерфейса для классов арифметической и геометрической прогрессий.");
            Console.WriteLine("--------------------------------------");
            ArithProgression arithm = new ArithProgression(2);
            arithm.setStart(2);
            Console.WriteLine("Начальное значение арифметической прогрессии: {0}, текущее значение: {1}, следующее значение: {2}",arithm.D, arithm.X,arithm.getNext());
            Console.WriteLine("Начальное значение арифметической прогрессии: {0}, текущее значение: {1}, следующее значение: {2}",arithm.D, arithm.X,arithm.getNext());
            Console.WriteLine("Начальное значение арифметической прогрессии: {0}, текущее значение: {1}, следующее значение: {2}",arithm.D, arithm.X,arithm.getNext());
            Console.WriteLine("Начальное значение арифметической прогрессии: {0}, текущее значение: {1}, следующее значение: {2}",arithm.D, arithm.X,arithm.getNext());
            arithm.Reset();
            Console.WriteLine("Начальное значение арифметической прогрессии: {0}, текущее значение: {1}, следующее значение: {2}",arithm.D, arithm.X,arithm.getNext());
            Console.WriteLine("Начальное значение арифметической прогрессии: {0}, текущее значение: {1}, следующее значение: {2}",arithm.D, arithm.X,arithm.getNext());
            Console.WriteLine("--------------------------------------");
            GeomProgression geom = new GeomProgression(5);
            geom.setStart(30);
            Console.WriteLine("Начальное значение геометрической прогрессии: {0}, текущее значение: {1}, следующее значение: {2}", geom.D, geom.X, geom.getNext());
            Console.WriteLine("Начальное значение геометрической прогрессии: {0}, текущее значение: {1}, следующее значение: {2}", geom.D, geom.X, geom.getNext());
            Console.WriteLine("Начальное значение геометрической прогрессии: {0}, текущее значение: {1}, следующее значение: {2}", geom.D, geom.X, geom.getNext());
            Console.WriteLine("Начальное значение геометрической прогрессии: {0}, текущее значение: {1}, следующее значение: {2}", geom.D, geom.X, geom.getNext());
            geom.Reset();
            Console.WriteLine("Начальное значение геометрической прогрессии: {0}, текущее значение: {1}, следующее значение: {2}", geom.D, geom.X, geom.getNext());
            Console.WriteLine("Начальное значение геометрической прогрессии: {0}, текущее значение: {1}, следующее значение: {2}", geom.D, geom.X, geom.getNext());
            Console.ReadKey();
        }
    }

    interface ISeries
    {
        void setStart(int x);
        int getNext();
        void Reset();
    }

    class ArithProgression : ISeries
    {
        public int X { get; set; }
        public int D { get; set; }
        public int S { get; set; }
        public ArithProgression(int d)
        {
            D = d;
        }
        public int getNext()
        {
            return X+=D;
        }

        public void Reset()
        {
            Console.WriteLine("Сброс к начальному значению.");
            X=S;
        }

        public void setStart(int x)
        {
            X = x;
            S = x;
        }
    }

    class GeomProgression : ISeries
    {
        public int X { get; set; }
        public int D { get; set; }
        public int S { get; set; }
        public GeomProgression(int d)
        {
            D = d;
        }
        public int getNext()
        {
            return X *= D;
        }

        public void Reset()
        {
            Console.WriteLine("Сброс к начальному значению.");
            X = S;
        }

        public void setStart(int x)
        {
            X = x;
            S = x;
        }
    }
}
