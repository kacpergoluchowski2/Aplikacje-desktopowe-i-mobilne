﻿using System;

namespace FirstProject
{
    class Program
    {


        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");



            //c++
            //typ nazwa = wartość;
            //int liczba = 5;
            //int x,y;

            string imie = "Jan";
            string nazwisko = "Kowalski";
            //nazwisko.Length

            Console.WriteLine("Witaj " + imie + " " + nazwisko + " tutaj");
            Console.WriteLine("Witaj {1} {0} tutaj",imie, nazwisko);
            Console.WriteLine($"Witaj {imie} xxxx {nazwisko} tutaj");


            Console.WriteLine("Prędkość to km\\h");
            Console.WriteLine(@"Prędkość to km\h");

            int liczbaCalkowita = 5;
            double liczbaRzeczywista = 5.6;

   


        }
    }
}