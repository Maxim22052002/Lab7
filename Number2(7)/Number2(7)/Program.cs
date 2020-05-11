using System;
using System.IO;

namespace Number2_7_
{
    class Program
    {
        static void Main(string[] args)
        {
            bool mark = true;
            while (mark)
            {
                Console.WriteLine("Выберите вид массива:\n1)Массив из 100000 элементов, сгенерированный случайным образом\n2)Отсортированный массив из 100000 элементов по возрастанию\n3)Отсортированный массив из 100000 элементов по убыванию\n4)Выход");
                string result = Console.ReadLine();
                Console.Clear();
                switch (result)
                {
                    case "1":
                        int[] array = GivenArray();
                        Console.WriteLine("Выберите алгоритм сортировки:\n1)Сортировка выбором\n2)Сортировка вставками\n3)Сортировка пузырьком\n4)Сортировка шейкером\n5)Сортировка Шелла\n6)Выход");
                        string algoritms = Console.ReadLine();
                        Console.Clear();
                        switch (algoritms)
                        {
                            case "1":
                                TestingSelectionSort(array, 0, 0);
                                Tester(array);
                                TransferToFile(array);
                                Console.ReadLine();
                                Console.Clear();
                                break;
                            case "2":
                                TestingInsertionSort(array, 0, 0);
                                Tester(array);
                                TransferToFile(array);
                                Console.ReadLine();
                                Console.Clear();
                                break;
                            case "3":
                                TestingBubbleSort(array, 0, 0);
                                Tester(array);
                                TransferToFile(array);
                                Console.ReadLine();
                                Console.Clear();
                                break;
                            case "4":
                                TestingShakerSort(array, 0, 0);
                                Tester(array);
                                TransferToFile(array);
                                Console.ReadLine();
                                Console.Clear();
                                break;
                            case "5":
                                TestingShellSort(array);
                                Tester(array);
                                TransferToFile(array);
                                Console.ReadLine();
                                Console.Clear();
                                Console.WriteLine();
                                break;
                            case "6":
                                mark = false;
                                break;
                        }
                        break;
                    case "2":
                        int[] mas = UpperSortedArray();
                        Console.WriteLine("Выберите алгоритм сортировки:\n1)Сортировка выбором\n2)Сортировка вставками\n3)Сортировка пузырьком\n4)Сортировка шейкером\n5)Сортировка Шелла\n6)Выход");
                        string algoritmSec = Console.ReadLine();
                        Console.Clear();
                        switch (algoritmSec)
                        {
                            case "1":
                                TestingSelectionSort(mas, 0, 0);
                                Tester(mas);
                                TransferToFile(mas);
                                Console.ReadLine();
                                Console.Clear();
                                break;
                            case "2":
                                TestingInsertionSort(mas, 0, 0);
                                Tester(mas);
                                TransferToFile(mas);
                                Console.ReadLine();
                                Console.Clear();
                                break;
                            case "3":
                                TestingBubbleSort(mas, 0, 0);
                                Tester(mas);
                                TransferToFile(mas);
                                Console.ReadLine();
                                Console.Clear();
                                break;
                            case "4":
                                TestingShakerSort(mas, 0, 0);
                                Tester(mas);
                                TransferToFile(mas);
                                Console.ReadLine();
                                Console.Clear();
                                break;
                            case "5":
                                TestingShellSort(mas);
                                Tester(mas);
                                TransferToFile(mas);
                                Console.ReadLine();
                                Console.Clear();
                                Console.WriteLine();
                                break;
                            case "6":
                                mark = false;
                                break;
                        }
                        break;
                    case "3":
                        int[] massive = LowerSortedArray();
                        Console.WriteLine("Выберите алгоритм сортировки:\n1)Сортировка выбором\n2)Сортировка вставками\n3)Сортировка пузырьком\n4)Сортировка шейкером\n5)Сортировка Шелла\n6)Выход");
                        string algoritmThird = Console.ReadLine();
                        Console.Clear();
                        switch (algoritmThird)
                        {
                            case "1":
                                TestingSelectionSort(massive, 0, 0);
                                Tester(massive);
                                TransferToFile(massive);
                                Console.ReadLine();
                                Console.Clear();
                                break;
                            case "2":
                                TestingInsertionSort(massive, 0, 0);
                                Tester(massive);
                                TransferToFile(massive);
                                Console.ReadLine();
                                Console.Clear();
                                break;
                            case "3":
                                TestingBubbleSort(massive, 0, 0);
                                Tester(massive);
                                TransferToFile(massive);
                                Console.ReadLine();
                                Console.Clear();
                                break;
                            case "4":
                                TestingShakerSort(massive, 0, 0);
                                Tester(massive);
                                TransferToFile(massive);
                                Console.ReadLine();
                                Console.Clear();
                                break;
                            case "5":
                                TestingShellSort(massive);
                                Tester(massive);
                                TransferToFile(massive);
                                Console.ReadLine();
                                Console.Clear();
                                Console.WriteLine();
                                break;
                            case "6":
                                mark = false;
                                break;
                        }
                        break;
                    case "4":
                        mark = false;
                        break;
                }
            }
        }
        static void Swap(ref int a, ref int b)
        {
            int tmp = a;
            a = b;
            b = tmp;
        }
        static int[] SelectionSort(int[] array, out int t,out int c)
        {
             int tranpos = 0;
             int counter = 0;
            for(int i = 0; i < array.Length - 1; i++)
            {
                int min = i;
                for(int j = i + 1; j < array.Length; j++)
                {
                    counter++;
                    if (array[j] < array[min])
                    {
                        min = j;
                    }
                }
                Swap(ref array[min], ref array[i]);
                tranpos++;
            }
            t = tranpos;
            c = counter;
            return array;

        }
        static int[] GivenArray()
        {
            Random random = new Random();
            int[] array = new int[100000];
            for(int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(1, 100);
            }
            return array;
        }
       
         static int[] UpperSortedArray()
        {
            Random random = new Random();
            int[] array = new int[100000];
            for(int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(1, 100);
            }
            for(int i = 0; i < array.Length - 1; i++)
            {
                int min = i;
                for(int j = i + 1; j < array.Length; j++)
                {
                    if (array[j] < array[min])
                    {
                        min = j;
                    }
                }
                Swap(ref array[min], ref array[i]);
            }
            return array;
        }
        static int[] LowerSortedArray()
        {
            Random random = new Random();
            int[] array = new int[100000];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(1, 100);
            }
            for (int i = 0; i < array.Length - 1; i++)
            {
                int min = i;
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[j] > array[min])
                    {
                        min = j;
                    }
                }
                Swap(ref array[min], ref array[i]);
            }
            return array;
        }
        static int[]InsertionSort(int[]array,out int t,out int c)
        {
            int tranpos = 0;
            int counter = 0;
            for(int i = 1;i< array.Length; i++)
            {
                for (int j = i; j > 0; j--)
                {
                    counter++;
                    if (array[j - 1] > array[j])
                    {
                        Swap(ref array[j - 1], ref array[j]);
                        tranpos++;
                    }
                }
            }
            t = tranpos;
            c = counter;
            return array;
        }
        static int[] BubbleSort(int[]array,out int t,out int c)
        {
            int tranpos = 0;
            int counter = 0;
            for(int i = 0; i < array.Length; i++)
            {
                for(int j = array.Length-1; j > 0; j--)
                {
                    counter++;
                    if (array[j - 1] > array[j])
                    {
                        Swap(ref array[j - 1], ref array[j]);
                        tranpos++;

                    }
                }
            }
            t = tranpos;
            c = counter;
            return array;
        }
        static int[] ShakerSort(int[] array, out int t ,out int c)
        {
            int tranpos = 0;
            int counter = 0;
            int leftborder = 0;
            int rightborder = array.Length-1;
            do
            {
                for (int i = leftborder; i < rightborder; i++)
                {
                    counter++;
                    if (array[i] > array[i + 1])
                    {
                        Swap(ref array[i], ref array[i + 1]);
                        tranpos++;
                    }
                }
                rightborder--;
                for (int i = rightborder; i > leftborder; i--)
                {
                    counter++;
                    if (array[i] < array[i - 1])
                    {
                        Swap(ref array[i], ref array[i - 1]);
                        tranpos++;
                    }
                }
                leftborder++;
            }
            while (leftborder <= rightborder);
            t = tranpos;
            c = counter;
            return array;
        }
        static int [] ShellSort (int[] array)
        {
            foreach(int step in array)
            {
                for(int i = step; i <= array.Length - 1; i++)
                {
                    int j = i;
                    int tmp = array[i];
                    while (j >= step && tmp < array[j - step])
                    {
                        array[j] = array[j - step];
                        j -= step;
                    }
                    array[j] = tmp;
                }
            }
            return array;
        }
        static void TestingSelectionSort(int []array,int counter,int tranpos)
        {
            DateTime begin = DateTime.Now;
            SelectionSort(array, out counter, out tranpos);
            DateTime stop = DateTime.Now;
            TimeSpan result = stop.Subtract(begin);
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i]+ " ");
            }
            Console.WriteLine();
            Console.WriteLine($"Продолжительность работы: {result.Minutes}:{result.Seconds}:{result.Milliseconds}");
            Console.WriteLine("Количество сравнений: "+ counter);
            Console.WriteLine("Количество перестановок: "+tranpos);

        }
        static void TestingInsertionSort(int[] array, int counter, int tranpos)
        {
            DateTime begin = DateTime.Now;
            InsertionSort(array, out counter, out tranpos);
            DateTime stop = DateTime.Now;
            TimeSpan result = stop.Subtract(begin);
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();
            Console.WriteLine($"Продолжительность работы: {result.Minutes}:{result.Seconds}:{result.Milliseconds}");
            Console.WriteLine("Количество сравнений: " + counter);
            Console.WriteLine("Количество перестановок: " + tranpos);

        }
        static void TestingBubbleSort(int[] array, int counter, int tranpos)
        {
            DateTime begin = DateTime.Now;
            BubbleSort(array, out counter, out tranpos);
            DateTime stop = DateTime.Now;
            TimeSpan result = stop.Subtract(begin);
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();
            Console.WriteLine($"Продолжительность работы: {result.Minutes}:{result.Seconds}:{result.Milliseconds}");
            Console.WriteLine("Количество сравнений: " + counter);
            Console.WriteLine("Количество перестановок: " + tranpos);

        }
        static void TestingShakerSort(int[] array, int counter, int tranpos)
        {
            DateTime begin = DateTime.Now;
            ShakerSort(array, out counter, out tranpos);
            DateTime stop = DateTime.Now;
            TimeSpan result = stop.Subtract(begin);
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();
            Console.WriteLine($"Продолжительность работы: {result.Minutes}:{result.Seconds}:{result.Milliseconds}");
            Console.WriteLine("Количество сравнений: " + counter);
            Console.WriteLine("Количество перестановок: " + tranpos);

        }
        static void TestingShellSort(int[] array)
        {
            DateTime begin = DateTime.Now;
            ShellSort(array);
            DateTime stop = DateTime.Now;
            TimeSpan result = stop.Subtract(begin);
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();
            Console.WriteLine($"Продолжительность работы: {result.Minutes}:{result.Seconds}:{result.Milliseconds}");
            Console.WriteLine("Количество сравнений: " + "0");
            Console.WriteLine("Количество перестановок: " + "0");

        }
        static void Tester(int[] array)
        {
            bool mark = true;
            for (int i = 0; i < array.Length - 1; i++)
            {
                if (array[i] > array[i + 1])
                {
                    mark = false;
                    break;
                }
            }
            if (mark)
            {
                Console.WriteLine("Данный массив отсортирован верно!");
            }
            else
            {
                Console.WriteLine("Данный массив отсортирован неверно!");
            }
        }
        static void TransferToFile(int[] array)
        {
            FileStream file = new FileStream(@"C:\Users\USER\Desktop\Lab7\Number2(7)\sorted.dat", FileMode.OpenOrCreate);
            BinaryWriter write = new BinaryWriter(file);
            for(int i = 0; i < array.Length; i++)
            {
                write.Write(array[i]);
            }
            write.Close();
        }
    }
}
