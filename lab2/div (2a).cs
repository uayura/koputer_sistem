using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace div_2a
{
    class Program
    {
        static void Main(string[] args)
        {
            DivMod(0b11110101, 0b11);

            Console.ReadKey();
        }

        public static void DivMod(Int32 dividend, Int32 divisor)
        {
            int d = dividend;
            int r = divisor;

            while (r < dividend)
            {
                r <<= 1;
            }
            Console.WriteLine(dividend + " : " + divisor);
            Console.WriteLine(Convert.ToString(Convert.ToInt32(dividend), 2) + " : " + Convert.ToString(Convert.ToInt32(divisor), 2) + "\n");
            Console.WriteLine("dividend  " + Convert.ToString(Convert.ToInt32(d), 2));
            Console.WriteLine("divisor   " + Convert.ToString(Convert.ToInt32(r), 2)+"\n");
            string result = string.Empty;
            for (int i = 0; i < 128; i++)
            {
                if (d< divisor && r<divisor)
                {
                    //result += "0";
                    break;
                }
                if (r > d)
                {
                    r >>= 1;
                    Console.WriteLine(" --comand: shit                            output:");
                    result += "0";
                }
                else
                {
                    d -= r;
                    Console.WriteLine(" -- comand: dividend - divisor (+sift)     output:");
                    result += "1";
                    r >>= 1;
                }
                Console.WriteLine("dividend  "+Convert.ToString(Convert.ToInt32(d), 2));
                Console.WriteLine("divisor   " + Convert.ToString(Convert.ToInt32(r), 2));
                Console.WriteLine("result now is = " + result+"\n");
                
            }
            Console.WriteLine("Result : " + Convert.ToInt32(result, 2)+ " ( "+result+" ) " +"   rest : " + d+ " ( " + Convert.ToString(Convert.ToInt32(d), 2) + " ) ");
        }
    }


}
