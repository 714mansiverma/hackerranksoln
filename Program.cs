using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;


namespace HackerRank1
{
    class Program
    {
       
        static void Main(string[] args)
        {
            Console.WriteLine("Enter with question you want to run out of 15 questions");
            string choice = Console.ReadLine();
            switch(choice)
            {
                case "1":
                    //this uses database
                    HackerRank1 h1 = new HackerRank1();
                    h1.H1();
                    break;
                case "2":
                    HackerRank2 h2 = new HackerRank2();
                    h2.h2();
                    break;
                case "4":
                        hackerrank4 h4 = new hackerrank4();
                    Console.WriteLine("number of queries ");
                    int q = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter nodes and edges number");
                        for (int qItr = 0; qItr < q; qItr++)
                        {
                            string[] nm = Console.ReadLine().Split(' ');

                            int n2 = Convert.ToInt32(nm[0]);

                            int m = Convert.ToInt32(nm[1]);

                            int[][] edges = new int[m][];
                        Console.WriteLine("enter the links of nodes ");
                            for (int i = 0; i < m; i++)
                            {
                                edges[i] = Array.ConvertAll(Console.ReadLine().Split(' '), edgesTemp => Convert.ToInt32(edgesTemp));
                            }
                        Console.WriteLine("enter the start point");
                            int s2 = Convert.ToInt32(Console.ReadLine());
                            h4.bfs(n2, m, edges, s2);
                         }
                        break;
                case "12":
                    hackerrank12 h12 = new hackerrank12();
                    Console.WriteLine("enter the value of n amd k");
                    string[] nk = Console.ReadLine().Split(' ');

                    int n = Convert.ToInt32(nk[0]);

                    int k = Convert.ToInt32(nk[1]);
                    Console.WriteLine("Enter the numbers");

                    int[] ar = Array.ConvertAll(Console.ReadLine().Split(' '), arTemp => Convert.ToInt32(arTemp));
                   
                   h12.divisibleSumPairs(n, k, ar);
                    break;
                case "13":
                    hackerrank13 h13 = new hackerrank13();
                    Console.WriteLine("enter  n and k");
                    string[] pk = Console.ReadLine().Split(' ');

                    string n1 = pk[0];

                    int a = Convert.ToInt32(pk[1]);
                    h13.superDigit(n1, a);
                    break;
                case "5":
                    List<int> a1 = new List<int>() { 2, 3, 4, 5, 6, 7, 8, 9, 10 };
                    List<int> b = new List<int>() { 1, 1, 3, 2, 1, 2, 6, 8, 8 };
                    hackerrank5 h5 = new hackerrank5();
                     h5.evenForest(10, 9, a1, b);

                    Console.WriteLine("Max no. of edge removal is " + h5.count + " edges");
                    Console.ReadKey();
                    break;
                case "6":
                    Console.WriteLine("Enter the string");
                    string s = Console.ReadLine();
                    hackerrank6 h6 = new hackerrank6();
                    int result = h6.shortPalindrome(s);
                    Console.WriteLine("number of pairs of string following pattern" + result);
                    Console.ReadKey();
                    break;
                case "7":

                    break;

            }

        }
    }
}
