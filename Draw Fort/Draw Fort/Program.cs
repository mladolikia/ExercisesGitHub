using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Draw_Fort
{
    class Program
    {
        static void Main(string[] args)
        {


            //int n = int.Parse(Console.ReadLine());
            
            string a = new string('/', 1);
            string b = new string('^', n/2);
            string d = new string('_', (n-2-n/2)*2);
            string d1 = new string('_', n / 2);
            
            string c = new string ( '\\', 1);
            string E = new string(' ', n*2-2);
            string E1 = new string(' ', (n - 2 - n / 2) * 2);
            string S = new string(' ', n/2+1);

            Console.WriteLine(a+b+c+d+a+b+c);
           
            for (int i = 1; i < n-2; i++)
            {
                Console.WriteLine("|"+E+"|" );
                
            }

            Console.WriteLine("|"+ S + d + S +"|");


            Console.WriteLine(c + d1 + a + E1+ c + d1 + a);








        }
    }
}
