using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Fox
{
    class Program
    {
        static void Main(string[] args)
        {


            // Да се напише програма, която прочита от конзолата цяло нечетно число N 
            // и чертае лисица, като в примерите по-долу.
            // Лисицата има ширина – 2 * N + 3 колони. 

            //                          9                *\-----------------/*
            //                                           **\---------------/**
            //                                           ***\-------------/***
            //                                           ****\-----------/****
            //                                           *****\---------/*****
            //                                           ******\-------/******
            //                                           *******\-----/*******
            //                                           ********\---/********
            //                                           *********\-/*********
            //                                           |****\*********/****|
            //                                           |*****\*******/*****|
            //                                           |******\*****/******|
            //                                           -\*****************/ -
            //                                           --\***************/ --
            //                                           ---\*************/ ---
            //                                           ----\***********/ ----
            //                                           -----\*********/ -----
            //                                           ------\*******/ ------
            //                                           -------\*****/ -------
            //                                           --------\***/ --------
            //                                           ---------\*/ ---------
            //                                           


            int n = int.Parse(Console.ReadLine());

            var width = 2 * n + 3;




            #region First Part

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(new string('*', 1 + i) + "\\" + new string('-', (width - 4) - 2 * i ) +
                    "/" + new string('*', 1 + i));
            }

            #endregion

            #region Middle Part

            for (int i = 0; i < n / 3; i++)
            {
                Console.WriteLine("|" + new string('*', (n / 2)  + i) + "\\" + new string('*', n - 2 * i) +
                    "/" + new string('*', (n / 2) + i) + "|");
            }

            #endregion

            #region Last Part

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(new string('-', 1 + i) + "\\" + new string('*', (width - 4) - 2 * i) +
                    "/" + new string('-', 1 + i));
            }


            #endregion



        }
    }
}
