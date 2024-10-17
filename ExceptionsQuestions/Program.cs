using System;
namespace DivideExceptions
{
    public class Program
    {
        public static void Main(string[] args)
        {
            try
            {
                int a = int.Parse(Console.ReadLine());
                int b = int.Parse(Console.ReadLine());
                int c = a / b;
                //if (b == 0)
                //{
                //    throw new DivideByZeroException("it can't be divided by zero");
                //}
                //else
                //{
                //    Console.WriteLine(c);
                //}
            }

            catch(DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("program is executed");
            }
        }
    }
}