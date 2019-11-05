using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FCTRL3

{ 

    class Program
    {



        static void Main(string[] args)
        {
            string row = "";
            int n = Convert.ToInt32(Console.ReadLine());
            string[] array = new string[n];

            for (int i = 0; i < n; i++) {

                int m = Convert.ToInt32(Console.ReadLine());
                long result = silnia(m);
          

            var len = result.ToString().Length;

            var silniaString = result.ToString();




            int l = 0;
            l = Convert.ToInt32(len);

            string j, d;

            if (l == 1)
            {
                j = silniaString;
                d = "0";
                  
                }
            else
            {
                j = silniaString[len - 1].ToString();
                d = silniaString[len - 2].ToString();
                    
                }

                row = d + " " + j;
                array[i] = row;
                
            //  Console.WriteLine($" Cyfry : {len} , d ={d} , j ={j}");
            
            }

            for(int i = 0; i < n; i++)
            {
                Console.WriteLine($"{array[i]}");
            }
            Console.ReadKey();
        }

        public static long  silnia(int n)
        {
            if(n <= 1)
            {
                return 1;
            }
            else
            {
                return n * silnia(n - 1);
            }
                
        }

    }
}
