using System;
using System.Collections.Generic;
using System.Text;

namespace methodss
{
    class Program
    {
        static void Main(string[] args)

        {
            #region Lesson 7dən task-1

            Console.WriteLine("Adinizi daxil edin");

            string name = Console.ReadLine();
            string surname = Console.ReadLine();
            string show = WriteNameSurname(name, surname);

            Console.WriteLine(show);

            #endregion

            #region Lesson 7dən task-2

            bool result = Equalize(30, 15);

            Console.WriteLine(result);

            bool result1 = Equalize(20, 10);

            Console.WriteLine(result1);

            #endregion

            #region Lesson 7dən task-3

            MeasureDegree(16);
            MeasureDegree(26);

            #endregion

            #region Lesson 7dən task-4

            Console.WriteLine("Test' baslayiriq, xahis olunur Enter duymeisne basasiniz");
            Console.ReadLine();
            Console.WriteLine("Sual 1 - Qarabagda bu sezon qol krali kimdir");
            Console.WriteLine("a) Juninho");
            Console.WriteLine("b) Benzia");
            Console.WriteLine("c) Elvin");
            Console.WriteLine("d) Behlul");
            Console.WriteLine("e) Marko");

            string cavab = CavabBirOlan(Console.ReadLine());

            Console.WriteLine("Sual 2 - Azərbaycanın paytaxti hansi seherdir?");
            Console.WriteLine("a) Lenkeran");
            Console.WriteLine("b) Baki");
            Console.WriteLine("c) Kurdexani");
            Console.WriteLine("d) Masazir");
            Console.WriteLine("e) Semkir");

            string cavab2 = CavabIkiOlan(Console.ReadLine());

            Console.WriteLine("Sual 3 - Azərbaycanın paytaxti hansi seherdir?");
            Console.WriteLine("a) Lenkeran");
            Console.WriteLine("b) Sumqayit");
            Console.WriteLine("c) Baki");
            Console.WriteLine("d) Masazir");
            Console.WriteLine("e) Semkir");

            string cavab3 = CavabUcOlan(Console.ReadLine());

            #endregion

            #region Lesson 8dən task-1

            Console.WriteLine("reqemleri daxil edin");

            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());

            KvadratQaytar(num1, num2);

            #endregion

            #region Lesson 9dan task-2

            Console.WriteLine("ad soyad ve yasinizi qeyd edin");

            string ad = Console.ReadLine();
            string soyad = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());

            MeasureAge(ad, soyad, age);

            #endregion

            #region Lesson 9dan task-3

            int[] arr1 = { 1, 2, 4, 6, 8, 10 };
            int solve = ArrayHesabla(arr1);

            Console.WriteLine($"cut ededlerin cemi {solve}");

            #endregion

            #region Lesson 9dan task-4

            int[] numbers = { 3, 4, 6, 7, 8, 0, 0 };
            int edediOrta = ArrayEdediOrtaHesabla(numbers);

            Console.WriteLine(edediOrta);

            #endregion

            #region Lesson 9dan task-5

            int[] Array1 = { 2, 3, 4, 5, 98, 13 };
            int[] Array2 = { 2, 3, 6, 7, 13, 90, };
            int sum = IkiArrayEnBoyukTopla(Array1, Array2);

            Console.WriteLine(sum);

            #endregion
        }

        #region lesson 7den task-1
        static string WriteNameSurname(string name, string surname)

        {
            if (name.Length > 2 && surname.Length > 2)
            {
                return name + "  " + surname;
            }

            else
            {
                return "adiniz ve ya soyadiniz duzgun qeyd olunmayib";
            }

        }  //return
        #endregion

        #region Lesson 7den task-2
        static bool Equalize(int num1, int num2)

        {
            if (num1 == 30 || num2 == 30 || num1 + num2 == 30)
            {
                return true;
            }

            else
            {
                return false;
            }

        }  //return
        #endregion

        #region Lesson 7den task -3
        static void MeasureDegree(int num1)
        {
            if (num1 < 15)
            {
                Console.WriteLine("Hava soyuqdur");
            }

            else if (num1 >= 15 && num1 < 25)
            {
                Console.WriteLine("Hava mulayimdir");
            }

            else if (num1 > 25)
            {
                Console.WriteLine("hava istidir");
            }

        }  //console.writeline
        #endregion

        #region Lesson 7den task-4
        static string CavabBirOlan(string variant)

        {
            switch (variant)

            {
                case "a":
                    Console.WriteLine("cavab dogrudur");
                    break;
                case "b":
                    Console.WriteLine("cavab yanlisdir");
                    break;
                case "c":
                    Console.WriteLine("cavab yanlisdir");
                    break;
                case "d":
                    Console.WriteLine("cavab yanlisdir");
                    break;
                case "e":
                    Console.WriteLine("cavab yanlisdir");
                    break;
                default:
                    Console.WriteLine("qeyd etdiyiniz variant yuxaridaki varinatlar arasinda yoxdur");
                    break;
            }
            return "variant";

        }  //return


        static string CavabIkiOlan(string variant)

        {
            switch (variant)

            {
                case "a":
                    Console.WriteLine("cavab yanlisdir");
                    break;
                case "b":
                    Console.WriteLine("cavab dogrudur");
                    break;
                case "c":
                    Console.WriteLine("cavab yanlisdir");
                    break;
                case "d":
                    Console.WriteLine("cavab yanlisdir");
                    break;
                case "e":
                    Console.WriteLine("cavab yanlisdir");
                    break;
                default:
                    Console.WriteLine("qeyd etdiyiniz variant yuxaridaki varinatlar arasinda yoxdur");
                    break;
            }
            return "variant";


        }  //return

        static string CavabUcOlan(string variant)

        {

            switch (variant)

            {
                case "a":
                    Console.WriteLine("cavab yanlisdir");
                    break;
                case "b":
                    Console.WriteLine("cavab yanlisdir");
                    break;
                case "c":
                    Console.WriteLine("cavab dogrudur");
                    break;
                case "d":
                    Console.WriteLine("cavab yanlisdir");
                    break;
                case "e":
                    Console.WriteLine("cavab yanlisdir");
                    break;
                default:
                    Console.WriteLine("qeyd etdiyiniz variant yuxaridaki varinatlar arasinda yoxdur");
                    break;
            }

            return "variant";

        }  //return
        #endregion

        #region Lesson 8den task -1
        static void KvadratQaytar(int num1, int num2)

        {
            int sum = 0;
            for (int i = num1; i < num2; i++)
            {
                if (i % 2 == 0)
                {

                    sum += i * i;
                }

            }
            Console.WriteLine(sum);

        }   //console.writeline

        #endregion

        #region Lesson 9dan task-2
        static void MeasureAge(string name, string surname, int age) //console.writeline

        {

            int diff = 18 - age;
            if (age < 18)
            {
                for (int i = 1; i < diff; i++)
                {
                    age++;

                    Console.WriteLine(age + "yasiniz mubarek");

                }

            }
            else
            {
                Console.WriteLine(age + "yasiniz mubarek");
            }


        }
        #endregion

        #region Lesson 9dan task-3
        static int ArrayHesabla(int[] numbers)

        {
            int sum = 0;

            foreach (var number in numbers)
            {
                if (number % 2 == 0)
                {
                    sum += number;
                }

            }
            return sum;


        }  //return

        #endregion

        #region Lesson 9dan task -4
        static int ArrayEdediOrtaHesabla(int[] numbers) //return

        {
            int sum = 0;
            foreach (int number in numbers)
            {
                sum += number;
            }

            return sum / numbers.Length;

        }
        #endregion

        #region Lesson 9dan task-5
        static int IkiArrayEnBoyukTopla(int[] numbers1, int[] numbers2) //return

        {
            int sum = 0;
            foreach (int number in numbers1)
            {
                if (number > sum)
                {
                    sum = number;
                }
            }

            int sum1 = 0;
            foreach (int number2 in numbers2)
            {
                if (number2 > sum1)
                {
                    sum1 = number2;
                }
            }
            return sum + sum1;

        }
        #endregion
        
      

       
        
    }
}
