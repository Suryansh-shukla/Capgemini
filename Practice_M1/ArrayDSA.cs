using System;



public class Program

{

    public static void MoveZerosToEnd(int[] arr)

    {

        if (arr == null || arr.Length == 0)

            return;



        int idx = 0;



        for (int i = 0; i < arr.Length; i++)

        {

            if (arr[i] != 0)

            {

                arr[idx] = arr[i];

                idx++;

            }

        }



        while (idx< arr.Length)

        {

            arr[idx] = 0;

            idx++;

        }

    }

    public static void Main(string[] args)

    {

        int n = Convert.ToInt32(Console.ReadLine());



        int[] arr = new int[n];



        for (int i = 0; i < n; i++)

        {

            arr[i] = Convert.ToInt32(Console.ReadLine());

        }

        MoveZerosToEnd(arr);



        for (int i = 0; i < n; i++)

        {

            Console.Write(arr[i]);

            if (i < n - 1)

                Console.Write(" ");

        }

    }

}

