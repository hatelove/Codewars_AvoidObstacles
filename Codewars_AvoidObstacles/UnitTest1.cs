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
        private static Dictionary<int, HashSet<int>> Lookup
        {
            get
            {
                return new Dictionary<int, HashSet<int>>
                {
                    {2, new HashSet<int>{2,4,6,8,10,12,14,16,18,20,22,24,26,28,30,32,34,36,38,40,42,44,46,48,50,52,54,56,58,60,62,64,66,68,70,72,74,76,78,80,82,84,86,88,90,92,94,96,98,100,}},
                    {3, new HashSet<int>{3,6,9,12,15,18,21,24,27,30,33,36,39,42,45,48,51,54,57,60,63,66,69,72,75,78,81,84,87,90,93,96,99,}},
                    {4, new HashSet<int>{4,8,12,16,20,24,28,32,36,40,44,48,52,56,60,64,68,72,76,80,84,88,92,96,100,}},
                    {5, new HashSet<int>{5,10,15,20,25,30,35,40,45,50,55,60,65,70,75,80,85,90,95,100,}},
                    {6, new HashSet<int>{6,12,18,24,30,36,42,48,54,60,66,72,78,84,90,96,}},
                    {7, new HashSet<int>{7,14,21,28,35,42,49,56,63,70,77,84,91,98,}},
                    {8, new HashSet<int>{8,16,24,32,40,48,56,64,72,80,88,96,}},
                    {9, new HashSet<int>{9,18,27,36,45,54,63,72,81,90,99,}},
                    {10, new HashSet<int>{10,20,30,40,50,60,70,80,90,100,}},
                    {11, new HashSet<int>{11,22,33,44,55,66,77,88,99,}},
                    {12, new HashSet<int>{12,24,36,48,60,72,84,96,}},
                    {13, new HashSet<int>{13,26,39,52,65,78,91,}},
                    {14, new HashSet<int>{14,28,42,56,70,84,98,}},
                    {15, new HashSet<int>{15,30,45,60,75,90,}},
                    {16, new HashSet<int>{16,32,48,64,80,96,}},
                    {17, new HashSet<int>{17,34,51,68,85,}},
                    {18, new HashSet<int>{18,36,54,72,90,}},
                    {19, new HashSet<int>{19,38,57,76,95,}},
                    {20, new HashSet<int>{20,40,60,80,100,}},
                    {21, new HashSet<int>{21,42,63,84,}},
                    {22, new HashSet<int>{22,44,66,88,}},
                    {23, new HashSet<int>{23,46,69,92,}},
                    {24, new HashSet<int>{24,48,72,96,}},
                    {25, new HashSet<int>{25,50,75,100,}},
                    {26, new HashSet<int>{26,52,78,}},
                    {27, new HashSet<int>{27,54,81,}},
                    {28, new HashSet<int>{28,56,84,}},
                    {29, new HashSet<int>{29,58,87,}},
                    {30, new HashSet<int>{30,60,90,}},
                    {31, new HashSet<int>{31,62,93,}},
                    {32, new HashSet<int>{32,64,96,}},
                    {33, new HashSet<int>{33,66,99,}},
                    {34, new HashSet<int>{34,68,}},
                    {35, new HashSet<int>{35,70,}},
                    {36, new HashSet<int>{36,72,}},
                    {37, new HashSet<int>{37,74,}},
                    {38, new HashSet<int>{38,76,}},
                    {39, new HashSet<int>{39,78,}},
                    {40, new HashSet<int>{40,80,}},
                    {41, new HashSet<int>{41,82,}},
                    {42, new HashSet<int>{42,84,}},
                    {43, new HashSet<int>{43,86,}},
                    {44, new HashSet<int>{44,88,}},
                    {45, new HashSet<int>{45,90,}},
                    {46, new HashSet<int>{46,92,}},
                    {47, new HashSet<int>{47,94,}},
                    {48, new HashSet<int>{48,96,}},
                    {49, new HashSet<int>{49,98,}},
                    {50, new HashSet<int>{50,100,}},
                    {51, new HashSet<int>{51,}},
                    {52, new HashSet<int>{52,}},
                    {53, new HashSet<int>{53,}},
                    {54, new HashSet<int>{54,}},
                    {55, new HashSet<int>{55,}},
                    {56, new HashSet<int>{56,}},
                    {57, new HashSet<int>{57,}},
                    {58, new HashSet<int>{58,}},
                    {59, new HashSet<int>{59,}},
                    {60, new HashSet<int>{60,}},
                    {61, new HashSet<int>{61,}},
                    {62, new HashSet<int>{62,}},
                    {63, new HashSet<int>{63,}},
                    {64, new HashSet<int>{64,}},
                    {65, new HashSet<int>{65,}},
                    {66, new HashSet<int>{66,}},
                    {67, new HashSet<int>{67,}},
                    {68, new HashSet<int>{68,}},
                    {69, new HashSet<int>{69,}},
                    {70, new HashSet<int>{70,}},
                    {71, new HashSet<int>{71,}},
                    {72, new HashSet<int>{72,}},
                    {73, new HashSet<int>{73,}},
                    {74, new HashSet<int>{74,}},
                    {75, new HashSet<int>{75,}},
                    {76, new HashSet<int>{76,}},
                    {77, new HashSet<int>{77,}},
                    {78, new HashSet<int>{78,}},
                    {79, new HashSet<int>{79,}},
                    {80, new HashSet<int>{80,}},
                    {81, new HashSet<int>{81,}},
                    {82, new HashSet<int>{82,}},
                    {83, new HashSet<int>{83,}},
                    {84, new HashSet<int>{84,}},
                    {85, new HashSet<int>{85,}},
                    {86, new HashSet<int>{86,}},
                    {87, new HashSet<int>{87,}},
                    {88, new HashSet<int>{88,}},
                    {89, new HashSet<int>{89,}},
                    {90, new HashSet<int>{90,}},
                    {91, new HashSet<int>{91,}},
                    {92, new HashSet<int>{92,}},
                    {93, new HashSet<int>{93,}},
                    {94, new HashSet<int>{94,}},
                    {95, new HashSet<int>{95,}},
                    {96, new HashSet<int>{96,}},
                    {97, new HashSet<int>{97,}},
                    {98, new HashSet<int>{98,}},
                    {99, new HashSet<int>{99,}},
                    {100, new HashSet<int>{100,}},
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