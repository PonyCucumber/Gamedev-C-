using System;

namespace Homework
{
    class Program
    {
        static void Main(string[] args)
        {
            //Фролова.
            //Написать программу «Анкета». Последовательно задаются вопросы
            //(имя, фамилия, возраст, рост, вес). В результате вся информация выводится в одну строчку:

            Console.WriteLine("Здравствуйте! Как вас зовут?");
            var name = Console.ReadLine();
            Console.WriteLine("Ваша фамилия?");
            var lastname = Console.ReadLine();
            Console.WriteLine("Ваш возраст?");
            var age = Console.ReadLine();
            Console.WriteLine("Ваш рост?");
            var height = Console.ReadLine();
            Console.WriteLine("Ваш вес?");
            var weight = Console.ReadLine();

            Console.WriteLine($"И снова здравствуйте, {lastname} {name}! Ваши рост и вес на {age} год жизни составляют {height} и {weight} соответственно.");



            //Ввести вес и рост человека. Рассчитать и вывести индекс массы тела (ИМТ) по формуле I=m/(h*h);
            //где m — масса тела в килограммах, h — рост в метрах.



            //Console.WriteLine("Добрый день! Для расчёта индекса массы тела для начала введите свой вес:");
            //string weight = Console.ReadLine();
            //double a = (int)Convert.ToDouble(weight);
            //Console.WriteLine("А теперь свой рост в сантиметрах:");
            //string height = Console.ReadLine();
            //double b = (int)Convert.ToDouble(height);
            //double imt = (int)Convert.ToDouble(a/(b/100*(b/100)));
            //Console.WriteLine($"Индекс массы вашего тела составит {imt}");


            ////Написать программу, которая подсчитывает расстояние между точками с координатами x1, y1 и x2,y2
            //по формуле r = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2)
            //Вывести результат, используя спецификатор формата .2f(с двумя знаками после запятой);

            //Console.WriteLine("Введите данные х1:");
            //var a = Console.ReadLine();
            //double x1 = (double)Convert.ToDouble(a);
            //Console.WriteLine("Введите данные у1:");
            //var b = Console.ReadLine();
            //double y1 = (double)Convert.ToDouble(b);
            //Console.WriteLine("Введите данные х2:");
            //var c = Console.ReadLine();
            //double x2 = (double)Convert.ToDouble(c);
            //Console.WriteLine("Введите данные y2:");
            //var d = Console.ReadLine();
            //double y2 = (double)Convert.ToDouble(d);
            //double r = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));

            //Console.WriteLine($"Расстояние между точками будет равно {r:F2}");


            //Написать программу обмена значениями двух переменных:

            //Console.WriteLine("Введите первое число:");
            //var a = Console.ReadLine();
            //double x = Convert.ToDouble(a);
            //Console.WriteLine("Введите второе число:");
            //var b = Console.ReadLine();
            //double y = Convert.ToDouble(b);
            //double t = x;
            //x = y;
            //y = t;
            //Console.WriteLine($"Первое число стало равно {x}, а второе {y}.");


            Console.ReadKey();
        }
    }
}
