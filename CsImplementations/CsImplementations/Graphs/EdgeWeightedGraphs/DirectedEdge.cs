using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures.Graphs.EdgeWeightedGraphs
{
    public class DirectedEdge
    {
        private readonly int _v; // tail
        private readonly int _w; // head
        private readonly double _weight;

        public DirectedEdge(int v, int w, double weight)
        {
            this._v = v;
            this._w = w;
            this._weight = weight;
        }//ctor

        public double Weight
        {
            get => this._weight;
        }

        public int From() => this._v;

        public int To() => this._w;

        public override string ToString()
        {
            return (this._v + ", " + this._w + ", " + this._weight);
        }
    }//class
}
