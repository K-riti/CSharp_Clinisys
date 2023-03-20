//using System;

namespace eventexpection
{

    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                System.Console.WriteLine("Enter 1st value");
                int x = Convert.ToInt32(Console.ReadLine());
                System.Console.WriteLine("Enter 2nd Value");
                int y = Convert.ToInt32(Console.ReadLine());
                var z = x / y;
                if ((z == 0))
                {
                    throw new ApplicationException("There is exception in the code by the input you provided.");
                }
                System.Console.WriteLine("Result of division :" + z);


            }
            catch(System.DivideByZeroException ex1)
            {
                //System.Console.WriteLine("Trying to divide by Zero ");
                System.Console.WriteLine(ex1.Message);
            }
            catch(System.FormatException ex2)
            {
                //System.Console.WriteLine("Incorrect Format of Input");
                System.Console.WriteLine(ex2.Message);
            }
            catch (System.Exception ex)
            {
                System.Console.WriteLine(ex.Message);

            }
            
            
            finally
            {
                System.Console.WriteLine("  ******* Finally your Task is completed ***********");
            }

            
        }

    }
}
