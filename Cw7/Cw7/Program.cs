using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cw7
{
    class Program
    {
        static void Main(string[] args)
        {
            int liczba1 = 8, liczba2 = 0, liczba3;
            try
            {
                liczba3 = liczba1 / liczba2;  
                metoda23();
            }
            catch
            {
                Console.WriteLine("Nie można dzielić przez 0.");  
            }
            finally
            {
                Console.WriteLine("Koniec");                
            }

            Console.ReadKey();
        }

        static void metoda23()
        {
            throw new NotImplementedException();
        }
    }
}
