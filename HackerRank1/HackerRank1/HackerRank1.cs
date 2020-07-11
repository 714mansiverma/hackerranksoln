using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using HackerRank1;

namespace HackerRank1
{
    class HackerRank1
    {
        public void H1()
        {
            using(var context= new newmansiEntities())
            {
                Console.WriteLine("displaying the details");
                var repo = from r in context.Repositories join p in context.Projects on r.ProjectId equals p.Id where (p.ProjectName == "shell") select r;
    Console.WriteLine("Id"+"    "+"ProjectId"+ "       "+"RepositoryName" + "       " + "ModuleName"+"        "+"CreatedOn" + "        " + "LastUpdatedOn"+"        "+" ProjectTitle");
                foreach(var a in repo)
                {
                    Console.WriteLine("{0}      {1}      {2}      {3}      {4}      {5}      {6}", a.Id, a.ProjectId, a.RepositoryName, a.ModuleName, a.CreatedOn, a.LastUpdatedOn,a.Project.ProjectName);
                }
            }
            Console.ReadKey();
        }
    }
}
