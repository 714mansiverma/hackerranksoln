using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

namespace HackerRank1
{
   public class hackerrank6
    {

        public int shortPalindrome(string s)
        {
            char[] s1 = s.ToCharArray();
            int count = 0;
            for (int i = 0; i < s1.Length - 1; i++)
            {

                for (int j = i + 1; j < s1.Length - 1; j++)
                {
                    int k = j + 1;
                    while (k < s1.Length - 1)
                    {
                        if (s[j].Equals(s[k]))
                        {
                            int g = k + 1;
                            while (s[i].Equals(s[g]) && g < s1.Length)
                            {
                                count++;

                                g++;
                                if (g >= s1.Length)
                                {
                                    break;
                                }
                            }
                            k++;
                        }
                        else
                        {
                            k++;
                        }
                    }

                }
            }

            return count;

        }
    }
}

