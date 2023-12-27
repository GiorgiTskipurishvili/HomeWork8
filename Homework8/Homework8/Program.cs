using System;
using System.Collections.Generic;

namespace Homework8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(Task1(49,71,2));
            //Console.WriteLine(Task1(2, 27, 4));

            /*2*/
            //Console.WriteLine(Task2("AAAAABAXSAS"));
            //Console.WriteLine("Enter the string of socks symbol");
            //string inputSocks = Console.ReadLine();
            //Console.WriteLine(Task2(inputSocks));

            /*3*/
            //Console.WriteLine(Task3("multipication","subtruction"));
            //Console.WriteLine("enter first string: ");
            //string inputFirstString = Console.ReadLine();
            //Console.WriteLine("enter second string");
            //string inputSecondString = Console.ReadLine();
            //Console.WriteLine(Task3(inputFirstString, inputSecondString));



            /*5*/
            //Task5(12345);



            /*6*/
            int[] nums1 = { 1, 2, 3, 1 };
            Console.WriteLine(Task6(nums1));

        }


        #region Task1
        /*დაწერეთ ფუნქცია რომელიც პარამეტრად მიიღებს   a, b, n 
            a. a - მინიმალური რიცხვი
            b. b - მაქსიმალური რიცხვი
            c. n - ხარისხი რომელშიც უნდა ავიყვანოთ რიცხვები
            იპოვეთ ყველა რიცხვი a -> b შუალედში რომლის n ხარისხი
            მოთავსებულია ამ ინტერვალში*/
        //static int Task1(int a, int b, int n)  
        //{
        //    int count = 0; 

        //    for (int i = a; i<= b; i++)
        //    {
        //        if (Math.Pow(i, n) >= a && Math.Pow(i, n) <= b)
        //        {
        //            count++;
        //        }
        //    }
        //    return count;
        //}

        #endregion

        #region Task2
        /*დაეხმარეთ პატარა ნიკუშას წინდების წყვილების პოვნაში. წყვილები
            აღნიშნულია ორი ერთნაირი სიმბოლოთი.*/
        //static int Task2(string socks)
        //{
        //    Dictionary<char, int> countOfSock = new Dictionary<char, int>();
        //    foreach(char sock in socks)
        //    {
        //        if (countOfSock.ContainsKey(sock))
        //        {
        //            countOfSock[sock]++;
        //        }
        //        else
        //        {
        //            countOfSock[sock] = 1;
        //        }
        //    }

        //    int countOfPair = 0;
        //    foreach (char count in countOfSock.Values)
        //    {
        //        countOfPair += count / 2;
        //    }
        //    return countOfPair;

        //}
        #endregion


        #region Task3
        /*დაწერეთ ფუნქცია რომელიც დააბრუნებს ყველა გრძელ საერთო
               ბოლოსართს ორ სტრინგს შორის .*/
        //static string Task3(string firstString, string secondString)
        //{
        //    for (int i = 0; i < firstString.Length; i++)
        //    {
        //        string end  = firstString.Substring(i);
        //        if (secondString.EndsWith(end))
        //        {
        //            return end;
        //        }
        //    }
        //    return "has not similar to last string";

        //}

        #endregion



        #region Task4



        #endregion



        #region Task5
        /*დაწერეთ ფუნქცია რომელიც დაბეჭდავს რიცხვში შემავალ ყოველ სიმბოლოს.*/

        static void Taks5(int number)
        {
            string numberString = number.ToString();

            for (int i = 0; i < numberString.Length; i++)
            {
                Console.Write(numberString[i]);

                if (i < numberString.Length - 1)
                {
                    Console.Write(" - ");
                }
            }

        }


        #endregion


        #region Task6
        /*დაწერეთ პროგრამა რომელიც შეამოწმებს შეიცავს თუ არა მასივი
           დუბლიკატებს*/
        static bool Task6(int[] number)
        {
            int length = number.Length;

            for (int i = 0;i < length-1;i++)
            {
                for(int j = i+1; j < length;j++)
                {
                    if (number[i] == number[j])
                    {
                        return true;
                    }
                }
            }
            return false;
        }



        #endregion


    }
}
