using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.CodeDom.Compiler;

using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;


namespace HackerRank1
{
    class hackerrank13
    {
    
   public  void superDigit(string n, int k)
    {
        char x = '0';
            if (n.Length == 1)
            {
                Console.WriteLine(n);
                Console.ReadKey();
            }

        long result = 0;
        foreach (var s in n)
        {
            result += (long)s - x;

        }
        result *= k;
            superDigit(result.ToString(), 1);
           
        

    }

}
}
