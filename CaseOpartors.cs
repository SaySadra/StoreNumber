namespace Case
{
    public static class CaseOpartors
    {
        public static string inputString = "";
        public static int inputNum = 0;
        public static List<int> myIntNum = new List<int>();
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
            Console.WriteLine("PRESS(0)------Exit from APP.");
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
        public static void RemoveNumberFromIndex()
        {
            if (myIntNum.Count == 0)
            {
                Console.WriteLine("The list is empty!");
                Console.ReadKey();
            }
            else
            {
                Console.Write("please enter the index of number want to Remove : ");
                inputString = Console.ReadLine();
                if (int.TryParse(inputString, out _))
                {
                    myIntNum.RemoveAt(int.Parse(inputString));
                    Console.WriteLine("the index of {0} succesfully removed", int.Parse(inputString));
                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine("please enter the valid index!");
                    Console.ReadKey();
                    RemoveNumberFromIndex();
                }
            }

        }
        public static void ShowBiggestIntNum()
        {
            if (myIntNum.Count == 0)
            {
                Console.WriteLine("The list is empty!");
                Console.ReadKey();
            }
            else
            {
                int max = 0;
                foreach (int number in myIntNum)
                {

                    if (number > max)
                    {
                        max = number;
                    }
                }
                Console.WriteLine("the Biggest number stored is {0}", max);
                Console.ReadKey();
            }

        }
        public static void ShowLowestIntNum()
        {

            if (myIntNum.Count == 0)
            {
                Console.WriteLine("The list is empty!");
                Console.ReadKey();
            }
            else
            {
                int min = int.MaxValue;
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
        }
        public static void CountOfElements()
        {
            Console.WriteLine("the count of your all numbers is : {0}", myIntNum.Count);
            Console.ReadKey();
        }
        public static void SortListAscending()
        {
            if (myIntNum.Count == 0)
            {
                Console.WriteLine("The list is empty!");
                Console.ReadKey();
            }
            else
            {
                myIntNum.Sort();
                Console.WriteLine("your sorted number list is :");
                foreach (int number in myIntNum)
                {
                    Console.Write(number + " ");
                }
                Console.ReadKey();
            }

        }
        public static void ShowNumbersInRange()
        {
            if (myIntNum.Count == 0)
            {
                Console.WriteLine("The list is empty!");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("please enter your first number : ");
                string inputString1 = Console.ReadLine();
                Console.WriteLine("please enter your second number : ");
                string inputString2 = Console.ReadLine();
                if (int.TryParse(inputString1, out int inputNumber1) && int.TryParse(inputString2, out int inputNumber2))
                {
                    int lowerBound = Math.Min(inputNumber1, inputNumber2);
                    int upperBound = Math.Max(inputNumber1, inputNumber2);
                    bool isFound = false;
                    Console.WriteLine("the all numbers between {0} and {1} is : ", lowerBound, upperBound);
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
                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine("please a valid range!");
                    Console.ReadKey();
                    ShowNumbersInRange();
                }
            }
        }
        public static void EditIndex()
        {
            Console.Write("please enter your index do you want to edit : ");
            inputString = Console.ReadLine();
            if (int.TryParse(inputString, out _))
            {
                Console.Write("enter number you want : ");
                string inputString2 = Console.ReadLine();
                if (int.TryParse (inputString, out _))
                {
                    myIntNum[int.Parse(inputString)] = int.Parse(inputString2);
                    Console.WriteLine("the index of {0} is succesfully updated!",int.Parse(inputString));
                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine("please enter valid number!");
                    Console.ReadKey();
                }
            }
            else
            {
                Console.WriteLine("please enter valid index!");
                Console.ReadKey();
            }
        }
    }
}
