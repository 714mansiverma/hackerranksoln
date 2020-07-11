using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank1
{
    class HackerRank2
    {
        public int CustomerId { get; set; }
        public string CustomerName { get; set; }
        public HackerRank2 NextNode { get; set; }
        public HackerRank2 s1 = null;
        public void h2()
        {

            
                Console.WriteLine("Enter 1 if insert 2 if display");
                string c = Console.ReadLine();
            switch (c)
            {
                case "1":
                    HackerRank2 hacker = new HackerRank2();
                    Console.WriteLine("Enter the customer id");
                    hacker.CustomerId = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter the customer name");
                    hacker.CustomerName = Console.ReadLine();
                    hacker.NextNode = null;

                    if (s1 == null)
                    {
                        s1 = hacker;
                    }
                    else
                    {
                        HackerRank2 temp1 = s1;
                        while (temp1.NextNode != null)
                        {
                            temp1 = temp1.NextNode;

                        }
                        temp1.NextNode = hacker;
                    }
                    Console.WriteLine("you want to do more operation yes or no");
                    if (Console.ReadLine().Equals("yes"))
                    {
                        h2();
                    }
                    else
                    {
                        return;
                    }

                    break;
                case "2":
                    HackerRank2 temp = s1;
                    while (temp != null)
                    {
                        Console.Write("id-{0}    name-{1} -> ", temp.CustomerId, temp.CustomerName);
                        temp = temp.NextNode;
                    }

                    Console.WriteLine("\nyou want to do more operation yes or no");
                    if (Console.ReadLine().Equals("yes"))
                    {
                        h2();
                    }
                    else
                    {
                        return;
                    }
                    break;




            }
       
        }
    }
}
