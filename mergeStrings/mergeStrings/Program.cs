using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mergeStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            start();
        }

        public static void start()
        {
            int option = 0;
            string word1 = "";
            string word2 = "";
            List<char> chr1 = new List<char>();
            List<char> chr2 = new List<char>();
            

            option = DisplayMenu();
            string[] tempArray = getStrings(option).Split('-');
            word1 = tempArray[0];
            word2 = tempArray[1];

            Console.WriteLine("First String: " + word1);
            Console.WriteLine("Second String String: " + word2);

            chr1 = setCharLists(word1, chr1);
            chr2 = setCharLists(word2, chr2);
            mergeStrings(chr1, chr2);

            doWecontinue();
        }

        public static int DisplayMenu()
        {
            Console.WriteLine("MERGE STRINGS");
            Console.WriteLine();
            Console.WriteLine("This tool will let you merge 2 different words.");
            Console.WriteLine();
            Console.WriteLine("What would you liek to execute:");
            Console.WriteLine("1. Run 'Test Case 1' (abc-efg)");
            Console.WriteLine("2. Run 'Test Case 2' (abc-efg123)");
            Console.WriteLine("3. Run 'Test Case 3' (abc123456-efg)");
            Console.WriteLine("4. Enter 2 random words");
            Console.WriteLine("5. Exit");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Select ypur option:");
            var result = Console.ReadLine();
            return Convert.ToInt32(result);
        }

        public static List<char> setCharLists(string word, List<char> list)
        {
            foreach (char ch in word)
            {
                list.Add(ch);
            }
          
            return list;
        }

        public static string mergeStrings(List<char> list1, List<char> list2)
        {
            int count = 0;
            string newString = "";
            int largestList = getLargestList(list1, list2);
            Console.WriteLine("Merging...");

            while (count < largestList)
            {
                if (count < list1.Count())
                {
                    newString = newString + list1[count];
                    Console.WriteLine("->" + newString);
                }
                if (count < list2.Count())
                {
                    newString = newString + list2[count];
                    Console.WriteLine("->" + newString);
                }
                count++;
            }

            Console.WriteLine("Merge Result: " + newString);

            return newString;
        }

        public static int getLargestList(List<char> list1, List<char> list2)
        {
            int number = 0;
            if (list1.Count > list2.Count)
            {
                number = list1.Count;
            }
            if (list1.Count < list2.Count)
            {
                number = list2.Count;
            }
            if (list1.Count == list2.Count)
            {
                number = list2.Count;
            }

            return number;
        }

        public static void doWecontinue()
        {
            Console.WriteLine();
            Console.WriteLine("Go back to Main Menu(M) - Exit(X)");
            var result = Console.ReadLine();
            if (result == "M" || result == "m" || result == "X" || result == "x")
            {
                if (result == "M" || result == "m")
                {
                    Console.Clear();
                    start();
                }
                if (result == "X" || result == "x")
                {
                    Environment.Exit(0);
                }
            }
            else 
            {
                doWecontinue();
            }    
        }

        public static string getStrings(int option)
        {
            Console.Clear();
            string words = "";

            switch (option)
            {
                case 1:
                    words = "abc-efg";
                    break;
                case 2:
                    words = "abc-efg123";
                    break;
                case 3:
                    words = "abc123456-efg";
                    break;
                case 4:
                    Console.WriteLine("Please enter word 1:");
                    words = Console.ReadLine() + "-";
                    Console.WriteLine("Please enter word 2:");
                    words += Console.ReadLine();
                    break;
                case 5:
                    Environment.Exit(0);
                    break;
                default:
                    Console.Clear();
                    start();
                    break;
            }

            return words;
        }
    }
}
