using System;
using System.Collections;
using System.Collections.Generic;
using DataStructures;
using DataStructures.LinkedLists;
using DataStructures.Stacks;
using DataStructures.Trees;
using DataStructures.Graphs;
using DataStructures.Graphs.Algorithms;
using DataStructures.SymbolTables;

namespace Sandbox
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            UnorderedLinkedListSymbolTable<int, string> st = new UnorderedLinkedListSymbolTable<int, string>();
            st.Insert(1, "one");
            st.Insert(2, "two");
            st.Insert(3, "three");
            Console.WriteLine(st[2]);
            */

            //BinarySearchSymbolTable<int, string> st = new BinarySearchSymbolTable<int, string>(3);
            BinarySearchSymbolTable<int, string> st = new BinarySearchSymbolTable<int, string>();
            st.Insert(1, "one");
            st.Insert(2, "two");
            st.Insert(3, "three");
            Console.WriteLine(st.Rank(1));

            Console.ReadKey();
        }
    }
}
