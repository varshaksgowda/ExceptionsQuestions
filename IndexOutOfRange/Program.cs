using System;
namespace IndexOutOfRange
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //int n = int.Parse(Console.ReadLine());
            int[] arr = new int[5] { 1,3,4,5,6};
            try
            {
                int index= int.Parse(Console.ReadLine());
                Console.WriteLine(arr[index]);   
                //if (5 > arr.Length)
                //{
                //    throw new IndexOutOfRangeException();
                //}
                //for (int i = 0; i < 5; i++)
                //{
                //    arr[i] = int.Parse(Console.ReadLine());
                //}
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Code Excecuted");
            }

        }
    }
}