using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new Model1())
            {
                // Table 1 
                Console.WriteLine("Table 1: ");
                var query = from b in db.Table_1
                            orderby b.Id
                            select new { b.Id, b.Code };
                foreach (var item in query)
                {
                    Console.WriteLine(item);
                }
                // Table 2 
                Console.WriteLine("Table 2: ");
                var query2 = from b in db.Table_2
                            orderby b.Id
                            select new { b.Id, b.Name };
                foreach (var item in query2)
                {
                    Console.WriteLine(item);
                }

                // Inner Join
                Console.WriteLine("Inner Join: ");
                var query_inner = from a in db.Table_1
                                  join b in db.Table_2
                                  on a.Id equals b.Id
                                  select new { a.Id, a.Code, b.Name };
                foreach (var item in query_inner)
                {
                    Console.WriteLine(item);
                }

                // Left Join
                Console.WriteLine("Left Join: ");
                var query_left = from a in db.Table_1
                                 join b in db.Table_2
                                 on a.Id equals b.Id
                                 into temp
                                 from b in temp.DefaultIfEmpty()
                                 select new {a.Id, a.Code, Name = (b.Name == null ? "N/A":b.Name)};
                foreach (var item in query_left)
                {
                    Console.WriteLine(item);
                }

                // Right Join
                Console.WriteLine("Right Join: ");
                var query_right = from b in db.Table_2
                                  join a in db.Table_1
                                  on b.Id equals a.Id
                                  into temp
                                  from a in temp.DefaultIfEmpty()
                                  select new {b.Id, Code = (a.Code == null ? "N/A" : a.Code), b.Name  };
                foreach (var item in query_right)
                {
                    Console.WriteLine(item);
                }


                // Outer Join
                Console.WriteLine("Outer Join: ");
                var query_outer = query_left.Union(query_right);
                foreach (var item in query_outer)
                {
                    Console.WriteLine(item);
                }
                
                Console.WriteLine("Press any key to exit...");
                Console.ReadKey();
            }
        }
    }
}
