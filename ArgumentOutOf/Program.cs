using System;
namespace ArgumentOutOf
{
    public class Program
    {
        public static void Main(string[] args)
        {
            try
            {
                string s = "hi hello how are u";
                s.Substring(1,30);
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("code complected");
            }
        }
    }
}