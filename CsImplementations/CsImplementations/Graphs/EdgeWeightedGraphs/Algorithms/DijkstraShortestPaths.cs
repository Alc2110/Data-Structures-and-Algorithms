using System;
using System.Collections.Generic;
using System.Text;
using DataStructures.Graphs.EdgeWeightedGraphs;
using DataStructures.Queues;

namespace DataStructures.Graphs.EdgeWeightedGraphs.Algorithms
{
    public class DijkstraShortestPaths : IShortestPaths
    {
        private DirectedEdge[] _edgeTo;
        private double[] _distanceTo;
        private IndexMinPriorityQueue<double> _pq;

        public DijkstraShortestPaths(EdgeWeightedDigraph graph, int sourceVertex)
        {
            this._edgeTo = new DirectedEdge[graph.NumberOfVertices];
            this._distanceTo = new double[graph.NumberOfVertices];
            this._pq = new IndexMinPriorityQueue<double>(graph.NumberOfVertices);

            for (int v = 0; v < graph.NumberOfVertices; v++)
            {
                this._distanceTo[v] = double.PositiveInfinity;
            }
            this._distanceTo[sourceVertex] = 0.0;

            this._pq.Insert(sourceVertex, 0.0);
            while (!this._pq.IsEmpty())
            {
                Relax(graph, this._pq.DeleteMin());
            }
        }//ctor

        public double DistanceTo(int vertex)
        {
            throw new NotImplementedException();
        }

        public bool HasPathTo(int vertex)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<DirectedEdge> PathTo(int vertext)
        {
            throw new NotImplementedException();
        }

        private void Relax(EdgeWeightedDigraph g, int v)
        {
            foreach (var e in g.Adjacency(v))
            {
                int w = e.To();
                if (this._distanceTo[w] > this._distanceTo[v] + e.Weight)
                {
                    this._distanceTo[w] = this._distanceTo[v] + e.Weight;
                    this._edgeTo[w] = e;

                    if (this._pq.Contains(w))
                        this._pq.ChangeKey(w, this._distanceTo[w]);
                    else
                        this._pq.Insert(w, this._distanceTo[w]);
                }
            }
        }
    }//class
}
