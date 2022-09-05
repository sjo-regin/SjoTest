using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCodeScan
{
    class Class1
    {

        int[] intArray = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        int[] intArray2;
        public void Test1()
        {

            int nr = 10;
            for (int i = 0; i < nr; i++)
            {

                Trace.WriteLine($"Test1() intArray[{i}] = {intArray[i]}");

            }
        }

        public void Test2()
        {

            int nr = 15;
            for (int i = 0; i < nr; i++)
            {

                Trace.WriteLine($"Test2() intArray[{i}] = {intArray[i]}");

            }
        }

        public void Test3()
        {

            int nr = 15;
            for (int i = 0; i < nr; i++)
            {

                Trace.WriteLine($"Test3() intArray2[{i}] = {intArray2[i]}");

            }
        }
        public void Test4(string input)
        {
            string kalle;
            int olle;

            string kalle2 = input.ToLower();

           
        }
    }
}
