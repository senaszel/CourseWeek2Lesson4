using System;

namespace CourseWeek2Lesson4
{
    class Program
    {
        static void Main(string[] args)
        {
            Exercise5();
        }

        public static void Exercise1()
        {
            /* 1. Stwórz program, w którym zadeklarujesz zmienne dotyczące danych pracownika firmy. Dane które chcesz przetrzymywać to:
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


        public static double Exercise3(double _length,double _width)
        {
            /* 3. Napisz program, który na podstawie podanej szerokości i długości prostokąta wyliczy długość przekątnej. (Aby, obliczyć kwadrat liczby użyj metody Math.Pow()) */

            double length = _length;
            double width = _width;

            double diagonal = Math.Sqrt(Math.Pow(length, 2.0) + Math.Pow(width, 2.0));

            Console.WriteLine($"Diagonal of Rectangle which length is {length} and width is {width} equals = {diagonal}");
            return diagonal;
        }

        public static void Exercise4()
        {
            /* 4. Napisz program w którym stworzysz 2 zmienne liczbowe, oraz jedną tekstową, a następnie przypiszesz im następujące wartości:
                a. 10
                b. Szkoła Dotneta
                c. 12,5
            Pamiętaj o użyciu poprawnych typów danych. */

            int ten = 10;
            float twelveAndHalf = 12.5f;
            string dotNetSchool = "Szkoła Dotneta";
        }

        public static void Exercise5()
        {
            /* 5. Napisz program w którym poprosisz użytkownika o jego dane personalne tj. Imię, nazwisko, numer telefonu, adres email, wzrost, waga (np. 85,7), itp (postaraj się wymyślić jak najwięcej)
               i spróbuj przekonwertować odpowiedź do odpowiedniego typu danych używając metody: typDanych.Parse(odpowiedźOdUżytkownika). */

            Console.WriteLine("You'll be asked for personal information, please provide:");
            Console.Write("You're first name: ");
            string firstName = Console.ReadLine();
            Console.Write("Last name: ");
            string lastName = Console.ReadLine();
            Console.Write("Telephone number (digits only, do not use spaces etc): ");
            uint telephoneNumber = uint.Parse(Console.ReadLine());
            Console.Write("Email address: ");
            string email = Console.ReadLine();
            Console.Write("Height: ");
            uint height = uint.Parse(Console.ReadLine());
            Console.Write("Weight: (Rounded up up to 0.5 kilogram)");
            double weight = double.Parse(Console.ReadLine());

            Console.WriteLine("Thank you for participation.");
        }

    }
}