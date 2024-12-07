namespace MidTermProject
{
    internal static class Program
    {
        public static string inputString = "";
        public static int inputMenu = 0;
        public static List<int> myIntNum = new List<int>();

         static void Main(string[] args)
        {

            while(true)
            {
                SetMenu();

                if (int.TryParse(inputString, out _))
                {
                    switch (int.Parse(inputString))
                    {
                        case 1:
                            {
                                StoreNumber();
                            }
                            break;
                        case 2:
                            {
                                IndexNumberShow();
                            }
                            break;
                        case 3:
                            {
                                ShowAllElements();
                            }
                            break;
                        case 4:
                            {
                                Console.WriteLine("please enter the index of number want to Remove!");
                                inputString = Console.ReadLine();
                                if (int.TryParse(inputString, out int inputNumber))
                                {
                                    myIntNum.RemoveAt(inputNumber);
                                    Console.WriteLine("the index of {0} succesfully removed", inputNumber);
                                    Console.ReadKey();
                                }
                                else
                                {
                                    Console.WriteLine("please enter the valid index!");
                                    Console.ReadKey();
                                    continue;
                                }
                            }
                            break;
                        case 5:
                            {
                                Console.WriteLine("the Biggest number stored is {0}", ShowBiggestIntNum());
                                Console.ReadKey();
                            }
                            break;
                        case 6:
                            {
                                ShowLowestIntNum();
                            }
                            break;
                        case 7:
                            {
                                ShowAllElements();
                                Console.ReadKey();
                            }
                            break;
                        case 8:
                            {
                                SortListAscending();
                                Console.ReadKey();
                            }
                            break;
                        case 9:
                            {
                                Console.WriteLine("please enter your first number : ");
                                string inputString1 = Console.ReadLine();
                                Console.WriteLine("please enter your second number : ");
                                string inputString2 = Console.ReadLine();
                                if (int.TryParse(inputString1, out int inputNumber1) && int.TryParse(inputString2, out int inputNumber2))
                                {
                                    ShowNumbersInRange(inputNumber1, inputNumber2);
                                    Console.ReadKey();
                                }
                                else
                                {
                                    Console.WriteLine("please enter a valid range!");
                                    Console.ReadKey();
                                }
                            }
                            break;

                    }

                }
                else
                {
                    Console.WriteLine("enter valid option!!");
                    Console.ReadKey();
                }

            }
        }
        public static void SetMenu()
        {
            Console.Clear();
            Console.WriteLine("PRESS(1)------Get and Add int number to your list.");
            Console.WriteLine("PRESS(2)------Find your int number.");
            Console.WriteLine("PRESS(3)------Show all numbers you entered.");
            Console.WriteLine("PRESS(4)------Delete your int number.");
            Console.WriteLine("PRESS(5)------Show the biggest int number");
            Console.WriteLine("PRESS(6)------Show the lowest int number");
            Console.WriteLine("PRESS(7)------Show all element you entered.");
            Console.WriteLine("PRESS(8)------Sort the element by low to high.");
            Console.WriteLine("PRESS(9)------Show all element between two number you entered.");
            Console.WriteLine("PRESS(10)------Edit your int number.");
            Console.WriteLine("PRESS(01)------Exit from APP.");
            Console.Write("which option do you want : ");
            inputString = Console.ReadLine();
        }
        public static void StoreNumber()
        {
            Console.Write("please enter your number you want to add : ");
            inputString = Console.ReadLine();
            if (int.TryParse(inputString, out _))
            {
                myIntNum.Add(int.Parse(inputString));
                Console.WriteLine("Your int number succesfully added!");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("please enter the valid int number!");
                Console.ReadKey();
                StoreNumber();
            }
        }
        public static void IndexNumberShow()
        {
            Console.Write("please enter the index of number do you want to Show : ");
            inputString = Console.ReadLine();
            if (int.TryParse(inputString, out _) && int.Parse(inputString) <= myIntNum.Count)
            {
                Console.WriteLine("the number stored in index of {0} is {1}", int.Parse(inputString), myIntNum[int.Parse(inputString)]);
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("please enter the valid index!");
                Console.ReadKey();
                IndexNumberShow();
            }
        }
        public static void ShowAllElements()
        {
            if (myIntNum.Count == 0)
            {
                Console.WriteLine("The list is empty!");
                Console.ReadKey();
            }
            else
            {
                int counter = 0;
                foreach (int number in myIntNum)
                {
                    Console.WriteLine("the index of {0} is : {1}", counter, number);
                    counter++;
                }
                Console.ReadKey();
            }
        }
        public static int ShowBiggestIntNum()
        {
            if (myIntNum.Count == 0)
            {
                Console.WriteLine("The list is empty!");
            }
            int max = int.MinValue;
            foreach (int number in myIntNum)
            {

                if (number > max)
                {
                    max = number;
                }
            }
            return max;
        }
        public static void ShowLowestIntNum()
        {
            int min = int.MaxValue;
            if (myIntNum.Count != 0)
            {
                foreach (int number in myIntNum)
                {

                    if (number < min)
                    {
                        min = number;
                    }
                }
                Console.WriteLine("the Lowest number stored is {0}", min);
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("your list is empty!");
                Console.ReadKey();
            }
        }
        public static void ShowNumbersInRange(int firstNumber, int secondNumber)
        {
            if (myIntNum.Count == 0)
            {
                Console.WriteLine("The list is empty!");
            }
            int lowerBound = Math.Min(firstNumber, secondNumber);
            int upperBound = Math.Max(firstNumber, secondNumber);
            bool isFound = false;
            foreach (int number in myIntNum)
            {
                if (number >= lowerBound && number <= upperBound)
                {
                    Console.Write(number + " ");
                    isFound = true;
                }
            }
            if (!isFound)
            {
                Console.WriteLine("not found any number between {0}, and {1}", lowerBound, upperBound);
            }
        }
        public static void SortListAscending()
        {
            if (myIntNum.Count == 0)
            {
                Console.WriteLine("The list is empty!");
            }
            myIntNum.Sort();
            foreach (int number in myIntNum)
            {
                Console.WriteLine(number + " ");
            }

        }
    }
}
