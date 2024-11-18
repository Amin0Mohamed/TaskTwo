using System.Runtime;

namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=============== TASK TWO =================");
            double average = 0;
            int sum = 0;
            List<int> list = new List<int>();
            bool condition = true;
            do
            {
                Console.WriteLine("========== CHOICE YOUR PROCESS =======");
                Console.WriteLine("P -  Print Number \n" +
                                  "A -  Add a  number \n" +
                                  "M -  Display mean of the numbers \n" +
                                  "S -  Display the smallest number \n" +
                                  "L -  Display the largest number \n" +
                                  "Q -  Quit \n" +
                                  "F -  Search for number \n" +
                                  "c -  Clear the list \n" +
                                  "d -  Delete element of list \n" +
                                  "o -  Sort element of list \n" +
                                  "v -  Reverse Sort element of list \n");

                Console.Write("Enter Your Choice:");
                char youChoice = char.ToUpper(char.Parse(Console.ReadLine()));
                switch (youChoice)
                {
                    case 'P':
                        if (list.Count == 0)
                            Console.WriteLine("[ ] - list is empty");
                        else
                        {
                            Console.Write("[ ");
                            for (int i = 0; i < list.Count; i++)
                            {
                                if (list[i] == list[^1])
                                    Console.Write(list[i] + " ");
                                else
                                    Console.Write(list[i] + " , ");
                            }
                            Console.WriteLine("]");
                        }
                        Console.WriteLine("-------------------------------------");
                        break;
                    case 'A':
                        Console.Write("Add Value to List : ");
                        int newVal = int.Parse(Console.ReadLine());
                        bool isExist = true;     // flag----------
                        //  start do not allow dublicate value in array "bouns"
                        for (int i = 0; i < list.Count; i++)
                        {
                            if (newVal == list[i])
                            {
                                Console.WriteLine("this number is already exist!!! .\n pls enter another number.");
                                isExist = false;
                                break;
                            }
                        }
                        //  end do not allow dublicate value in array "bouns"
                        if (isExist)
                        {
                            list.Add(newVal);
                            Console.WriteLine($"\"{list[^1]}\" is added");
                        }
                        Console.WriteLine("-------------------------------------");
                        break;
                    case 'M':
                        if (list.Count == 0)
                            Console.WriteLine("Unable to calculate the mean - no data");
                        else
                        {
                            for (int i = 0; i < list.Count; i++)
                            {
                                sum += list[i];
                            }
                            average = sum / list.Count;
                            Console.WriteLine($"The average of list is : {average}");
                        }
                        Console.WriteLine("-------------------------------------");
                        break;
                    case 'L':
                        if (list.Count == 0)
                            Console.WriteLine("Unable to determine the largest number - list is empty");
                        else
                        {
                            int max = list[0];
                            for (int i = 0; i < list.Count; i++)
                            {
                                if (max < list[i])
                                {
                                    max = list[i];
                                }
                            }
                            Console.WriteLine($"the largest number is : {max}");
                        }
                        Console.WriteLine("-------------------------------------");
                        break;
                    case 'S':
                        if (list.Count == 0)
                            Console.WriteLine("Unable to determine the smallest number - list is empty");
                        else
                        {
                            int min = list[0];
                            for (int i = 0; i < list.Count; i++)
                            {
                                if (min > list[i])
                                {
                                    min = list[i];
                                }
                            }  
                            Console.WriteLine($"the smallest number is : {min}");
                        }
                        Console.WriteLine("-------------------------------------");
                        break;
                    case 'Q':
                        Console.WriteLine("Goooooodbay");
                        condition = false;
                        break;
                    case 'F':
                        if (list.Count == 0)
                        {
                            Console.WriteLine("Unable to searching - list is empty");
                        }
                        else
                        {
                            Console.Write("enter the value you need search :");
                            int getNumberSearch = int.Parse(Console.ReadLine());
                            bool isSearch = true;
                            for (int i = 0; i < list.Count; i++)
                            {
                                if (getNumberSearch == list[i])
                                {
                                    Console.WriteLine($"the index of number is: {i}");
                                    isSearch = false;
                                    break;
                                }
                            }
                            if (isSearch)
                            {
                                Console.WriteLine($"the number is't on the list!");
                            }
                        }
                        Console.WriteLine("-------------------------------------");
                        break;
                    case 'C':
                        list.Clear();
                        Console.WriteLine("the list is empty");
                        Console.WriteLine("-------------------------------------");
                        break;
                    case 'D':
                        if (list.Count == 0)
                        {
                            Console.WriteLine("Unable to Delete - list is empty");
                        }
                        else
                        {
                            Console.Write("enter the value you need Delete :");
                            int getNumberDelete = int.Parse(Console.ReadLine());
                            bool isDelete = true;
                            for (int i = 0; i < list.Count; i++)
                            {
                                if (getNumberDelete == list[i])
                                {
                                    Console.WriteLine($"\"{list[i]}\" is deleted.");
                                    list.Remove(list[i]);
                                    isDelete = false;
                                }
                            }
                            if (isDelete)
                            {
                                Console.WriteLine($"the number is not on the list!");
                            }

                        }
                        Console.WriteLine("-------------------------------------");
                        break;
                    case 'O':
                        int swap;
                        if (list.Count == 0)
                        {
                            Console.WriteLine("Unable to Sort - list is empty");
                        }
                        else
                        {
                            // { 5,3,10,9,7,66,1,0}
                            for (int i = 0; i < list.Count-1; i++)
                            {
                                for (int j = 0; j < list.Count-1; j++)
                                {
                                    if (list[j] > list[j+1])
                                    {
                                        swap = list[j + 1];
                                        list[j + 1] = list[j];
                                        list[j] = swap;
                                    }
                                }
                            }
                            Console.Write("list after sort : ");
                            Console.Write("[ ");
                            for (int i = 0; i < list.Count; i++)
                            {
                                if (list[i] == list[^1])
                                    Console.Write(list[i] + " ");
                                else
                                    Console.Write(list[i] + " , ");
                            }
                            Console.WriteLine("]");
                        }
                        Console.WriteLine("-------------------------------------");
                        break;
                    case 'V':
                        int revSwap;
                        if (list.Count == 0)
                        {
                            Console.WriteLine("Unable to reverse sort - list is empty");
                        }
                        else
                        {
                            for (int i = list.Count-1; i >= 1; i--)
                            {
                                for (int j = list.Count-1; j >= 1; j--)
                                {
                                    if (list[j] > list[j - 1])
                                    {
                                        revSwap = list[j - 1];
                                        list[j - 1] = list[j];
                                        list[j] = revSwap;
                                    }
                                }
                            }
                            Console.Write("list after reverse sort : ");
                            Console.Write("[ ");
                            for (int i = 0; i < list.Count; i++)
                            {
                                if (list[i] == list[^1])
                                    Console.Write(list[i] + " ");
                                else
                                    Console.Write(list[i] + " , ");   
                            }
                            Console.WriteLine("]");
                        }
                        Console.WriteLine("-------------------------------------");
                        break;
                    default:
                        Console.WriteLine("Unknow selection, please try again");
                        Console.WriteLine("-------------------------------------");
                        break;

                }

            } while (condition);
        }
    }
}
