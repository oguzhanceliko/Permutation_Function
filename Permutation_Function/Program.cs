using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Permutation_Function
{
    class Program
    {
        static void Main(string[] args)
        {
            Function("loodos", "lds");
            Console.ReadKey();
        }

        public static void Function(string Value1, string Value2)
        {
            char[] Chars1 = Value1.ToCharArray();
            char[] Chars2 = Value2.ToCharArray();


            string Result = "";

            if (Value1.Length > Value2.Length)
            {
                for (int i = 0; i < Value2.Length; i++)
                {
                    if (Value1.IndexOf(Chars2[i].ToString()) == -1)
                    {
                        Result = "false";
                        break;
                    }
                    else
                    {
                        Result = "true";
                    }
                }
            }
            else
            {
                for (int i = 0; i < Value1.Length; i++)
                {
                    if (Value2.IndexOf(Chars1[i].ToString()) == -1)
                    {
                        Result = "false";
                        break;
                    }
                    else
                    {
                        Result = "true";
                    }
                }
            }

            Console.Write(Result);

        }
    }
}
