using System;
namespace OverFlowException
{
    public class Program
    {
        public static void Main(string[] args)
        {
            try
            {
                int n = int.Parse(Console.ReadLine());

            }
            catch (OverflowException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Code excecuted");
            }
        }
    }
}