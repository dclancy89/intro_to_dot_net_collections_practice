using System;
using System.Collections.Generic;

namespace Collections_Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            /*------ARRAYS------*/

            // array of ints 0-9
            int[] numArray = {0,1,2,3,4,5,6,7,8,9};

            // string of names
            string[] stringArray = new string[4]{"Tim", "Martin", "Nikki", "Sara"};

            //bool array of alternating true/false
            bool[] boolArray = new bool[10];
            for(int i = 0; i < 10; i++) {
                if(i % 2 == 0) {
                    boolArray[i] = true;
                }
                else {
                    boolArray[i] = false;
                }
                Console.WriteLine(boolArray[i]);
            }

            Console.WriteLine();
            Console.WriteLine();


            /*------MULTIPLICATION TABLE------*/
            int[,] multiTable = new int[10,10];

            for(int i = 0; i < 10; i++) {
                for(int j = 0; j < 10; j++) {
                    multiTable[i,j] = (i+1) * (j+1);
                }
            }

            for(int i = 0; i < 10; i++) {
                Console.Write("[");
                for(int j = 0; j < 10; j++) {
                    Console.Write(multiTable[i,j]);
                    if(multiTable[i,j] < 10){
                        Console.Write(", ");
                    } else {
                        Console.Write(",");
                    }
                }
                Console.Write("]\n");
            }

            Console.WriteLine();
            Console.WriteLine();

            /*------LISTS------*/
            List<string> flavors = new List<string>();
            flavors.Add("Vanilla");
            flavors.Add("Chocolate");
            flavors.Add("Mint Chip");
            flavors.Add("Rocky Road");
            flavors.Add("Sherbert");

            Console.WriteLine(flavors.Count);

            Console.WriteLine(flavors[2]);
            flavors.RemoveAt(2);
            Console.WriteLine(flavors.Count);

            Console.WriteLine();
            Console.WriteLine();

            /*------Dictionaries------*/
            Dictionary<string,string> UserInfo = new Dictionary<string,string>();
            UserInfo.Add("Tim", "Chocolate");
            UserInfo.Add("Martin", "Mint Chip");
            UserInfo.Add("Nikki", "Sherbert");
            UserInfo.Add("Sara", "Rocky Road");

            foreach (KeyValuePair<string,string> entry in UserInfo)
            {
                Console.WriteLine(entry.Key + " - " + entry.Value);
            }


        }
    }
}
