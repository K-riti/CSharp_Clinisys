// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using System;
//using System.Array;

namespace ArrayPrac
{


    class Program
    {

        //    enum Planets{
        //         Mercury,Venus,Earth,Mars,Jupiter,Saturn,Uranus,Neptune,Pluto
        //         Mars,
        //         Jupiter,
        //         Saturn,
        //         Uranu
        //         Earth,
        //         Mars,
        //         Jupiter,
        //         Saturn,
        //         Uranus,
        //         Neptune,
        //         Pluto
        //}
        static void Main(string[] args)
        {
            //Planets myVar = Planets.Earth;
            // int mplanet = (int) Planets.Venus;
            // Console.WriteLine(mplanet);


            //Array declare
            // int[] arr=new int[3]{1,2,3};
            // foreach(int i in arr){
            //     System.Console.WriteLine(i);
            // }
            // int[][] jaggedArray = //new int [5][]
            //   {
            //   new int[] { 3, 5, 7, },
            //   new int[] { 1, 0, 2, 4, 6 },
            //   new int[] {1, 2, 3, 4, 5, 6, 7, 8},
            //   new int[] {4, 5, 6, 7, 8}
            //   };
            //   for(int i=0;i<5;i++){
            //     for(int j=0;j<jaggedArray[i].Length;j++){
            //         System.Console.Write(jaggedArray[i][j]+" ");

            //     }
            //     System.Console.WriteLine(" ");
            //   }

            //     int[][] randomNumber = new int[3][];
            // randomNumber[0] = new int[4];
            // randomNumber[1] = new int[6];
            // randomNumber[2] = new int[3];
            // //Console.WriteLine(randomNumber.Length);

            // for(int i= 0; i<randomNumber.Length;i++)
            // {
            //     Console.Write("Enter num");
            //     for(int j =0; j<randomNumber[i].Length; j++)
            //     {
            //         randomNumber[i][j] = Convert.ToInt32(Console.ReadLine());
            //     }
            // }

            // for(int i=0; i<randomNumber.Length;i++)
            // {
            //     for(int j = 0; j<randomNumber[i].Length;j++)
            //     {
            //         Console.Write("{0} ",randomNumber[i][j]);
            //     }
            //     Console.WriteLine();
            // }

            //Arrays declaration

            // int[] arr={1,2,3,4};
            // foreach(int i in arr){
            //     Console.WriteLine(i);
            // }
            //Array by user input
            // char[] arr=new char[5];
            // for(int i=0;i<5;i++){
            //     System.Console.WriteLine("Enter your characters");
            //     arr[i] = Convert.ToChar(Console.ReadLine());
            // }
            // System.Console.WriteLine();
            // foreach(char j in arr){
            //     System.Console.Write(j);
            // }
            // int[] myNumbers = {5, 1, 8, 9};
            // Console.WriteLine(myNumbers.Max());  // returns the largest value
            // Console.WriteLine(myNumbers.Min());  // returns the smallest value
            // Console.WriteLine(myNumbers.Sum()); 

            // char[] sam =new char[] {'a','b','f','e','t','g','p'};
            // System.Console.WriteLine(sam.Max());
            // System.Console.WriteLine(sam.Min());

            //Invalid Array

            // int[] evenNums = new int[] { 2, 4 };
            // foreach(int i in evenNums)
            // System.Console.WriteLine(i);

            //int[] evenNums = new int[];

            // var evenNums = {2,6,8};
            //var array=new int[]{2,8,9};

            // int[] nums = new int[] { 10, 15, 16, 8, 6, 45, 67, 89, 34, 65 };

            // Console.WriteLine("Length: " + num.Length);

            //Array.Clear(num,0,2);
            // Array.Resize(ref num,5);
            // foreach(int i in num){
            //      System.Console.WriteLine(i);
            //  }


            // Array.Sort(nums); // sorts array 
            // foreach(int i in nums)
            // System.Console.WriteLine(i);

            //     Array.Reverse(nums); // sorts array in descending order
            //    foreach(int i in nums)
            //     System.Console.WriteLine(i);

            // Array.ForEach(nums, n => Console.WriteLine(n)); // iterates array

            //Console.WriteLine(Array.BinarySearch(nums, 8));
            // binary search 
            // foreach(int i in nums)
            // System.Console.WriteLine(i);

            //Array.(nums,6);
            // Console.WriteLine(Array.FindIndex(nums, item => item == 3));
            //Passing array as argument

            // int[] num = { 1, 2, 3, 4, 5 };

            // UpdateArray(num);

            // foreach (var item in num)
            //     Console.WriteLine(item);
            // static void UpdateArray(int[] arr)
            // {
            //     for (int i = 0; i < arr.Length; i++)
            //         arr[i] = arr[i] + 10;
            // }


            //2d arrays..
            // int[,] arr = new int[3, 4]{
            //      {3,7,8,0},
            //      {8,0,6,4},
            //      {4,2,6,1}

            //  };
            // foreach(int i in arr){
            //     System.Console.Write(i);
            //     System.Console.WriteLine();

            // }
            //2D in Matrix form 

            // for (int i = 0; i <3; i++)
            // {
            //     for (int j = 0; j < 4; j++)
            //     {
            //         System.Console.Write(arr[i,j]+" | ");

            //     }
            //     System.Console.WriteLine();

            //System.Console.WriteLine();
            //System.Console.WriteLine(arr[1,2]);
            //System.Console.WriteLine(arr[1,4]);
            //System.Console.WriteLine(arr[1,2]);
            //System.Console.WriteLine(arr[2,2]);
            //System.Console.WriteLine(arr[3,2]);

            //User Input in 2D array

            // System.Console.WriteLine("How many Rows do you want? ");

            // int r = Convert.ToInt32(Console.ReadLine());

            // System.Console.WriteLine("How many Columns do you want? ");

            // int c = Convert.ToInt32(Console.ReadLine());

            // int[,] arr = new int[r, c];

            // for (int i = 0; i < r; i++)

            // {

            //     System.Console.WriteLine("Enter elements for Row {0}", i);

            //     for (int j = 0; j < c; j++)

            //     {

            //         arr[i, j] = Convert.ToInt32(Console.ReadLine());

            //     }

            // }

            // for (int i = 0; i < r; i++)

            // {
            //     for (int j = 0; j < c; j++)

            //     {
            //         System.Console.Write(arr[i, j] + " | ");

            //     }

            //     System.Console.WriteLine();


                //}
            //}

            //STRING
            //string days = "Monday";
            //length
            //System.Console.WriteLine(days.Length);
            //to upper
            //System.Console.WriteLine(days.ToUpper());
            //to lower
           // System.Console.WriteLine(days.ToLower());
           //concatenation
           //string firstName="Kriti";
           //string LastName=" Bhaskar";
           //string Name= firstName + LastName;
           //String Name=String.Concat(firstName,LastName);
           

           //System.Console.WriteLine(Name);
           string str ="Clinisys";
           string sub=str.Substring(2,4);
           System.Console.WriteLine(sub);
        }
    }
}