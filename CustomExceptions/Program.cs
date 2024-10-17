using System;
namespace CustomException
{
    public class AgeOutOfRange : Exception
    {
        public AgeOutOfRange(string Message) : base(Message) { }
        public class Program
        {
            public static void Main(string[] args)
            {
                while (true)
                {
                    try
                    {
                        int Age = int.Parse(Console.ReadLine());
                        if (Age < 18)
                        {
                            throw new AgeOutOfRange("age is below 18 for voting system");
                        }
                        Console.WriteLine(Age + " is right to vote");
                    }
                    catch (AgeOutOfRange ex)
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
    }
}