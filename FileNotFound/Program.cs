using System;
namespace FileNotFound
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string s = Console.ReadLine();  
            try
            {
                var file = File.ReadAllText(s);
                Console.WriteLine(file);
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("code Execcuted");
            }
        }
    }
}