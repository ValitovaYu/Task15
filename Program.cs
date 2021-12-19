using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task15
{
    class Program
    {
        static void Main(string[] args)
        {
            ArithProgression arithProgression = new ArithProgression();
            GeomProgression geomProgression = new GeomProgression();
            if (arithProgression is ISeries)
                Console.WriteLine("Объект реализует интерфейс ISeries");
            else throw new Exception("Объект НЕ реализует ISeries");

            Console.WriteLine("\tАрифметическая прогрессия");
            arithProgression.setStart(5);
            for (int i = 0; i < 5; i++)
                Console.WriteLine("Следующее значение = " + arithProgression.getNext());
            Console.WriteLine("Переход в исходное состояние.");
            arithProgression.reset();

            if (geomProgression is ISeries)
                Console.WriteLine("\nОбъект реализует интерфейс ISeries");
            else throw new Exception("Объект НЕ реализует ISeries");

            Console.WriteLine("\tГеометрическая прогрессия");
            geomProgression.setStart(6);
            for (int i = 0; i < 3; i++)
                Console.WriteLine("Следующее значение = " + geomProgression.getNext());
            Console.WriteLine("Переход в исходное состояние.");
            geomProgression.reset();


            Console.ReadKey();

        }
    }
    public interface ISeries
    {
        void setStart(int x); //устанавливает начальное значение
        int getNext(); //возвращает следующее число ряда
        void reset(); //выполняет сброс к начальному значению

    }
    class ArithProgression : ISeries
    {

        public int d = 2; // разность арифметической прогрессии
        int x1;
        int xn;

        public void setStart(int x) 
        {
            x1 = x;
            xn = x1;
            Console.WriteLine("Начальное значение: {0}", x);
        }
        public int getNext() 
        {                      
            xn += d;
            return xn;            
        }

        public void reset() 
        {
            xn=x1;
        }
    }
    class GeomProgression : ISeries
    {
        public int q = 3; // знаменатель геометрической прогрессии
        int x1;
        int xn;
        public void setStart(int x)
        {
            x1 = x;
            xn = x1;
            Console.WriteLine("Начальное значение: {0}", x);
        }
        public int getNext()
        {
            xn *=q;
            return xn;
        }

        public void reset()
        {
            xn = x1;
        }
    }
}
