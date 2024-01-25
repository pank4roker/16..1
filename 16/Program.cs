using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace _16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Task 3
            DateTime dateTime = new DateTime(2022,1,20,13,5,20);
            //1 способ 20.01.2022
            WriteLine(dateTime.ToString("d"));
            //2 способ 20 янв 2022
            WriteLine(dateTime.ToString("dd MMM yyyy"));
            //3 cспособ 20 января 2022 г.
            WriteLine(dateTime.ToString("D"));
            //4 способ Чт, 20 янв 2022
            WriteLine(dateTime.ToString("ddd, dd MMM yyyy"));
            //5 cпособ четверг, 20 января 2022
            WriteLine(dateTime.ToString("dddd, dd MMMM yyyy"));
            //6 способ 13:05:20
            WriteLine(dateTime.ToString("T"));
            //7 способ 13:05
            WriteLine(dateTime.ToString("t"));
            //8 способ 20.01.2022 13:05:20
            WriteLine(dateTime.ToString("G"));
            //9 способ 20 января 2022 г. 13:05
            WriteLine(dateTime.ToString("f"));
            //10 способ 20 января 2022 г. 13:05:20
            WriteLine(dateTime.ToString("F"));
            //11 способ Thu, 20 Jan 2022 13:05:20 GMT
            WriteLine(dateTime.ToString("R"));
            //11 способ 2022-01-20T13:05:20
            WriteLine(dateTime.ToString("s"));
            //Task 2
            //Запросить с клавиатуры возраст человека и вывести на экран следующее сообщение: Ты родился в .... году
            Write("Введите ваш возраст: ");
            int age = Convert.ToInt32(ReadLine());
            DateTime date = DateTime.Now.AddYears(-age);
            WriteLine(date.ToString("Вы родились в yyyy году"));
            //Task 3 
            //Определить возраст человека
            Write("\nВведите год вашего рождения: ");
            int year = Convert.ToInt32(ReadLine());
            DateTime date_1 = DateTime.Now.AddYears(-year);
            WriteLine(date_1.ToString("Ваш возраст yy лет"));
            ReadKey();
        }
    }
}
