using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Codewars_AvoidObstacles
{
    [TestClass]
    public class UnitTest1
    {
        //Constraints: 1 ≤ inputArray[i] ≤ 100.
        [TestMethod]
        public void Obstacles_are_1_min_legnth_should_be_2()
        {
            var arr = new int[] { 1 };
            MinimalLengthOfJumpShouldBe(arr, 2);
        }

        private static void MinimalLengthOfJumpShouldBe(int[] arr, int expected)
        {
            Assert.AreEqual(expected, new Kata().AvoidObstacles(arr));
        }

        [TestMethod]
        public void Obstacles_are_1_3_min_length_should_be_2()
        {
            MinimalLengthOfJumpShouldBe(new int[] { 1, 3 }, 2);
        }

        [Ignore]
        [TestMethod]
        public void PrintLookupData()
        {
            for (int i = 2; i < 101; i++)
            {
                Console.Write("{");
                Console.Write(i.ToString() + ", new List<int>{");
                Print(i);
                Console.Write("}},");
                Console.WriteLine();
            }
        }

        private void Print(int i)
        {
            var total = 0;
            while (total <= 100)
            {
                total += i;
                if (total <= 100)
                {
                    Console.Write(total.ToString() + ",");
                }
            }
        }
    }

    public class Kata
    {
        private static Dictionary<int, List<int>> Lookup
        {
            get
            {
                return new Dictionary<int, List<int>>
                {
                    {2, new List<int>{2,4,6,8,10,12,14,16,18,20,22,24,26,28,30,32,34,36,38,40,42,44,46,48,50,52,54,56,58,60,62,64,66,68,70,72,74,76,78,80,82,84,86,88,90,92,94,96,98,100,}},
                    {3, new List<int>{3,6,9,12,15,18,21,24,27,30,33,36,39,42,45,48,51,54,57,60,63,66,69,72,75,78,81,84,87,90,93,96,99,}},
                    {4, new List<int>{4,8,12,16,20,24,28,32,36,40,44,48,52,56,60,64,68,72,76,80,84,88,92,96,100,}},
                    {5, new List<int>{5,10,15,20,25,30,35,40,45,50,55,60,65,70,75,80,85,90,95,100,}},
                    {6, new List<int>{6,12,18,24,30,36,42,48,54,60,66,72,78,84,90,96,}},
                    {7, new List<int>{7,14,21,28,35,42,49,56,63,70,77,84,91,98,}},
                    {8, new List<int>{8,16,24,32,40,48,56,64,72,80,88,96,}},
                    {9, new List<int>{9,18,27,36,45,54,63,72,81,90,99,}},
                    {10, new List<int>{10,20,30,40,50,60,70,80,90,100,}},
                    {11, new List<int>{11,22,33,44,55,66,77,88,99,}},
                    {12, new List<int>{12,24,36,48,60,72,84,96,}},
                    {13, new List<int>{13,26,39,52,65,78,91,}},
                    {14, new List<int>{14,28,42,56,70,84,98,}},
                    {15, new List<int>{15,30,45,60,75,90,}},
                    {16, new List<int>{16,32,48,64,80,96,}},
                    {17, new List<int>{17,34,51,68,85,}},
                    {18, new List<int>{18,36,54,72,90,}},
                    {19, new List<int>{19,38,57,76,95,}},
                    {20, new List<int>{20,40,60,80,100,}},
                    {21, new List<int>{21,42,63,84,}},
                    {22, new List<int>{22,44,66,88,}},
                    {23, new List<int>{23,46,69,92,}},
                    {24, new List<int>{24,48,72,96,}},
                    {25, new List<int>{25,50,75,100,}},
                    {26, new List<int>{26,52,78,}},
                    {27, new List<int>{27,54,81,}},
                    {28, new List<int>{28,56,84,}},
                    {29, new List<int>{29,58,87,}},
                    {30, new List<int>{30,60,90,}},
                    {31, new List<int>{31,62,93,}},
                    {32, new List<int>{32,64,96,}},
                    {33, new List<int>{33,66,99,}},
                    {34, new List<int>{34,68,}},
                    {35, new List<int>{35,70,}},
                    {36, new List<int>{36,72,}},
                    {37, new List<int>{37,74,}},
                    {38, new List<int>{38,76,}},
                    {39, new List<int>{39,78,}},
                    {40, new List<int>{40,80,}},
                    {41, new List<int>{41,82,}},
                    {42, new List<int>{42,84,}},
                    {43, new List<int>{43,86,}},
                    {44, new List<int>{44,88,}},
                    {45, new List<int>{45,90,}},
                    {46, new List<int>{46,92,}},
                    {47, new List<int>{47,94,}},
                    {48, new List<int>{48,96,}},
                    {49, new List<int>{49,98,}},
                    {50, new List<int>{50,100,}},
                    {51, new List<int>{51,}},
                    {52, new List<int>{52,}},
                    {53, new List<int>{53,}},
                    {54, new List<int>{54,}},
                    {55, new List<int>{55,}},
                    {56, new List<int>{56,}},
                    {57, new List<int>{57,}},
                    {58, new List<int>{58,}},
                    {59, new List<int>{59,}},
                    {60, new List<int>{60,}},
                    {61, new List<int>{61,}},
                    {62, new List<int>{62,}},
                    {63, new List<int>{63,}},
                    {64, new List<int>{64,}},
                    {65, new List<int>{65,}},
                    {66, new List<int>{66,}},
                    {67, new List<int>{67,}},
                    {68, new List<int>{68,}},
                    {69, new List<int>{69,}},
                    {70, new List<int>{70,}},
                    {71, new List<int>{71,}},
                    {72, new List<int>{72,}},
                    {73, new List<int>{73,}},
                    {74, new List<int>{74,}},
                    {75, new List<int>{75,}},
                    {76, new List<int>{76,}},
                    {77, new List<int>{77,}},
                    {78, new List<int>{78,}},
                    {79, new List<int>{79,}},
                    {80, new List<int>{80,}},
                    {81, new List<int>{81,}},
                    {82, new List<int>{82,}},
                    {83, new List<int>{83,}},
                    {84, new List<int>{84,}},
                    {85, new List<int>{85,}},
                    {86, new List<int>{86,}},
                    {87, new List<int>{87,}},
                    {88, new List<int>{88,}},
                    {89, new List<int>{89,}},
                    {90, new List<int>{90,}},
                    {91, new List<int>{91,}},
                    {92, new List<int>{92,}},
                    {93, new List<int>{93,}},
                    {94, new List<int>{94,}},
                    {95, new List<int>{95,}},
                    {96, new List<int>{96,}},
                    {97, new List<int>{97,}},
                    {98, new List<int>{98,}},
                    {99, new List<int>{99,}},
                    {100, new List<int>{100,}},
                };
            }
        }

        public int AvoidObstacles(int[] arr)
        {
            for (int i = 2; i < 101; i++)
            {
                var lookup = Lookup[i];

                if (!arr.Any(x => lookup.Contains(x)))
                {
                    return i;
                }
            }

            return arr.Max() + 1;
        }
    }
}