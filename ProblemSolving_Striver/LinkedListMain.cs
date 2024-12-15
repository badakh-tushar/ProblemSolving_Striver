using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving_Striver
{
    public class LinkedListMain
    {
        public static void LinkedMain()
       {
            LinkedList<int> list = new LinkedList<int>();
            list.InsertLast(10);
            list.InsertLast(20);
            list.InsertLast(30);
            list.InsertLast(40);
            list.AtIndexInsertNode(2, 35);
            list.AtIndexInsertNode(0, 5);
            list.DeleteNodeBydata(40);
            list.DeleteNodeBydata(5);
            list.Display();
            
        }

    }
}
