using System;

namespace Wyjatki
{
    class Program
    {
        static void Main(string[] args)
        {
            int liczba1, liczba2 = 30, liczba3 = 0 ;
            int[] table = new int [2];
            try
            {
               // liczba1 = liczba2 / liczba3;
                table[25] = 2;
                throw new IndexOutOfRangeException();
            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine(e.Message);
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            
            finally
            {
                Console.WriteLine("Finally");
            }

            Console.ReadKey();
        }
    }
}
