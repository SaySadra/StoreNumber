using Case;

namespace MidTermProject
{
    internal static class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                CaseOpartors.SetMenu();

                if (int.TryParse(CaseOpartors.inputString, out _) && int.Parse(CaseOpartors.inputString) > 0 && int.Parse(CaseOpartors.inputString) <= 10)
                {
                    switch (int.Parse(CaseOpartors.inputString))
                    {
                        case 1:
                            {
                                CaseOpartors.StoreNumber();
                            }
                            break;
                        case 2:
                            {
                                CaseOpartors.IndexNumberShow();
                            }
                            break;
                        case 3:
                            {
                                CaseOpartors.ShowAllElements();
                            }
                            break;
                        case 4:
                            {
                                CaseOpartors.RemoveNumberFromIndex();
                            }
                            break;
                        case 5:
                            {
                                CaseOpartors.ShowBiggestIntNum();
                            }
                            break;
                        case 6:
                            {
                                CaseOpartors.ShowLowestIntNum();
                            }
                            break;
                        case 7:
                            {
                                CaseOpartors.CountOfElements();
                            }
                            break;
                        case 8:
                            {
                                CaseOpartors.SortListAscending();
                            }
                            break;
                        case 9:
                            {
                                CaseOpartors.ShowNumbersInRange();
                            }
                            break;

                    }

                }
                else if (CaseOpartors.inputString == "0")
                {
                    Console.WriteLine("!!!!!!!!!!!The Program ended!!!!!!!!!!!!!!");
                    break;
                }
                else
                {
                    Console.WriteLine("enter valid option!!");
                    Console.ReadKey();
                }

            }
        }
    }
}
