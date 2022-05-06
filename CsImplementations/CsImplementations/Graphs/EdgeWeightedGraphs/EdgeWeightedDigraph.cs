using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures.Graphs.EdgeWeightedGraphs
{
    public class EdgeWeightedDigraph
    {
        private readonly int _v; // number of vertices
        private int _e; // number of edges
        private List<DirectedEdge>[] _adj; // adjacency lists

        public EdgeWeightedDigraph(int vertices)
        {
            this._v = vertices;
            this._e = 0;
            this._adj = new List<DirectedEdge>[this._v];
        }//ctor

        public int NumberOfVertices
        {
            get => this._v;
        }

        public int NumberOfEdges
        {
            get => this._e;
        }

        public void AddEdge(DirectedEdge edge)
        {
            this._adj[edge.From()].Add(edge);
            this._e++;
        }

        public IEnumerable<DirectedEdge> Adjacency(int v)
        {
            return this._adj[v];
        }

        public IEnumerable<DirectedEdge> Edges()
        {
            List<DirectedEdge> edges = new List<DirectedEdge>();
            for (int v = 0; v < this._v; v++)
            {
                foreach (DirectedEdge e in this._adj[v])
                {
                    edges.Add(e);
                }
            }

            return edges;
        }

        public override string ToString()
        {
            StringBuilder graphString = new StringBuilder();
            foreach (var e in this.Edges())
            {
                graphString.AppendLine(e.ToString());
            }

            return graphString.ToString();
        }
    }//class
}
