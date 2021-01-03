using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;


namespace Sweeft
{
    class SweeftTasks
    {
        static void Main()
        {
            //0 მთავარი
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Hello Sweeftdigital!\nPlease enter one of the numbers to choose the task\nTask 1 (isPalindrome) - 1\nTask 2 (minSplit) -2\nTask 3 (notContains) - 3\nTask 4 (isProperly) - 4\nTask 5 (countVariants) - 5\nTask 6 (Structure) - 6\nTask 8 (exchangeRate) - 8");
            string number = Console.ReadLine();
            if (number == "1")
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Enter 0 to go back");
                Console.ForegroundColor = ConsoleColor.White;
                Task1();
            }
            if (number == "2")
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Enter 0 to go back");
                Console.ForegroundColor = ConsoleColor.White;
                Task2();
            }
            if (number == "3")
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Enter 0 to go back");
                Console.ForegroundColor = ConsoleColor.White;
                Task3();
            }
            if (number == "4")
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Enter 0 to go back");
                Console.ForegroundColor = ConsoleColor.White;
                Task4();
            }
            if (number == "5")
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Enter 0 to go back");
                Console.ForegroundColor = ConsoleColor.White;
                Task5();
            }
            if (number == "6")
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Enter 0 to go back");
                Console.ForegroundColor = ConsoleColor.White;
                Task6();
            }
            if (number == "8")
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Enter 0 to go back");
                Console.ForegroundColor = ConsoleColor.White;
                Task8();
            }
            else
            {
                Console.Clear();
                Main();
            }
        }
        static void Task1()
        {
            //1 პალინდრომი
            Console.WriteLine("Task N1 - Enter any word and check if it's Palindrome or not");
            string text = Console.ReadLine();
            if (text == "0")
            {
                Console.Clear();
                Main();
            }
            else
            {
                isPalindrome(text);
                if (isPalindrome(text) is true)
                {
                    Console.WriteLine("The word is a Palindrome");
                }
                else
                {
                    Console.WriteLine("The word is not a Palindrome");
                }
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Enter 1 to try again");
                Console.ForegroundColor = ConsoleColor.White;
                string number = Console.ReadLine();
                if (number == "1")
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Enter 0 to go back");
                    Console.ForegroundColor = ConsoleColor.White;
                    Task1();
                }
                else
                {
                    Console.Clear();
                    Main();
                }
            }

            static Boolean isPalindrome(String text)
            {
                if (text.SequenceEqual(text.Reverse()))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
        static void Task2()
        {
            // მონეტები (ნელი კოდია, მაგრამ უნივერსალური გამომივიდა და დავტოვე (ნებისმიერი სიდიდის თეთრებზე იმუშავებს))
            Console.WriteLine("Task N2 - Enter any number and check the minimum number of coins with which we can exchange it (enter comma separated array please)");
            int amount = Convert.ToInt32(Console.ReadLine());
            if (amount == 0)
            {
                Console.Clear();
                Main();
            }
            else
            {
                int answer = minSplit(amount);
                if (answer == 0)
                {
                    Console.WriteLine("Please enter positive integers only");
                }
                else
                {
                    Console.WriteLine("The answer is " + answer);
                }
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Enter 1 to try again");
                Console.ForegroundColor = ConsoleColor.White;
                string number = Console.ReadLine();
                if (number == "1")
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Enter 0 to go back");
                    Console.ForegroundColor = ConsoleColor.White;
                    Task2();
                }
                else
                {
                    Console.Clear();
                    Main();
                }
            }

            static int minSplit(int amount)
            {
                int divided50 = 0;
                int cut50 = 0;
                int remaining50 = 0;
                int diveded20 = 0;
                int cut20 = 0;
                int remaining20 = 0;
                int diveded10 = 0;
                int cut10 = 0;
                int remaining10 = 0;
                int diveded5 = 0;
                int cut5 = 0;
                int remaining5 = 0;
                int answer = 0;
                int lastremaining = 0;
                if (amount > 50)
                {
                    divided50 = amount / 50;
                    cut50 = divided50 * 50;
                    remaining50 = amount - cut50;
                }
                else
                {
                    remaining50 = amount;
                }
                if (remaining50 > 20)
                {
                    diveded20 = remaining50 / 20;
                    cut20 = diveded20 * 20;
                    remaining20 = remaining50 - cut20;
                }
                else
                {
                    remaining20 = remaining50;
                }
                if (remaining20 > 10)
                {
                    diveded10 = remaining20 / 10;
                    cut10 = diveded10 * 10;
                    remaining10 = remaining20 - cut10;
                }
                else
                {
                    remaining10 = remaining20;
                }
                if (remaining10 > 5)
                {
                    diveded5 = remaining10 / 5;
                    cut5 = diveded5 * 5;
                    remaining5 = remaining10 - cut5;
                }
                else
                {
                    remaining5 = remaining10;
                }
                if (remaining5 > 0)
                {
                    lastremaining = remaining5;
                }
                else
                {
                    answer = 0;
                }
                answer = divided50 + diveded20 + diveded10 + diveded5 + lastremaining;
                //Console.WriteLine(divided50 + " times 50, " + diveded20 + " times 20, " + diveded10 + " times 10, " + diveded5 + " times 5, " + lastremaining + " times 1"); შეგიძლიათ შეამოწმოთ ამით.
                return answer;
            }
        }
        static void Task3()
        {
            // მასივი
            Console.WriteLine("Task N3 - Enter the array to receive the smallest positive integer, which isn't included in the array (example: 45,2,41,3,5351,1,-4...)");
            string strarray = Console.ReadLine();
            string[] separate = strarray.Split(',');
            int[] nums = Array.ConvertAll(separate, int.Parse);
            var posints = nums.Where(i => i > 0);
            int[] array = posints.Distinct().ToArray();
            array = array.Concat(new[] { 1000 }).ToArray();
            Array.Sort(array);
            int answer = notContains(array);
            if (array[0] == 0)
            {
                Console.Clear();
                Main();
            }
            else
            {
                Console.WriteLine("The answer is " + answer);
            }
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Enter 1 to try again");
            Console.ForegroundColor = ConsoleColor.White;
            string number = Console.ReadLine();
            if (number == "1")
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Enter 0 to go back");
                Console.ForegroundColor = ConsoleColor.White;
                Task3();
            }
            else
            {
                Console.Clear();
                Main();
            }

            static int notContains(int[] array)
            {
                if (array.Length == 1)
                {
                    if (array[0] != 1)
                    {
                        return 1;
                    }
                    else
                    {
                        return 2;
                    }
                }
                else
                {
                    for (int i = 0; i < array.Length; i++)
                    {
                        var j = i + 1;
                        if (array[i] != j)
                        {
                            return j;
                        }
                    }
                    return -1;
                }
            }
        }
        static void Task4()
        {
            // ფრჩხილები
            Console.WriteLine("Task N4 - Enter the String, which only contaions '(' and ')' symbols and check if its mathematically correct");
            string sequence = Console.ReadLine();
            if (sequence == "0")
            {
                Console.Clear();
                Main();
            }
            else
            {
                isProperly(sequence);
                if (isProperly(sequence) is true)
                {
                    Console.WriteLine("The sequence is correct");
                }
                else
                {
                    Console.WriteLine("The sequence is incorrect");
                }
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Enter 1 to try again");
                Console.ForegroundColor = ConsoleColor.White;
                string number = Console.ReadLine();
                if (number == "1")
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Enter 0 to go back");
                    Console.ForegroundColor = ConsoleColor.White;
                    Task4();
                }
                else
                {
                    Console.Clear();
                    Main();
                }
            }

            static Boolean isProperly(String sequence)
            {
                char[] array = sequence.ToCharArray();
                var right = 0;
                var left = 0;
                for (var i = 0; i < array.Length; i++)
                {
                    if (array[i] == '(')
                    {
                        right++;
                    }
                    else
                    {
                        left++;
                        if (right < left)
                        {
                            return false;
                        }
                    }
                }
                if (right == left)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
        static void Task5()
        {
            // კიბეები (მალევე მივხვდი რომ პასუხად ფიბონაჩის რიცხვებს იძლეოდა (+1) და ადრე დაწერილი ფიბონაჩის კოდი გადავაკეთე) 
            Console.WriteLine("Task N5 - Enter a number that represents the number of stairs and let the program calculate how many variants are there to rich the mentioned stair if you can walk up with 1 or 2 steps at a time");
            int stairsCount = Convert.ToInt32(Console.ReadLine());
            int answer = countVariants(stairsCount);
            if (stairsCount == 0)
            {
                Console.Clear();
                Main();
            }
            else
            {
                Console.WriteLine("The answer is " + answer);
            }
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Enter 1 to try again");
            Console.ForegroundColor = ConsoleColor.White;
            string number = Console.ReadLine();
            if (number == "1")
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Enter 0 to go back");
                Console.ForegroundColor = ConsoleColor.White;
                Task5();
            }
            else
            {
                Console.Clear();
                Main();
            }

            static int countVariants(int stairsCount)
            {
                int number = stairsCount + 1;
                int[] Fib = new int[number + 1]; // აქ -1 რომ იყოს +1-ის ნაცვლად ფიბონაჩის მიმდევრობა იქნებოდა (0იდან))
                Fib[0] = 0;
                Fib[1] = 1;
                for (int i = 2; i <= number; i++)
                {
                    Fib[i] = Fib[i - 2] + Fib[i - 1];
                }
                return Fib[number];
            }
        }
        static void Task6()
        {
            Console.WriteLine("Task N6 - The Structure (I chose queue)");
            structure();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Enter 1 to try again");
            Console.ForegroundColor = ConsoleColor.White;
            string number = Console.ReadLine();
            if (number == "1")
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Enter 0 to go back");
                Console.ForegroundColor = ConsoleColor.White;
                Task6();
            }
            else
            {
                Console.Clear();
                Main();
            }

            static void structure()
            {
                Queue<string> numbers = new Queue<string>();
                numbers.Enqueue("one");
                numbers.Enqueue("two");
                numbers.Enqueue("three");
                numbers.Enqueue("four");
                numbers.Enqueue("five");
                foreach (string number in numbers)
                {
                    Console.WriteLine(number);
                }
                Console.WriteLine("\nDequeuing '{0}'", numbers.Dequeue()); // ინდექსით 0 იშლება
                Console.WriteLine("The next number in the queue is: {0}", numbers.Peek());  // წინა წაშალა გადავიდა შემდეგზე
                Console.WriteLine("Dequeuing '{0}'", numbers.Dequeue()); // ინდექსით 0 იშლება და ასე შემდეგ..
                //Console.WriteLine("Dequeuing '{0}'", numbers.Dequeue());
                //Console.WriteLine("Dequeuing '{0}'", numbers.Dequeue());
                Queue<string> queueAfter = new Queue<string>(numbers.ToArray());
                Console.WriteLine("\nThe queue after we deleted elements:"); // საბოლოოდ ასეთი რიგი გვრჩება
                foreach (string number in queueAfter)
                {
                    Console.WriteLine(number);
                }
            }
        }
        static void Task8()
        {
            Console.WriteLine("Task N8 - Enter 2 currency indicators to receive the exchange rate between them");
            // data წამოვიღე და დაparseვაც დავიწყე, მაგრამ ვეღარ ვასწრებ დასრულებას, ქალაქგარეთ ვიყავი და რამდენიმე საათი დავუთმე რეალურად ყველაფერს.
            //string from = Console.ReadLine();
            //string to = Console.ReadLine();
            //string response = new WebClient().DownloadString("http://www.nbg.ge/rss.php");
            //string data = response.Substring(647, 7009);
            //string tds = data.Trim();
            //string tds2 = tds.Replace("</tr>", "");
            //string tds3 = tds2.Replace("</td>", "");
            //string[] trs = tds3.Split("<tr>");
            //List<string> curr = new List<string>();
            //List<string> currency = new List<string>();
            //List<string> rate = new List<string>();
            //List<string> y = new List<string>();
            //List<string> z = new List<string>();
            //for (var i = 1; i < trs.Length; i++)
            //{
            //    string[] tds1 = trs[i].Split("<td>");
            //    currency.Add(tds1[1]);
            //    rate.Add(tds1[3]);
            //    string[] x = tds1[2].Split(" ");
            //    y.Add(x[0]);
            //}
            //var currencyarray = currency.ToArray();
            //Console.WriteLine(currencyarray[1]);
            //int keyindex = currencyarray.FindIndex(x => x == "AUD");
            //Console.WriteLine(keyindex);
            // tst = currency.ToArray();
            //int index = Array.IndexOf(tst, "AED");
            //Console.WriteLine(String.Join(Environment.NewLine, currency));
            //Console.WriteLine(String.Join(Environment.NewLine, rate));
            //Console.WriteLine(String.Join(Environment.NewLine, y));
            //Console.WriteLine(String.Join(Environment.NewLine, z));
            //foreach (var value in tst)
            //{
            //Console.WriteLine(value);
            //}
            //.WriteLine(currency.Count);
            //Console.WriteLine(index);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Enter 1 to try again");
            Console.ForegroundColor = ConsoleColor.White;
            string number = Console.ReadLine();
            if (number == "1")
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Enter 0 to go back");
                Console.ForegroundColor = ConsoleColor.White;
                Task8();
            }
            else
            {
                Console.Clear();
                Main();
            }

            //static Double exchangeRate(String from, String to)
            //{
            //    var response = new WebClient().DownloadString("http://www.nbg.ge/rss.php");
            //    Console.WriteLine(response);
            //}
        }
    }
}