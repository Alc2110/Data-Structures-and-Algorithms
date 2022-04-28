using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using DataStructures.Graphs;

namespace DataStructures.Graphs.Algorithms
{
    public class BreadthFirstPaths
    {
        private bool[] _marked; // is a shortest path to this vertex known?
        private int[] _edgeTo; // last vertex on known path to this vertex
        private readonly int _source; // source vertex

        public BreadthFirstPaths(Graph graph, int source)
        {
            this._marked = new bool[graph.V];
            this._edgeTo = new int[graph.V];
            this._source = source;

            BreadthFirstSearch(graph, source);
        }

        public void BreadthFirstSearch(Graph g, int s)
        {
            Queue<int> q = new Queue<int>();

            // mark the source vertex and place it on the queue
            this._marked[s] = true;
            q.Enqueue(s);

            while (q.Count != 0)
            {
                int v = q.Dequeue();
                foreach (int w in g.GetAdjacency(v))
                {
                    if (!this._marked[w])
                    {
                        this._edgeTo[w] = v;
                        this._marked[w] = true;
                        q.Enqueue(w);
                    }
                }
            }
        }//BreadthFirstSearch

        /// <summary>
        /// Returns whether a path exists from the source vertex to the vertex v.
        /// </summary>
        /// <param name="v">Destination vertex.</param>
        /// <returns></returns>
        public bool HasPathTo(int v)
        {
            return this._marked[v];
        }

        /// <summary>
        /// Returns the node values of the shortest path from the source vertex to the vertex v.
        /// </summary>
        /// <param name="v">Destination vertex.</param>
        /// <returns>Node values along the path.</returns>
        public IEnumerable<int> PathTo(int v)
        {
            if (!this.HasPathTo(v))
                return null;

            Stack<int> path = new Stack<int>();
            for (int x = v; x != this._source; x = this._edgeTo[x])
            {
                path.Push(x);
            }
            path.Push(this._source);
            return path;
        }

        /// <summary>
        /// Returns the number of edges on the shortest path from the source to the vertext v.
        /// </summary>
        /// <param name="v">Destination vertex.</param>
        /// <returns>Number of edges.</returns>
        public int DistanceTo(int v)
        {
            return PathTo(v).Count()-1;
        }
    }//class
}
