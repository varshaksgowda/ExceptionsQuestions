using System;
using System.Reflection.Metadata.Ecma335;
namespace FormateException
{
    public class Program
    {
        
        public static void Main(string[] args)
        {
            try
            {
                string s=Console.ReadLine();
                int a=int.Parse(s);
                 
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("code executed");
            }
        }
    }
}
