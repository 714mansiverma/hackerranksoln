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
    class hackerrank4
    {
        public void bfs(int n, int m, int[][] edges, int s)
        {
            int[] distance = new int[n + 1];
            int[] visited = new int[n + 1];
            int[] d = new int[n - 1];
            Queue<int> q = new Queue<int>();
            q.Enqueue(s);
            for (int i = 0; i <= n; i++)
            {
                distance[i] = 0;
                visited[i] = 0;
            }
            while (q.Count() > 0)
            {
                for (int i = 0; i < m; i++)
                {
                    if (visited[edges[i][0]] == 0 || visited[edges[i][1]] == 0)
                    {
                        if (edges[i][0] != q.Peek() && edges[i][1] == q.Peek())
                        {
                            q.Enqueue(edges[i][0]);
                            if (distance[edges[i][0]] == 0)
                            {
                                distance[edges[i][0]] = distance[q.Peek()] + 6;
                            }
                            else
                            {
                                if (distance[edges[i][0]] > distance[q.Peek()] + 6)
                                {
                                    distance[edges[i][0]] = distance[q.Peek()] + 6;
                                }
                            }
                            visited[edges[i][0]] = 1;
                            visited[edges[i][1]] = 1;
                        }
                        else if (edges[i][0] == q.Peek() && edges[i][1] != q.Peek())
                        {
                            q.Enqueue(edges[i][1]);
                            if (distance[edges[i][1]] == 0)
                            {
                                distance[edges[i][1]] = distance[q.Peek()] + 6;
                            }
                            else
                            {
                                if (distance[edges[i][1]] > distance[q.Peek()] + 6)
                                {
                                    distance[edges[i][1]] = distance[q.Peek()] + 6;
                                }
                            }
                            visited[edges[i][0]] = 1;
                            visited[edges[i][1]] = 1;
                        }
                        else
                        {

                        }

                    }
                }
                q.Dequeue();
            }
            int j = 0;
            for (int i = 1; i < s; i++)
            {
                if (distance[i] == 0)
                {
                    d[j] = -1;
                    j++;
                }
                else
                {
                    d[j] = distance[i];
                    j++;
                }
            }
            for (int i = s + 1; i <= n; i++)
            {
                if (distance[i] == 0)
                {
                    d[j] = -1;
                    j++;
                }
                else
                {
                    d[j] = distance[i];
                    j++;
                }
            }

            foreach (var a in d)

            {
                Console.Write(a + " ");
            }
            Console.ReadKey();

        }
        
    }
}


