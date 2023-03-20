using System;
using System.Collections.Generic;

namespace list
{

    class listcode
    {

        static void Main(string[] args)
        {
            // List with default capacity
            List<Int16> list = new List<Int16>();
            // List with capacity = 5
            List<string> authors = new List<string>(5);
            //insertion in list
            List<int> numberList = new List<int>();
            numberList.Add(32);
            numberList.Add(21);
            numberList.Add(45);

            //access
            foreach (int a in numberList)
                Console.WriteLine(a);

            List<string> poets = new List<string>(5);
            poets.Add("Mahesh Chand");
            poets.Add("Chris Love");
            poets.Add("Allen O'neill");
            poets.Add("Naveen Sharma");
            poets.Add("Mahesh Chand");
            poets.Add("Monica Rathbun");
            poets.Add("David McCarter");
            int idx = poets.IndexOf("Naveen Sharma");
            if (idx > 0)
                Console.WriteLine($"Item index in List is: {idx}");
            else
                Console.WriteLine("Item not found");
            Console.WriteLine(poets.IndexOf("Naveen Sharma", 2));
            Console.WriteLine(poets.LastIndexOf("Mahesh Chand"));

            // Print original order
            foreach (string a in poets)
                Console.WriteLine(a);
            // Sort list items
            poets.Sort();

        }
    }
}