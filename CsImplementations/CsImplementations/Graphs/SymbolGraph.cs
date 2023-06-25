using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using DataStructures.Graphs;

namespace DataStructures.Graphs
{
    /// <summary>
    /// Graph with vertex names as strings. Uses a symbol table to specify indices of vertices.
    /// </summary>
    public class SymbolGraph
    {
        private Dictionary<string, int> _symbolTable;
        private string[] _keys;
        private Graph _graph;

        public SymbolGraph(string[] lines, string separator)
        {
            this._symbolTable = new Dictionary<string, int>();
            //TODO
            // two passes
            // first pass to build the index
            foreach (var l in lines)
            {
                string[] a = Regex.Split(l, separator);
                for (int i = 0; i < a.Length; i++)
                {
                    if (!this._symbolTable.ContainsKey(a[i]))
                    {

                    }
                }
            }
            // second pass to build the graph
            
        }//ctor

        /// <summary>
        /// Finds whether a key is a vertex.
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public bool Contains(string key)
        {
            return this._symbolTable.ContainsKey(key);
        }

        /// <summary>
        /// Finds the index associated with a key.
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public int IndexOf(string key)
        {
            return this._symbolTable[key];
        }

        /// <summary>
        /// Finds the key associated with index.
        /// </summary>
        /// <param name="v">Index.</param>
        /// <returns></returns>
        public string NameOf(int v)
        {
            return this._keys[v];
        }

        /// <summary>
        /// Underlying graph.
        /// </summary>
        /// <returns></returns>
        public Graph Graph() => this._graph;
    }//class
}
