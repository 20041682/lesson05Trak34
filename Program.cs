// Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.


   int[] arr = new int[10];
            int k = 0;
            Random rnd = new Random();
 
            Console.WriteLine("Исходный массив");
            for (int i = 0; i < 10; i++)
            {
                arr[i] = rnd.Next(100, 999);
                Console.Write("{0} ", arr[i]);
            }
            Console.WriteLine();
 
            foreach(int element in arr)
            {
                Console.Write("{0} ", element);
                if (element % 2 == 0)
                {
                    k++;
                }
            }
            Console.WriteLine();
            Console.WriteLine("Количество четных элементов {0}", k);
