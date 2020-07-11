using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank1
{
    public class hackerrank5
    {
        public int count = 0;

        private static Dictionary<int, List<int>> tree = new Dictionary<int, List<int>>();

        public  int find(int k)
        {
            int s = 0;
            if (tree[k].Count > 0)
            {
                for (int i = 0; i < tree[k].Count; i++)
                {
                    int g = find(tree[k][i]);
                    if (g % 2 == 0)
                        count++;
                    s += g;
                }
                s += 1;
            }
            else
                return 1;

            return s;
        }


        public void evenForest(int t_nodes, int t_edges, List<int> t_from, List<int> t_to)
        {

            for (int i = 1; i <= t_nodes; i++)
            {
                tree.Add(i, new List<int>());
                for (int j = 0; j < t_edges; j++)
                {
                    if (t_to[j] == i)
                        tree[i].Add(t_from[j]);
                }
            }

            int d = find(1);
        }
    }
}

              