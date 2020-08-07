using System;

namespace CourseWeek2Lesson4
{
    class Program
    {


        public static void Exercise1()
        {
            /* 1.Stwórz program, w którym zadeklarujesz zmienne dotyczące danych pracownika firmy. Dane które chcesz przetrzymywać to:
                a.Imię,
                b.Nazwisko
                c.Wiek
                d.Płeć(‘m’ albo ‘k’)
                e.PESEL
                f.Numer pracownika(np. 2509324094)
            Zadeklaruj zmienne odpowiednich typów, które mogą przetrzymywać te informacje. */

            string firstName;
            string lastName;
            int age;
            Sex sex;
            string PESEL;
            long id;
        }


        public static void Exercise2()
        {
            /* 2. Napisz program, w którym stworzysz 3 zmienne z jedną literą, a następnie wypiszesz je w odwrotnej kolejności niż zostały zadeklarowane. */
            char first = 'c';
            char second = 'b';
            char last = 'a';

            Console.WriteLine($"{last}{second}{first}");
        }


    }
}