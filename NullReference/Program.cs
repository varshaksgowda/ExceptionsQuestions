using System;
namespace Nullexception
{
    public class Program
    {
        public static void Main(string[] args)
        {
            while (true)
            {
                try
                {
                    Console.WriteLine("Enter a String Value");
                    string? Name = Console.ReadLine();
                    if (string.IsNullOrEmpty(Name))
                    {
                        Name = null;
                        throw new ArgumentNullException();
                    }
                    var result = Handle(Name);
                    Console.WriteLine(result);
                }
                catch (ArgumentNullException ex)
                {
                    Console.WriteLine("Null exception");
                }
                finally
                {
                    Console.WriteLine("code is executed");
                }
            }
        }
        public static int Handle(string Name)
        {
            return Name.Length;
        }

    }
}
