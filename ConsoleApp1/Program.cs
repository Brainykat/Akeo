using System;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        #region 52
        static void Main(string[] args)
        {
            Node right = new Node
            {
                Right = new Node(),
                Left = new Node(),
                Value = 4
            };

            int value = 4;
            Node tree = new Node
            {
                Right = right,
                Left = new Node(),
                Value = 3
            };
            Node searchedNode = Find( value, tree);
            if(searchedNode != null)
            {
                Console.WriteLine($"{value} found in tree");
            }
            else
            {
                Console.WriteLine($"{value} NOT found in node tree");
            }

        }
        public static Node Find(int valueToBeSearched, Node node)
        {
            if (node == null) 
                return null;
            if (valueToBeSearched == node.Value) 
                return node;
            if (valueToBeSearched < node.Value)
                return Find(valueToBeSearched, node.Left);
            else 
                return Find(valueToBeSearched, node.Right);
        }
        public class Node
        {
            public Node Left { get; set; }
            public Node Right { get; set; }
            public int Value { get; set; }
        }
        #endregion
        #region 51
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int[] a = { 4, 7, 14, 28, 50 };
            Console.WriteLine($"a = [{String.Join(",", a)}]");
            int[] b = { 1, 15, 21, 99 };
            Console.WriteLine($"b = [{String.Join(", ", b)}]");
            var res = CombineAndSort(a, b);
            if(res == null) Console.WriteLine("Null Arrays");
            Console.WriteLine($"Result = [{String.Join(",", res)}]");
            Console.ReadLine();
        }
        public static int[] CombineAndSort(int[] a, int[] b)
        {
            if ((a == null && b == null) || (a.Length == 0 && b.Length == 0) ) return null;
            if (a == null || a.Length == 0) return b.OrderBy(x => x).ToArray();
            if (b == null || b.Length == 0) return a.OrderBy(x => x).ToArray();
            
            return a
            .Concat(b)
            .OrderBy(x => x)
            .ToArray();
        }
        #endregion
        #region 53
        /*
         * --Create table employee(
                --[EmployeeId] int Primary key,
                --[Name] Nvarchar(50),
                --[ManagerId] int
                --)

                --insert into employee([EmployeeId],[Name],[ManagerId])
                --values (1,'Chris',0);
                --insert into employee([EmployeeId],[Name],[ManagerId])
                --values (2,'Peter',1);
                --insert into employee([EmployeeId],[Name],[ManagerId])
                --values (3,'Uhuru',1);
                --insert into employee([EmployeeId],[Name],[ManagerId])
                --values (4,'Ruto',3);

                select * from employee;

                WITH cte AS (
                    SELECT       
                        [EmployeeId], 
                        [Name] as [Employee Name],
                        [ManagerId]
        
                    FROM       
                        [employee]
                    WHERE [ManagerId] = 0
                    UNION ALL
                    SELECT 
                        e.[EmployeeId], 
                        e.[Name]  as [Employee Name],
                        e.[ManagerId]
                    FROM 
                        [employee] e
                    INNER JOIN cte o 
                          ON o.[EmployeeId] = e.[ManagerId]
                )
                SELECT * FROM cte;
         * */
        #endregion
    }
}
