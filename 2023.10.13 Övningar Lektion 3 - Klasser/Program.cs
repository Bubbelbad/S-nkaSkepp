﻿using System.Numerics;
using System;
using _2023._10._13_Övningar_Lektion_3___Klasser;

namespace _2023._10._13_Sänka_Skepp
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //  GameManager gameManager = new GameManager();
            //
            //  gameManager.Menu();
            int[,] gameField = new int[11, 11];
            for (int i = 0; i < gameField.GetLength(1); i++)
            {
                for (int j = 0; j < gameField.GetLength(0); j++)
                {
                    Console.Write($"{gameField[i, j]}".PadRight(3));
                }
                Console.WriteLine();
            }






            /*
            Uppgift 3:
            
            Skapa en två - dimensionell array.Tänk dig spelet Battleship.
             https://en.wikipedia.org/wiki/Battleship_(game)
            Skapa så att varje slags skepp är sitt egen klass som man skall placera över flera rutor i den
            två - dimensionella arrayen.När man skapar varje skepp skall man välja vart det börjar och
            vilket håll det pekar, och programmet skall kolla om det inte går utanför planen eller krockar
            med ett annat skepp.Vi skall sedan kunna hämta om det finns ett skepp på en ruta eller
            inte.Gör så att variablerna i skeppen har getters och setters.*/



        }
    }
}