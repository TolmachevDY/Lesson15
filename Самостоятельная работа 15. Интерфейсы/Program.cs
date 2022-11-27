using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Самостоятельная_работа_15.Интерфейсы
{
    class Program
    {
        static void Main(string[] args)
        {
            //создаем экземпляр класса арифметической прогрессии
            ArithProgression arithProgression = new ArithProgression();
            //на экземпляре класса вызываем метод стартового значения и указываем необходимое значение
            arithProgression.setStart(10);
            //на экземпляре класса вызываем метод шага прогрессии и указываем необходимое значение
            arithProgression.setStep(2);
            //выводим на консоль первые 3 значения прогрессии, используя метод для возврата следующего числа
            Console.WriteLine(arithProgression.getNext());
            Console.WriteLine(arithProgression.getNext());
            Console.WriteLine(arithProgression.getNext());
            //сбрасываем текущее значение прогрессии к стартовому значению, вызывая необходимый метод
            arithProgression.reset();
            //выводим следующие 2 числа прогрессии, начиная опять от стартового значения, т.к. произвели сброс в предыдущем шаге
            Console.WriteLine(arithProgression.getNext());
            Console.WriteLine(arithProgression.getNext());
            //создаем экземпляр класса геометрической прогрессии и производим аналогичные действия
            GeomProgression geomProgression=new GeomProgression();
            geomProgression.setStart(15);
            geomProgression.setStep(5);
            Console.WriteLine(geomProgression.getNext());
            Console.WriteLine(geomProgression.getNext());
            Console.WriteLine(geomProgression.getNext());
            geomProgression.reset();
            Console.WriteLine(geomProgression.getNext());
            Console.WriteLine(geomProgression.getNext());

            Console.ReadKey();
        }
        //создаем интерфейс
        interface ISeeries
        {
            //метод устанавливает стратовое значение
            void setStart(int x);
            //метод возвращает следующее число ряда
            int getNext();
            //метод выполняет сброс к начальному значению
            void reset();
        }
        //создаем класс арифметической прогрессии и реализуем интерфейс
        class ArithProgression : ISeeries
        {
            //вводим переменную для шага прогрессии
            int step;
            //вводим переменную для стартового значения
            int startValue;
            //вводим переменную для текущего значения
            int currentValue;
            //реализуем метод интерфейса для возврата следующего числа
            public int getNext()
            {
                currentValue += step;
                return currentValue;
            }
            //реализуем метод интерфейса для сброса текущего числа
            public void reset()
            {
                currentValue = startValue;
            }
            //реализуем метод интерфейса для задания начального значения
            public void setStart(int x)
            {
                startValue = x;
                currentValue = startValue;
            }
            //создаем новый метод класса для задания шага прогрессии
            public void setStep(int s)
            {
                step = s;
            }
        }  
        //создаем класс для геометрической прогрессии, аналогично предыдущему классу
        class GeomProgression : ISeeries
        {
            int step;
            int startValue;
            int currentValue;
            public int getNext()
            {
                currentValue *= step;
                return currentValue;
            }
            public void reset()
            {
                currentValue = startValue;
            }
            public void setStart(int x)
            {
                startValue = x;
                currentValue = startValue;
            }
            public void setStep(int s)
            {
                step = s;
            }
        }
    }
}
