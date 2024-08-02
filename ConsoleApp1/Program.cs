/*
 Створіть клас «Фільм», який має зберігати таку інформацію:
 назва фільму;
 назва кіностудії;
 жанр;
 тривалість;
 рік.
Реалізуйте у класі методи та властивості, необхідні для
функціонування класу.
Додайте до класу деструктор. Напишіть код для тестування
функціональності класу.
Напишіть код для деструктора.
 */

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Film film1 = new Film("Oppenheimer", "Universal", "epic biographical thriller", 148, 2023);

            Console.WriteLine(film1);
            film1.Dispose();

        }
    }
}
