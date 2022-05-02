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
            UnorderedLinkedListSymbolTable<int, string> st = new UnorderedLinkedListSymbolTable<int, string>();
            st.Insert(1, "one");
            st.Insert(2, "two");
            st.Insert(3, "three");

            Console.WriteLine("IsEmpty: " + st.IsEmpty());
            Console.WriteLine("Size: " + st.Size());

            Console.WriteLine(st.Get(1));
            Console.WriteLine(st.Get(4));

            st.Insert(4, "four");

            Console.WriteLine(st.Get(4));

            st.Delete(4);

            Console.WriteLine(st.Get(4));

            Console.WriteLine("Size: " + st.Size());

            Console.WriteLine("");
            Console.WriteLine("Ordered keys: ");
            foreach (var k in st.Keys())
                Console.WriteLine(k);

            Console.ReadKey();
        }
    }
}
