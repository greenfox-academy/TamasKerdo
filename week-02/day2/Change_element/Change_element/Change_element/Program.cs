﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Change_element
{
    class Program
    {
        static void Main(string[] args)
        {

            // - Create an array variable named `s`
            //   with the following content: `[1, 2, 3, 8, 5, 6]`
            // - Change the 8 to 4
            // - Print the fourth element



            int[] s = new int[] { 1, 2, 3, 8, 5, 6 };
            s[3] = 4;
            Console.Write(s[3]);
            Console.ReadLine();

        }
    }
}
