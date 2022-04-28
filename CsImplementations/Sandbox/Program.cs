using System;
using System.Collections;
using System.Collections.Generic;
using DataStructures;
using DataStructures.LinkedLists;
using DataStructures.Stacks;
using DataStructures.Trees;
using DataStructures.Graphs;
using DataStructures.Graphs.Algorithms;

namespace Sandbox
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            BinarySearchTree<int> bst = new BinarySearchTree<int>();
            bst.Insert(1);
            bst.Insert(6);
            bst.Insert(4);
            bst.Insert(5);
            bst.Delete(4);
            bst.Delete(3);

            Console.WriteLine("Contains 1: " + bst.Contains(1));
            Console.WriteLine("Contains 4: " + bst.Contains(4));
            Console.WriteLine("Contains 5: " + bst.Contains(5));
            Console.WriteLine("Contains 6: " + bst.Contains(6));
            Console.WriteLine("Contains 7: " + bst.Contains(7));
            */
            Graph graph = new Graph(7);
            graph.AddEdge(0, 1);
            graph.AddEdge(0, 2);
            graph.AddEdge(0, 6);
            graph.AddEdge(6, 4);
            graph.AddEdge(4, 3);
            graph.AddEdge(4, 5);
            graph.AddEdge(3, 5);
            graph.AddEdge(0, 5);
            Console.Write(graph.ToString());

            Graph graph2 = new Graph(graph);

            Console.WriteLine("");
            Console.Write(graph2.ToString());

            //BreadthFirstPaths bfp = new BreadthFirstPaths(graph, 0);
            /*
            foreach (var i in bfp.PathTo(4))
            {
                Console.WriteLine(i);
            }
            */
            /*
            Console.WriteLine(bfp.DistanceTo(4));
            Console.WriteLine(bfp.DistanceTo(5));
            Console.WriteLine(bfp.DistanceTo(3));
            */

            Console.ReadKey();
        }
    }
}
