using System;
namespace Async
{
    public class Async
    {
        public static async void Method1(){
            for(int i=0;i<9;i++)
            {
                System.Console.WriteLine("This is Method 1");
                await Task.Delay(3000);
                //await Task.Yield();
            }
        }

        public static void Method3(){
            for(int i=0;i<7;i++)
            {
                System.Console.WriteLine("This is Method 3");

            }
        }
        public static async void Method2(){
            for(int i=0;i<4;i++)
            {
                System.Console.WriteLine("This is Method 2");
                await Task.Delay(3000);
            }
        }
        static void Main(string[] args)
        {
            Method1();
            Method2();
            Method3();
            System.Console.ReadKey();
        }

    }
}

