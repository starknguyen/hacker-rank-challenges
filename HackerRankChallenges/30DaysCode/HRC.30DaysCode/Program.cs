using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static HRC.Code30Days.BinarySearchTree;
using static HRC.Code30Days.InheritanceProblem;
using static HRC.Code30Days.LinkedListDuplicate;
using static HRC.Code30Days.Scope;

namespace HRC.Code30Days
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //testBinaryNumbers();
                //test2DArrayHourGlass();
                //testInheritance();
                //testClassScope();
                //testStackQueuePalindrome();
                //testDivisorSumInterface();
                //testBubbleSortAscending();
                //testPrintArrayGeneric();
                //testBinarySearchTreeHeight();
                //testBinarySearchTreeLevelOrderTraversal();
                //testLinkedListRemoveDuplicate();
                //testPrimalityCheck();
                //testNestedLogic();

                testVerySimpleLinqRegex();
            }
            catch (Exception ex)
            {
                Console.WriteLine("ERROR - " + ex);
            }

            Console.ReadKey();
        }


        #region Test Methods

        private static void testVerySimpleLinqRegex()
        {
            int N = Convert.ToInt32(Console.ReadLine());
            List<string> firstNames = new List<string>();

            for (int NItr = 0; NItr < N; NItr++)
            {
                string[] firstNameEmailID = Console.ReadLine().Split(' ');

                string firstName = firstNameEmailID[0];
                string emailID = firstNameEmailID[1];
                if (!emailID.EndsWith("@gmail.com"))
                    continue;
                firstNames.Add(firstName);
            }

            firstNames.Sort();
            firstNames.ForEach(fn => Console.WriteLine(fn));
        }


        private static void testNestedLogic()
        {
            string recvDateStr = Console.ReadLine();
            var recvDateArr = recvDateStr.Split(' ').Select(s => Convert.ToInt32(s)).ToArray();
            DateTime recvDate = new DateTime(recvDateArr[2], recvDateArr[1], recvDateArr[0]);

            string dueDateStr = Console.ReadLine();
            var dueDateArr = dueDateStr.Split(' ').Select(s => Convert.ToInt32(s)).ToArray();
            DateTime dueDate = new DateTime(dueDateArr[2], dueDateArr[1], dueDateArr[0]);

            var nl = new NestedLogic();
            Console.WriteLine(nl.CalculateFine(dueDate, recvDate));
        }


        private static void testPrimalityCheck()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            uint[] inputArr = new uint[n];
            for (int i = 0; i < n; i++)
            {
                inputArr[i] = Convert.ToUInt32(Console.ReadLine());
            }

            var primalityCheck = new PrimeOptimization();
            for (int i = 0; i < n; i++)
            {
                bool isPrime = primalityCheck.IsPrimeOptimize1(inputArr[i]);
                Console.WriteLine($"Check {inputArr[i]} primality in {primalityCheck.BenchMarkCount} steps");
                if (isPrime)
                    Console.WriteLine("Prime");
                else
                    Console.WriteLine("Not prime");
            }            
        }


        private static void testLinkedListRemoveDuplicate()
        {
            Node head = null;
            int T = Int32.Parse(Console.ReadLine());
            while (T-- > 0)
            {
                int data = Int32.Parse(Console.ReadLine());
                head = insert(head, data);
            }
            head = removeDuplicates(head);
            display(head);
        }


        private static void testBinarySearchTreeLevelOrderTraversal()
        {
            BinarySearchTree bst;
            BSTNode root;
            initializeBST(out bst, out root);

            bst.GetLevelOrderTraversal(root);
        }


        private static void testBinarySearchTreeHeight()
        {
            BinarySearchTree bst;
            BSTNode root;
            initializeBST(out bst, out root);
            int height = bst.GetHeight(root);
            Console.WriteLine(height);
        }


        private static void initializeBST(out BinarySearchTree bst, out BSTNode root)
        {
            bst = new BinarySearchTree();
            root = null;
            int T = Int32.Parse(Console.ReadLine());
            while (T-- > 0)
            {
                int data = Int32.Parse(Console.ReadLine());
                root = bst.Insert(root, data);
            }
        }


        private static void testPrintArrayGeneric()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int[] intArray = new int[n];
            for (int i = 0; i < n; i++)
            {
                intArray[i] = Convert.ToInt32(Console.ReadLine());
            }

            n = Convert.ToInt32(Console.ReadLine());
            string[] stringArray = new string[n];
            for (int i = 0; i < n; i++)
            {
                stringArray[i] = Console.ReadLine();
            }

            PrintArray<Int32>(intArray);
            PrintArray<String>(stringArray);
        }


        private static void PrintArray<T>(T[] array)
        {
            foreach (var item in array)
            {
                Console.WriteLine(item);
            }
        }


        private static void testBubbleSortAscending()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string[] a_temp = Console.ReadLine().Split(' ');
            int[] a = Array.ConvertAll(a_temp, Int32.Parse);
            SimpleBubbleSort bubbleSort = new SimpleBubbleSort();
            bubbleSort.SortAscending(a);
        }


        private static void testDivisorSumInterface()
        {
            int n = Int32.Parse(Console.ReadLine());
            AdvancedArithmetic myCalculator = new DivisorSumInterface();
            int sum = myCalculator.divisorSum(n);
            Console.WriteLine("I implemented: AdvancedArithmetic\n" + sum);
        }


        private static void testStackQueuePalindrome()
        {
            // read the string s.
            string s = Console.ReadLine();

            // create the Solution class object p.
            StackQueuePalindrome obj = new StackQueuePalindrome();

            // push/enqueue all the characters of string s to stack.
            foreach (char c in s)
            {
                obj.pushCharacter(c);
                obj.enqueueCharacter(c);
            }

            bool isPalindrome = true;

            // pop the top character from stack.
            // dequeue the first character from queue.
            // compare both the characters.
            for (int i = 0; i < s.Length / 2; i++)
            {
                if (obj.popCharacter() != obj.dequeueCharacter())
                {
                    isPalindrome = false;

                    break;
                }
            }

            // finally print whether string s is palindrome or not.
            if (isPalindrome)
            {
                Console.Write("The word, {0}, is a palindrome.", s);
            }
            else
            {
                Console.Write("The word, {0}, is not a palindrome.", s);
            }
        }


        private static void testClassScope()
        {
            Convert.ToInt32(Console.ReadLine());

            int[] a = Console.ReadLine().Split(' ').Select(x => Convert.ToInt32(x)).ToArray();

            Difference d = new Difference(a);
            d.computeDifference();

            Console.Write(d.maximumDifference);
        }


        private static void testInheritance()
        {
            string[] inputs = Console.ReadLine().Split();
            string firstName = inputs[0];
            string lastName = inputs[1];
            int id = Convert.ToInt32(inputs[2]);
            int numScores = Convert.ToInt32(Console.ReadLine());
            inputs = Console.ReadLine().Split();
            int[] scores = new int[numScores];
            for (int i = 0; i < numScores; i++)
            {
                scores[i] = Convert.ToInt32(inputs[i]);
            }

            Student s = new Student(firstName, lastName, id, scores);
            s.printPerson();
            Console.WriteLine("Grade: " + s.Calculate() + "\n");
        }

        private static void test2DArrayHourGlass()
        {
            //int[][] arr = new int[6][];

            //for (int i = 0; i < 6; i++)
            //{
            //    arr[i] = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));
            //}

            // SAMPLE DATA
            int[][] arr = new int[][]
            {
                    new int[] { 1, 1, 1, 0, 0, 0 },
                    new int[] { 0, 1, 0, 0, 0, 0 },
                    new int[] { 1, 1, 1, 0, 0, 0 },
                    new int[] { 0, 0, 2, 4, 4, 0 },
                    new int[] { 0, 0, 0, 2, 0, 0 },
                    new int[] { 0, 0, 1, 2, 4, 0 },
            };

            var hourGlass = new TwoDimArrayHourGlass();
            var max = hourGlass.GetMaxHourGlassSum(arr);
            Console.WriteLine(max);
        }


        private static void testBinaryNumbers()
        {
            var input = Convert.ToInt32(Console.ReadLine());

            var bn = new BinaryNumbers();
            var result = bn.GetMaxNumberOfOne(input);
            Console.WriteLine(result);
        }

        #endregion

    }
}
